using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using buyticketforbus.Models.UserViewModels;
using buyticketforbus.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace buyticketforbus.Controllers
{
    
    public class UsersController : Controller
    {
        private IUserService _userService;
        private IMailService _mailService;
        public UsersController(IUserService userService, IMailService mailService)
        {
            _mailService = mailService;
            _userService = userService;
        }
        public IActionResult Register(){
            return View();
        }
       
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel registerViewModel){
            if (ModelState.IsValid){
                var result = await _userService.Register(registerViewModel);
            if(result.Succeeded){
                var tokenModel = await _userService.GenerateEmailConfirmationToken(registerViewModel.Email);
                
                generateUrl("ConfirmEmail","Users",tokenModel.userId ??"",tokenModel.token??"",registerViewModel.Email,"Hesap Onayı",$"Lütfen hesabınızı onaylamak için  <a href='http://localhost:5068");

                return RedirectToAction("Index","Home");
            }
            else{
                foreach (var item in result.Errors)
                {
                ModelState.AddModelError("",item.Description);
                }
            }
        }
        return View(registerViewModel);
    }
    public async Task<IActionResult> ConfirmEmail(string userId, string token){
        if(userId==null || token == null){
            ModelState.AddModelError("","Geçersiz Token Bilgisi");
            return View();
        }   
        var result = await _userService.ConfirmEmail(userId, token);
            if(result.Succeeded){
                return View();
            }
        
        ModelState.AddModelError("","Kullanıcı Bulunamadı");
        return View();
    }
    public IActionResult Login(){
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Login(LoginViewModel loginViewModel){
        if (ModelState.IsValid){
            var result= await _userService.Login(loginViewModel);
            if(result.Succeeded){
                return RedirectToAction("Index","Home");
            }
            if(result.RequiresTwoFactor){
                ModelState.AddModelError("","Hesabınızı Onaylayın");
                return View();
            }
            ModelState.AddModelError("","Parola veya Email hatalı"?? "");
            return View(loginViewModel);
        }
        else{
            return View(loginViewModel);
        }
    }
    public IActionResult ForgotPassword(){
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> ForgotPassword(string Email){
        if(!string.IsNullOrEmpty(Email)){
            var tokenModel = await _userService.GeneratePasswordResetToken(Email);

            if(String.IsNullOrEmpty(tokenModel.token) || String.IsNullOrEmpty(tokenModel.userId)){
                ModelState.AddModelError("","Token oluşturalamadı");
                return View();
            }
            generateUrl("ResetPassword","Users",tokenModel.userId,tokenModel.token,Email,"Parola Sıfırlama","$Parolanızı sıfırlamak için linke <a href='http://localhost:5068");
     
            return RedirectToAction("Index","Home");
        }
        ModelState.AddModelError("","Geçerli Email Giriniz");
        return View();
    }

    public IActionResult ResetPassword(string userId, string token){
        var model = new ResetPasswordViewModel {token=token,Id=userId};
            return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> ResetPassword(ResetPasswordViewModel model){
        if(ModelState.IsValid){
            var result = await _userService.ResetPassword(model.Id,model.token,model.Password??"");
            if(result.Succeeded){
                return RedirectToAction("Login","Users");
            }    
            else
            {
                foreach (var item in result.Errors)
                {
                    ModelState.AddModelError ("",item.Description);
                    
                }
                return View(model);
            }
            }
            return View(model);
        }
    public async void generateUrl(string action,string controller,string userId,string token,string email,string subject,string context){
        var url = Url.Action(action,controller,new{userId,token});

        await _mailService.SendEmailAsync(email,subject,context+url+"'>tıklayın</a>");
        }
    }
    
}

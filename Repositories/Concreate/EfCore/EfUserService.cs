using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Controllers;
using buyticketforbus.Data;
using buyticketforbus.Models.UserViewModels;
using buyticketforbus.Repositories.Abstract;
using buyticketforbus.Repositories.Context;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.EntityFrameworkCore;
namespace buyticketforbus.Repositories.Concreate.EfCore
{
    public class EfUserService : IUserService
    {
        UserManager<AppUser> _userManager;
        SignInManager<AppUser> _signInManager;

        public EfUserService(UserManager<AppUser> userManager,SignInManager<AppUser> signInManager)
        {
            _signInManager=signInManager;
            _userManager = userManager;
        }
     

        public void DeleteAccount()
        {
            throw new NotImplementedException();
        }
        public async Task<Microsoft.AspNetCore.Identity.SignInResult> Login(LoginViewModel model){
            var user = await GetUserByEmail(model.Email);
            if (user == null){
                return Microsoft.AspNetCore.Identity.SignInResult.Failed;
            }
            else{
                if(!await _userManager.IsEmailConfirmedAsync(user)){
                    return Microsoft.AspNetCore.Identity.SignInResult.TwoFactorRequired;
                }
                await _signInManager.SignOutAsync();
                return await _signInManager.PasswordSignInAsync(user,model.Password,model.RememberMe,false);
            }
        }
        public async Task<IdentityResult> Register(RegisterViewModel registerViewModel)
        {
            var user = new AppUser{
                 UserName = registerViewModel.UserName,
                    FirstName=registerViewModel.FirstName,
                    LastName=registerViewModel.LastName,
                    Email = registerViewModel.Email,
                    PhoneNumber = registerViewModel.PhoneNumber
            };
            return await _userManager.CreateAsync(user,registerViewModel.Password);
         }
        public async Task <EmailConfirmViewModel> GenerateEmailConfirmationToken(String email){
            var user =await GetUserByEmail(email);
            var token = _userManager.GenerateEmailConfirmationTokenAsync(user).Result;
            return new EmailConfirmViewModel{userId=user.Id,token=token}; 
        }
        public async Task<PasswordResetMail> GeneratePasswordResetToken(string Email){
            var user = await _userManager.Users.FirstOrDefaultAsync(e=>e.Email==Email);
            if(user != null){
                var token=await _userManager.GeneratePasswordResetTokenAsync(user);
                return new PasswordResetMail{token = token,userId=user.Id};
            }
            else return new PasswordResetMail{token="",userId=""};
        }   
        public async Task<IdentityResult> ResetPassword(string Id,string token,string newPassword)
        {
            var user = await GetUserById(Id);
            return await _userManager.ResetPasswordAsync(user,token,newPassword);
        }

        public async Task<AppUser> GetUserById(string id){
            var user= await _userManager.Users.FirstOrDefaultAsync(i=>i.Id==id);
            return user;
        }

        public async Task<AppUser> GetUserByEmail(string email){
            var user =  await _userManager.Users.FirstOrDefaultAsync(e=>e.Email==email);
            return user;
        }
        public async Task<IdentityResult> ConfirmEmail(string Id,string token){
            var user = await GetUserById(Id);
            return await _userManager.ConfirmEmailAsync(user,token);
        }
    }
}
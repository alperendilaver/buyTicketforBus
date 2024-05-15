using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Models.PersonelViewModels;
using buyticketforbus.Repositories.Abstract;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace buyticketforbus.Controllers
{
    public class PersonelsController : Controller
    {
        private readonly IPersonelService _personelService;
        
        public PersonelsController(IPersonelService personelService)
        {
            _personelService = personelService;
        }
 
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(PersonelCreateViewModel model)
        {
            var result = await _personelService.Create(model);
            if(result > 0){
                return RedirectToAction("Index","Home");
            }
            else{
                ModelState.AddModelError("","Kullanıcı Eklenemedi Tekrar Deneyiniz");
                return View(model);
            }
        }

        public async Task<IActionResult> Edit(string Id){
            var personel = await _personelService.GetPersonelById(Id);
            if(string.IsNullOrEmpty(personel.SurName)){
                return RedirectToAction("Index","Home");
            }
            return View(new PersonelUpdateViewModel{
                Email=personel.email,
                FirstName=personel.FirstName,
                PhoneNumber=personel.phoneNumber,
                SurName=personel.SurName,
                GovernmentId = personel.GovernmentId
            });
        }
        [HttpPost]
        public async Task<IActionResult> Edit(PersonelUpdateViewModel model)
        {
            if(ModelState.IsValid){
                var result = await _personelService.Update(model);
                if(result>0){
                    return RedirectToAction("Index","Home");
                }
                ModelState.AddModelError("","Düzenleme Başarısız Oldu");
                return View(model);
            }
            return View(model);
        }
        
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using buyticketforbus.Models.PersonelViewModels;
using buyticketforbus.Repositories.Abstract;
using buyticketforbus.Repositories.Context;
using Microsoft.EntityFrameworkCore;

namespace buyticketforbus.Repositories.Concreate.EfCore
{
    public class EfPersonelService : IPersonelService
    {
        private CombinedContext _context;
        public EfPersonelService(CombinedContext combinedContext)
        {
            _context = combinedContext;
        }
        public async Task<int> Create(PersonelCreateViewModel model)
        {
            var personel=new Personel{
                email=model.Email,
                FirstName=model.FirstName,
                SurName=model.SurName,
                Gender = model.Gender,
                GovernmentId=model.GovernmentId,
                phoneNumber=model.PhoneNumber,
                Role = model.Role,
            };
            var result = await _context.AddAsync(personel);
            if(result.State==Microsoft.EntityFrameworkCore.EntityState.Added){
                var effectedRows=await _context.SaveChangesAsync();
                return effectedRows;
            }
            return 0;
 
        }

        public async Task<Personel> GetPersonelById(string GovernmentId)
        {
            var personel = await _context.personels.FirstOrDefaultAsync(u=>u.GovernmentId==GovernmentId);
            return personel ?? new Personel();
        }

        public async Task<int> Update(PersonelUpdateViewModel model)
        {
            var personel = await GetPersonelById(model.GovernmentId);
            if(personel==null){
                return 0;
            }
            personel.email = model.Email;
            personel.phoneNumber=model.PhoneNumber;
            personel.SurName=model.SurName;
            personel.FirstName = model.FirstName;
            var result=_context.personels.Update(personel);
            if(result.State==EntityState.Modified){
                var effectedRows = await _context.SaveChangesAsync();
                return effectedRows;        
            }
            return 0;
        }
    }
}
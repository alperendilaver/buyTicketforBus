using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using buyticketforbus.Models.PersonelViewModels;

namespace buyticketforbus.Repositories.Abstract
{
    public interface IPersonelService
    {
        Task<int> Create(PersonelCreateViewModel model);

        Task<int> Update(PersonelUpdateViewModel model);

        Task<Personel> GetPersonelById(string GovernmentId); 
    }
}
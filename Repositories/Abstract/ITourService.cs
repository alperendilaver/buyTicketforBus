using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using buyticketforbus.Models.TourViewModels;

namespace buyticketforbus.Repositories.Abstract
{
    public interface ITourService
    {

        Task<IQueryable> hosts();
        Task<IQueryable> tours();        
        Task<IQueryable> drivers();
        public Driver GetDriverById(int id);
        public HostofBus GetHostofBusById(int id);
        public void CreateTour(CreateTourViewModel model);

        public void DeleteTour(int id);

        public void UpdateTour(int id,EditTourViewModel model);

      
        public Tour GetTourById(int id);    
    }
}
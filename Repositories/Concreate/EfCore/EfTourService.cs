using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using buyticketforbus.Models.TourViewModels;
using buyticketforbus.Repositories.Abstract;
using buyticketforbus.Repositories.Context;
using Microsoft.EntityFrameworkCore;

namespace buyticketforbus.Repositories.Concreate.EfCore
{
    public class EfTourService : ITourService
    {
        CombinedContext _context;
        public EfTourService(CombinedContext combinedContext)
        {
            _context = combinedContext;
        }


        public void CreateTour(CreateTourViewModel model)
        {
    
            throw new NotImplementedException();
        }

        public void DeleteTour(int id)
        {
            throw new NotImplementedException();
        }


        public Driver GetDriverById(int id)
        {
            throw new NotImplementedException();
        }

        public HostofBus GetHostofBusById(int id)
        {
            throw new NotImplementedException();
        }

        public Tour GetTourById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IQueryable> drivers()
        {
            return await Task.FromResult(_context.drivers);
        }
        public async Task<IQueryable> hosts()
        {
            return await Task.FromResult(_context.hosts);
        }

        public async Task<IQueryable> tours()
        {
            return await Task.FromResult(_context.tours);
        }

        public void UpdateTour(int id, EditTourViewModel model)
        {
            throw new NotImplementedException();
        }
    }
}
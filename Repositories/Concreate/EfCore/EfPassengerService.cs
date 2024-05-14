using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using buyticketforbus.Repositories.Abstract;

namespace buyticketforbus.Repositories.Concreate.EfCore
{
    public class EfPassengerService : IPassengerService
    {
        public void AddPassengertoStation(int StationId, Passenger passenger)
        {
            throw new NotImplementedException();
        }

        public void buyTicket()
        {
            throw new NotImplementedException();
        }

        public void cancelTicket()
        {
            throw new NotImplementedException();
        }

        public void ChangeSeat(Passenger passenger, int NewSeatNo)
        {
            throw new NotImplementedException();
        }

        public void FindTour(string station1, string station2, DateTime date)
        {
            throw new NotImplementedException();
        }

        public List<int> GetAvailableSeats(int StationId)
        {
            throw new NotImplementedException();
        }

        public void RemovePassengerfromStation(int StationId, Passenger passenger)
        {
            throw new NotImplementedException();
        }
    }
}
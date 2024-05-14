using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;

namespace buyticketforbus.Repositories.Abstract
{
    public interface IPassengerService
    {
        public void AddPassengertoStation(int StationId,Passenger passenger);

        public void RemovePassengerfromStation(int StationId,Passenger passenger);

        public void ChangeSeat(Passenger passenger,int NewSeatNo);

        public List<int> GetAvailableSeats(int StationId);

        public void buyTicket();

        public void cancelTicket();

        public void FindTour(string station1,string station2,DateTime date);

    }
}
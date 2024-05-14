using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Data
{
    public class Station
    {
        public int StationId { get; set;}

        public Tour tour { get; set; } = null!;
        public string Name { get; set; } = String.Empty;

        public List<Passenger> passengers { get; set; } = new List<Passenger>();
    
        public int departureTime { get; set; }
    
        public int arrivedTime { get; set; }
    
        public int kacinciDurak { get; set; }

        public int price { get; set; }
    }
}
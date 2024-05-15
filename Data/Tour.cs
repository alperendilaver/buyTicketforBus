using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Data
{
    public class Tour
    {
        public int tourId { get; set; }

        public List<Station> stations { get; set; } =null!;

        public int expectedArrivedTime { get; set; }
    
        public int firstStation { get; set; }
    
        public int finishStation { get; set; }

        public DateTime departureTime { get; set; }
    
        public Bus bus { get; set; } = null!;

        public List<Personel> personels { get; set; } = new List<Personel>();

      }
}
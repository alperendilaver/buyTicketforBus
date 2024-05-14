using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Data
{
    public class Bus
    {
        public int BusId { get; set; }

        public string Marka { get; set; } = String.Empty;
    
        public string Model { get; set; }=String.Empty;
    
        public string Plaka { get; set; }=String.Empty;
    
        public int koltukSayisi { get; set; }
    }
}
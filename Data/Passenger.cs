using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Data
{
    public class Passenger:Person
    {
        [Key]
        public int PassengerId { get; set; }
        public int KoltukNo { get; set; }
        public int depertureStation { get; set; }
        public int finishStation { get; set; }    
        public List<Station> stations{ get; set; } = new List<Station>();
    }

}
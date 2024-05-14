using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Data
{
    public class Driver:Person
    {
        [Key]
        public int DriverId { get; set; }

        public int TourId { get; set; }
        public Tour? tour { get; set; }

    }
}
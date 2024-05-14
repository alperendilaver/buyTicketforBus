using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Data
{
    public class HostofBus:Person
    {
        [Key]
        public int HostsId { get; set; }
        public int? tourId { get; set; }
        public Tour? tour { get; set; }
    }
}
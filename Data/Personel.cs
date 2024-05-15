using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Data
{
    public class Personel:Person{
        [Key]
        public int PersonelId { get; set; }
    
        public bool Role { get; set; }
    }
}
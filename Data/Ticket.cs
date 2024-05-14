using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Data
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public AppUser user { get; set; } = null!;

        public string pnrNo { get; set; } =String.Empty;

        public Tour tour { get; set; } = null!;
    
        public int price { get; set; }
    
        public Passenger passenger { get; set; }=null!;
    }
}
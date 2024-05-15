using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Models.PersonelViewModels
{
    public class PersonelCreateViewModel
    {

        public required string FirstName { get; set; }

        public required string SurName { get; set; }
        public required string GovernmentId { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Email { get; set; }
        public bool Gender { get; set; }
        public bool Role { get; set; }
    }
}
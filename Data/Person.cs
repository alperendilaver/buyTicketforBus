using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace buyticketforbus.Data
{
    [Index(nameof(GovernmentId),IsUnique = true)]
    public class Person
    {
        public bool Gender { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string SurName { get; set; } = string.Empty;
        public string FullName { get{
            return FirstName+" "+SurName;
        } }
        public string GovernmentId { get; set; } = string.Empty;
        public string phoneNumber { get; set; } = string.Empty;
   
        public string email { get; set; } = String.Empty;
    }
}
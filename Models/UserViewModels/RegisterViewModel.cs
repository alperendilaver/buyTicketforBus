using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Models.UserViewModels
{
    public class RegisterViewModel
    {
        [Required]
        public required string FirstName { get; set; } = string.Empty;
        
        [Required]
        public required string LastName { get; set; } = string.Empty;

        [Required]
        public required string UserName { get; set; }

        [Required]
        [DataType(DataType.PhoneNumber)]
        public required string PhoneNumber { get; set; }


        [Required]
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public required string Password { get; set; }

        [Required]
        [Compare(nameof(Password))]
        public required string ConfirmPassword { get; set; }
   
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Models.UserViewModels
{
    public class ResetPasswordViewModel
    {
        public required string token { get; set; }
    
        public string? Id { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string? Password { get; set; }
    }
}
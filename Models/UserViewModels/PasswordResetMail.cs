using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace buyticketforbus.Models.UserViewModels
{
    public class PasswordResetMail
    {
        public string? userId { get; set; }
        public string? token { get; set; }
    }
}
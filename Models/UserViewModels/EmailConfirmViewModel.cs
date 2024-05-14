using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Models.UserViewModels
{
    public class EmailConfirmViewModel
    {
        public string? token { get; set; }
        public string? userId { get; set; }
    }
}
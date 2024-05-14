using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace buyticketforbus.Repositories.Abstract
{
    public interface IMailService
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace buyticketforbus.Repositories.Context
{
    public class IdentityContext :IdentityDbContext<AppUser,IdentityRole,string>
    {
        public IdentityContext(DbContextOptions options) : base(options)
        {
            
        }

        
    }
}
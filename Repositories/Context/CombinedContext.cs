using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using buyticketforbus.Data;
using Microsoft.EntityFrameworkCore;

namespace buyticketforbus.Repositories.Context
{
    public class CombinedContext :IdentityContext 
    {
        public CombinedContext(DbContextOptions <CombinedContext> options): base(options)
        {
            
        }

        public DbSet<AppUser> appUsers => Set<AppUser>();
        
        public DbSet<Bus> buses => Set<Bus>();
        
        public DbSet<Passenger> passengers => Set<Passenger>();
        
        public DbSet<Driver> drivers => Set<Driver>();
        public DbSet<HostofBus> hosts => Set<HostofBus>();
        
        public DbSet<Station> stations => Set<Station>();
        
        public DbSet<Ticket> tickets => Set<Ticket>();
        
        public DbSet<Tour> tours => Set<Tour>();

    }
}
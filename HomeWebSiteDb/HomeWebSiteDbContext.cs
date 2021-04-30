using HomeWebSiteDb.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSiteDb
{
    public class HomeWebSiteDbContext : IdentityDbContext<User>
    {
        public HomeWebSiteDbContext(DbContextOptions<HomeWebSiteDbContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

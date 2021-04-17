using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSite.Models
{
    public class HomeWebSiteContext : IdentityDbContext<User>
    {
        public HomeWebSiteContext(DbContextOptions<HomeWebSiteContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSite.Models
{
    public class User : IdentityUser
    {
        public string Login { get; set; }
        public string MiddleName { get; set; }
    }
}

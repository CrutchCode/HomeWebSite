using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;

namespace HomeWebSite.Options
{
    public static class OptionsUserPassword
    {
        private static readonly IConfiguration configuration;
        static OptionsUserPassword()
        {
            configuration = new ConfigurationBuilder().AddJsonFile("ConfigSettings.json").Build();
        }
        public static PasswordOptions CreateOptionsPassword() 
        {
            return new PasswordOptions
            {
                RequiredLength = int.Parse(configuration["RequiredLength"]),
                RequireNonAlphanumeric = bool.Parse(configuration["RequireNonAlphanumeric"]),
                RequireLowercase = bool.Parse(configuration["RequireLowercase"]),
                RequireUppercase = bool.Parse(configuration["RequireUppercase"]),
                RequireDigit = bool.Parse(configuration["RequireDigit"])
            };
        }
    }
}

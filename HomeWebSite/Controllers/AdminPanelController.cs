using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeWebSite.Controllers
{
    //[Authorize(Roles = "Admin")]
    public class AdminPanelController : Controller
    {
        [HttpGet]
        public IActionResult Admin()
        {
            return View();
        }
    }
}

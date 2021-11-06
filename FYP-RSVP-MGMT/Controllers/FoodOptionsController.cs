using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_RSVP_MGMT.Controllers
{
    public class FoodOptionsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

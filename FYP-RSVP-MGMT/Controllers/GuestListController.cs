using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FYP_RSVP_MGMT.ViewModels;

namespace FYP_RSVP_MGMT.Controllers
{
    public class GuestListController : Controller
    {
        public IActionResult Index()
        {
            GuestListViewModel guest = new GuestListViewModel();

            return View(guest);
        }

        public IActionResult AddUser(GuestListViewModel, guest)
        {
            return View();
        }
    }
}

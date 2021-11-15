using FYP_RSVP_MGMT.Helpers;
using FYP_RSVP_MGMT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_RSVP_MGMT.Controllers
{
    public class LoginDetailsController : Controller
    {
        public IActionResult Index()
        {
            LoginDetailsViewModel user = new LoginDetailsViewModel();

            return View("Index", user);

        }

       // public IActionResult CreateUpdate(LoginDetailsViewModel user)
        //{
           // if (ModelState.IsValid)
            //{
               // using (var db = DbHelpers.GetConnection())
                //{

                   // if (user.EditableUser.UserID == null)
                   // {
                       // user.EditableUser.GuestID = user.Users.Count;
                    //}
                //}
           // }

        //}

    }

}

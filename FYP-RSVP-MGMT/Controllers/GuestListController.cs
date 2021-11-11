﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FYP_RSVP_MGMT.ViewModels;
using FYP_RSVP_MGMT.Helpers;
using FYP_RSVP_MGMT.Models;
using Dapper;
using Dapper.Contrib.Extensions;

namespace FYP_RSVP_MGMT.Controllers
{
    public class GuestListController : Controller
    {
        public IActionResult Index()
        {
            GuestListViewModel guest = new GuestListViewModel();

            return View("Index", guest);
        }

        public IActionResult CreateUpdate(GuestListViewModel guest)
        {
            if(ModelState.IsValid)
            {
                using (var db = DbHelpers.GetConnection()) {

                    if(guest.EditableGuest.GuestID == null)
                    {
                        /* Count the existing IDs and adds the next ID */
                        guest.EditableGuest.GuestID = guest.Guests.Count;

                        db.Insert<GuestList>(guest.EditableGuest);
                    }

                    /* If the guest already exists, we are updating the details*/
                    else
                    {
                        GuestList dbItem = db.Get<GuestList>(guest.EditableGuest.GuestID);

                        TryUpdateModelAsync<GuestList>(dbItem, "EditableGuest");

                        db.Update<GuestList>(dbItem);
                    }
                }

                return RedirectToAction("ViewGuestList");
            }

            else
            {
                return View("Index", new GuestListViewModel());
            }
           
        }

        public IActionResult Edit(int Id)
        {
            GuestListViewModel guest = new GuestListViewModel();

            guest.EditableGuest = guest.Guests.FirstOrDefault(x => x.GuestID == Id);

            return View("Index", guest);
        }

        public IActionResult Delete(int Id)
        {
            using (var db = DbHelpers.GetConnection())
            {
                GuestList guest = db.Get<GuestList>(Id);

                if (guest!= null)
                    db.Delete(guest);
                return RedirectToAction("Index");
                
            }
        }
    }
}

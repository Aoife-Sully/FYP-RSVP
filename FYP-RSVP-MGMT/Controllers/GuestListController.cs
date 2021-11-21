
using Dapper.Contrib.Extensions;
using FYP_RSVP_MGMT.Helpers;
using FYP_RSVP_MGMT.Models;
using FYP_RSVP_MGMT.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace FYP_RSVP_MGMT.Controllers
{
    public class GuestListController : Controller
    {
        public IActionResult Index()
        {
            GuestListViewModel guest = new GuestListViewModel();

            return View("Index", guest);
        }

        /* Create or Update a guest RSVP Response */

        public IActionResult CreateUpdate(GuestListViewModel guest)
        {
            if (ModelState.IsValid)
            {
                using (var db = DbHelpers.GetConnection())
                {
                    /* If a guestID is null, the number of existing guests will be counted
                     * in order to determine what the next guestID will be and will be added 
                     * asynchronously to the DB in case other actions are on going at the same time */
                     
                    if (guest.EditableGuest.GuestID == null)
                    {
                        guest.EditableGuest.GuestID = guest.Guests.Count + 1;

                        db.InsertAsync<GuestList>(guest.EditableGuest);
                    }

                    /* If the guest already exists, we are updating their details */
                    else
                    {
                        GuestList dbItem = db.Get<GuestList>(guest.EditableGuest.GuestID);

                        TryUpdateModelAsync<GuestList>(dbItem, "EditableGuest");

                        db.Update<GuestList>(dbItem);
                    }
                }

                /* When a guest submits their RSVP response, it will bring them to a page that acknowledges their response */
                return RedirectToAction("ResponseReceived", guest);
            }

            else
            {
                return View("ViewGuestList", new GuestList());
            }
        }

        public IActionResult EditDetails(int Id)
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

                /* if a guest exists then delete it and return the default action */

                if (guest != null)
                    db.Delete(guest);

                return RedirectToAction("Index");
            }
        }

        /* Allow a user to view all guests that have RSVP'd */

        public IActionResult ViewGuestList()
        {
            GuestListViewModel guest = new GuestListViewModel();

            return View(guest);
        }

        /* Acknowledges that the guests response has been received */ 
        public IActionResult ResponseReceived()
        {
            GuestListViewModel guest = new GuestListViewModel();

            return View(guest);
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FYP_RSVP_MGMT.Helpers;
using Dapper;
using FYP_RSVP_MGMT.Models;
using Microsoft.Data.SqlClient;

namespace FYP_RSVP_MGMT.ViewModels
{
    public class GuestListViewModel
    {
        public GuestListViewModel()
        {
            using (var db = DbHelpers.GetConnection())
            {
                this.EditableGuest = new GuestList();

                this.Guests = db.Query<GuestList>("Select * From GuestList").ToList();
            }
        }

        public List <GuestList> Guests { get; set; }

        /* Holds any instance of an object that is being added/edited/deleted etc */
        public GuestList EditableGuest { get; set; }


    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FYP_RSVP_MGMT.Helpers;
using Dapper;
using FYP_RSVP_MGMT.Models;
using Microsoft.Data.SqlClient;

namespace FYP_RSVP_MGMT.ViewModels /* Communication between Controller and View */
{
    public class GuestListViewModel
    {
        /* Creating a new List of all Guests 
         Editable Guest will hold any instance of an object from the list
                that is being added/edited/deleted etc */
        public List<GuestList> Guests { get; set; }

       
        public GuestList EditableGuest { get; set; }


        /* Selecting all of the existing guests from the DB */
        public GuestListViewModel()
        {
            using (var db = DbHelpers.GetConnection())
            {
                this.EditableGuest = new GuestList();

                this.Guests = db.Query<GuestList>("Select * From GuestList").ToList();
            }
        }

      


    }

}

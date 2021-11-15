using FYP_RSVP_MGMT.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_RSVP_MGMT.ViewModels
{
    public class LoginDetailsViewModel
    {
     
        public LoginDetailsViewModel()
        {
            using (var db = DbHelpers.GetConnection())
            {
            //    this.EditableUser = new UserList();

             //   this.Users = db.Query<UserList>("Select * From LoginDetails").ToList();
            }
        }

    }

     //public List<UserList> Users { get; set; }

        /* Holds any instance of an object that is being added/edited/deleted etc */
    //public UserList EditableUser { get; set; }
    
}

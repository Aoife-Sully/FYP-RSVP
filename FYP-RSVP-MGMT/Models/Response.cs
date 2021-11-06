using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_RSVP_MGMT.Models
{
    public class Response
    {
        public int ResponseID { get; set; }

        public int GuestID { get; set; }

        public int WeddingID { get; set; }

        public string GuestResponse { get; set; }

        public DateTime RSVPByDate { get; set; }

        public bool ReminderNeeded { get; set; }



    }
}

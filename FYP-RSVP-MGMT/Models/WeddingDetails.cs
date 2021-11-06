using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_RSVP_MGMT.Models
{
    public class WeddingDetails
    {
        public int WeddingID { get; set; }

        public string BrideName { get; set; }

        public string GroomName { get; set; }

        public DateTime WeddingDate { get; set; }

        public int NumberOfGuests { get; set; }

        public string CeremonyVenue { get; set; }

        public string ReceptionVenue { get; set; }




    }
}

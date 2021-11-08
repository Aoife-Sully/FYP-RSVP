using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_RSVP_MGMT.Models
{
    public class GuestList
    {
        public int GuestID { get; set; }

        public string GuestName { get; set; }

        public string GuestType { get; set; }

        public string ContactDetails { get; set; }

        public bool PlusOne { get; set; }

        public string PlusOneName { get; set; }

        public string Response { get; set; }
    }

    /* For creating selection lists for drop down forms */
    public enum GuestType
    {
        WeddingGuest, 
        WeddingPart
    }

    public enum Repsonse
    {
        Accept,
        Decline
    }
}

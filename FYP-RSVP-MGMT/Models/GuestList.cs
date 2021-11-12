using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace FYP_RSVP_MGMT.Models
{
    public class GuestList
    {
        public int? GuestID { get; set; }

        [Required]
        public string GuestName { get; set; }

        [Required]
        public string GuestType { get; set; }

        [Required]
        public string ContactDetails { get; set; }

        public bool PlusOne { get; set; }

        public string PlusOneName { get; set; }

        [Required]
        public string GuestResponse { get; set; }
    }

   
}

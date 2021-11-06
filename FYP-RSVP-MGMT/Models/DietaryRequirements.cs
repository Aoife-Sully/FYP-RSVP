using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_RSVP_MGMT.Models
{
    public class DietaryRequirements
    {
        public int RequirementsID { get; set; }

        public int GuestID { get; set; }

        public string Allergies { get; set; }

        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }

        public bool Coeliac { get; set; }

        public string Other { get; set; }

    }
}

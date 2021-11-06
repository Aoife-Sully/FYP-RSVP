using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FYP_RSVP_MGMT.Models
{
    public class FoodOptions
    {
        public int OptionID { get; set; }

        public int RequirementsID { get; set; }

        public int GuestID { get; set; }

        public bool MeatOption1 { get; set; }

        public bool MeatOption2 { get; set; }

        public bool FishOption { get; set; }

        public bool VegetarianOption { get; set; }

        public bool VeganOption { get; set; }


}
}

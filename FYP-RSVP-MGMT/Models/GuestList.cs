using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace FYP_RSVP_MGMT.Models
{
    [Table("GuestList")] /* Dapper assumes pluralized table name which breaka the code https://stackoverflow.com/questions/32204808/dapper-use-singular-table-name/32205064*/
    public class  GuestList  
        
    {      

        [ExplicitKey]
        public int? GuestID { get; set; }


        [Required]
        public string GuestName { get; set; }


        [Required]
        public string GuestType { get; set; }


        [Required]
        [EmailAddress]
        public string ContactDetails { get; set; }


        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }


        public bool PlusOne { get; set; }


        public string PlusOneName { get; set; }


        [Required]
        public string GuestResponse { get; set; }

    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace RentedMovieOneValid.Models
{
    public class Customer
    {
        public int id { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name ="Customer Name")]
        public string name { get; set; }
        [Display(Name = "Birth Date")]
        public DateTime DateOfBirth { get; set; }
        //reference the table
        public MembershipType MembershipType { get; set; }
        //reference a column
        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }
    }
}
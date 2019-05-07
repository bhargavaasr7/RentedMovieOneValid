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



      [Required]
        [Display(Name = "Birth Date")]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }



        //reference the table
        public MembershipType MembershipType { get; set; }


        [Required]
        //reference a column
        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }
    }
}
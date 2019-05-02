using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentedMovieOneValid.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
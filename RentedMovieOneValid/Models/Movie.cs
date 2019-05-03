using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RentedMovieOneValid.Models
{
    public class Movie
    {
        public int id { get; set; }
        public string MovieName { get; set; }
        //create refernce
        public Genre Genre { get; set; }
        //add reference
        public int GenreId { get; set; }
    }
}

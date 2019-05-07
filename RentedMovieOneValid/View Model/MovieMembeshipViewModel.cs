using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RentedMovieOneValid.Models;
namespace RentedMovieOneValid.View_Model
{
    public class MovieMembeshipViewModel
    {
        public Movie Movie { get; set; }
        public List<Genre> genres { get; set; }
    }
}
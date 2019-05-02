using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RentedMovieOneValid.Models;

namespace RentedMovieOneValid.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies
        public ActionResult Index_Movie()
        {
            List<Movies> movies = GetMovies();
            return View(movies);
        }
        public List<Movies> GetMovies()
        {
            List<Movies> movies = new List<Movies>
            {
                new Movies{id=1,MovieName="Oopiri"},
                new Movies{id=2,MovieName="Race gurram"},
                new Movies{id=3,MovieName="Run_Raja_Run"}
            };
            return movies;
        }
    }
}
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
            List<Movie> movies = GetMovies();
            return View(movies);
        }
        public List<Movie> GetMovies()
        {
            List<Movie> movies = new List<Movie>
            {
                new Movie{id=1,MovieName="Oopiri"},
                new Movie{id=2,MovieName="Race gurram"},
                new Movie{id=3,MovieName="Run_Raja_Run"}
            };
            return movies;
        }
    }
}
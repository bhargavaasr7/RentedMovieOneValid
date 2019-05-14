using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Web.Mvc;
using RentedMovieOneValid.Models;
using RentedMovieOneValid.View_Model;


namespace RentedMovieOneValid.Controllers
{
    [RequireHttps]
    [Authorize]
    public class MoviesController : Controller
    {
        private ApplicationDbContext dbContext=null;
        // GET: Movies
        public MoviesController()
        {
            dbContext = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            dbContext.Dispose();
        }
        public ActionResult Index_Movie()
        {
                List<Movie> movies= dbContext.Movies.Include(m => m.Genre).ToList();
                return View(movies);
        }
        public ActionResult Movie_Details(int id)
        {
            var movie = dbContext.Movies.Include(m => m.Genre).SingleOrDefault(c => c.id == id);
            if (movie == null)
            {
                return HttpNotFound();
            }
            return View(movie);
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
        [HttpGet]
        public ActionResult Create_Movie()
        {
            MovieMembeshipViewModel viewModel = new MovieMembeshipViewModel();
            Movie movie = new Movie();
            var genre = dbContext.genres.ToList();
            viewModel.Movie = movie;
            viewModel.genres = genre;
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Create_Movie(Movie movie)
        {
            dbContext.Movies.Add(movie);
            dbContext.SaveChanges();
            return RedirectToAction("Index_Movie", "Movies");
        }
        [HttpGet]
        [Authorize(Users ="bhargav,bhargavas")]
        public ActionResult Edit_Movie(int id)
        {
            var movie = dbContext.Movies.SingleOrDefault(c => c.id == id);
            var genre = dbContext.genres.ToList();
           MovieMembeshipViewModel viewModel = new MovieMembeshipViewModel
            {
                Movie = movie,
                genres = genre
            };
            return View(viewModel);
        }
        [HttpPost]
        public ActionResult Edit_Movie(Movie movie)
        {
            var movieTbl = dbContext.Movies.SingleOrDefault(c => c.id == movie.id);
            if (movieTbl == null)
            {
                return HttpNotFound();
            }
            else
            {
                movieTbl.MovieName = movie.MovieName;
                movieTbl.ReleaseDate = movie.ReleaseDate;
                movieTbl.Adddate = movie.Adddate;
                dbContext.SaveChanges();
            }
            return RedirectToAction("Index_Movie", "Movie");
        }
    }
}
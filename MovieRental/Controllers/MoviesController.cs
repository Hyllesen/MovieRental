using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MovieRental.Models;
using Vidly.Models;
using Vidly.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: Movies
        public ActionResult Random()
        {
            var movie = new Movie()
            {
                Id = 0,
                Name = "The Room"
            };

            var customers = new List<Customer>
            {
                new Customer() {Name = "Stefan Hyltoft"},
                new Customer() {Name = "Anders Hansen"}
            };

            var viewModel = new RandomMovieViewModel()
            {
                Movie = movie,
                Customers = customers
            };
           
            return View(viewModel);
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByReleaseDate(int year, int month)
        {
            return Content(year + "/" + month);
        }
        
        public ActionResult Edit(int movieId)
        {
            return Content("id=" + movieId);
        }

        public ActionResult Index()
        {
            var movies = _context.Movies.Include(o => o.Genre).ToList();

            return View(movies);
        }

        public ActionResult Details(int id)
        {
            var movies = _context.Movies.Include(o => o.Genre).SingleOrDefault(c => c.Id == id);

            if (movies == null)
                return HttpNotFound();

            return View(movies);
        }

        public ActionResult New()
        {
            return View("Details");
        }
    }
}
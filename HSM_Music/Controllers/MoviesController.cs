using HSM_Music.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HSM_Music.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext(); 
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Movies
        public ActionResult Index()
        {
            var movies = _context.Movies; 
            return View();
        }

        public ActionResult Details(int id)
        {
            var movie = _context.Movies.SingleOrDefault(c=>c.Id == id);
            if (movie == null)
                return HttpNotFound();

            return View(movie); 
        }
    }
}
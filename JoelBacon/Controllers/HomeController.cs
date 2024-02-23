using Mission06_Lush.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace Mission06_Lush.Controllers
{
    public class HomeController : Controller
    {
        private JoelHiltonMovieCollectionContext _context;

        public HomeController(JoelHiltonMovieCollectionContext temp) 
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult MovieForm()
        {
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();

            return View("MovieForm",new Movies());
        }

        [HttpPost]
        public IActionResult MovieForm(Movies response) 
        {
            if(!ModelState.IsValid)
            {
                return View(response);
            }
            else
            {
                _context.Movies.Add(response);
                _context.SaveChanges();

                return View("Confirmation", response);
            }
            
        }

        //public IActionResult MovieList()
        //{
        //    var movieSet = _context.Movies.Include(x => x.Category)
        //        .OrderBy(x => x.MovieId).ToList();

        //    return View(movieSet);
        //}

        [HttpGet]
        public IActionResult MovieList()
        {
            var movieSet = _context.Movies
                .Include("Category")
                .ToList();
            return View(movieSet);
        }

        [HttpGet]

        public IActionResult Edit(int id)
        {
            var recordToEdit = _context.Movies
                .Single(x => x.MovieId== id);
            ViewBag.Categories = _context.Categories
                .OrderBy(x => x.Category)
                .ToList();
            return View("MovieForm",recordToEdit);
        }
        [HttpPost]
        public IActionResult Edit(Movies mov)
        {
            _context.Update(mov);
            _context.SaveChanges();

            return RedirectToAction("MovieList");
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var recordToDelete = _context.Movies
                .Single(x => x.MovieId == id);
            return View(recordToDelete);
        }
        [HttpPost]
        public IActionResult Delete(Movies mov)
        {
            _context.Movies.Remove(mov);
            _context.SaveChanges();
            return RedirectToAction("MovieList");
        }
       
    }
}

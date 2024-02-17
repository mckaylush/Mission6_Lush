using Mission06_Lush.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Mission06_Lush.Controllers
{
    public class HomeController : Controller
    {
        private MovieCollectionContext _context;

        public HomeController(MovieCollectionContext temp) 
        {
            _context = temp;
        }

        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult About()
        {
            return View();
        }
        
        [HttpGet]
        public IActionResult Movies()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Movies(Movie response) 
        {
            if (response.LentTo == null)
            {
                response.LentTo = "";
            }
            if (response.Notes== null)
            {
                response.Notes = "";
            }
            if (response.Edited == null)
            {
                response.Edited = false;
            }
            _context.Movies.Add(response);
            _context.SaveChanges();

            return View("Confirmation", response);
        }
    }
}

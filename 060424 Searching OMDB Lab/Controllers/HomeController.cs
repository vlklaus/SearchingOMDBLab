using _060424_Searching_OMDB_Lab.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _060424_Searching_OMDB_Lab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult MovieSearch()
        {
            return View();
        }

        [HttpPost]
        public IActionResult MovieSearch(string Title)
        {
            MovieModel result = MovieDAL.GetMovie(Title);
            return View(result);
        }

        [HttpGet]
        public IActionResult MovieNight()
        {           
            return View();
        }

        [HttpPost]
        public IActionResult MovieNight(string Title1, string Title2, string Title3)
        {
            MovieModel result1 = MovieDAL.GetMovie(Title1);
            MovieModel result2 = MovieDAL.GetMovie(Title2);
            MovieModel result3 = MovieDAL.GetMovie(Title3);

            List<MovieModel> movies = new List<MovieModel>() { result1, result2, result3 };
            return View(movies);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

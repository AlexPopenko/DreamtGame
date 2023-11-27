using DreamtGame.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace DreamtGame.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            GameModel model;
            model = new GameModel();
            return View(model);
        }
        [HttpPost]
        public IActionResult Index(GameModel model)
        {

            
            
            return View(model);
        }

        public IActionResult Game(GameModel model)
        {

            return View("Game", model);
        }
        [HttpGet]
        public IActionResult Options()
        {
            return View("Options");
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
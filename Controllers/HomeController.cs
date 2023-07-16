using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
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
            return View();
        }

        [HttpPost]
        public IActionResult Index(string city)
        {
            Deserializer deserializer = new Deserializer();

            return View(deserializer.Deserialize(city));
        }

        [HttpGet]
        public IActionResult About() => View();

        [HttpGet]
        public IActionResult DetailedWeather(int id, string city, string date)
        {
            ViewData["id"] = id;
            ViewData["date"] = DateHelper.GetDayOfWeek(date);

            Deserializer deserializer = new Deserializer();

            return View(deserializer.Deserialize(city));
        }

        public IActionResult Back() => RedirectToAction("Index");
    }
}
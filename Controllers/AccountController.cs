using Microsoft.AspNetCore.Mvc;
using WeatherApplication.Models;

namespace WeatherApplication.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register() => View();

        [HttpPost]
        public IActionResult Register(RegisterModel model) => View(model);

        [HttpGet]
        public IActionResult Login() => View();

        [HttpPost]
        public IActionResult Login(LoginModel model) => View(model);
    }
}

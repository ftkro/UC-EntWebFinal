using Microsoft.AspNetCore.Mvc;
using FinalProject.Models;

namespace FinalProject.Controllers
{
    public class HomeController : Controller
    {
        public HomeController() {
        }

        public ViewResult Index()
        {
            return View();
        }
    }
}

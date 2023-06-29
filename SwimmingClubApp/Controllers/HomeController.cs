 using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Models;
using System.Diagnostics;

namespace SwimmingClubApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Schedule()
        {
            return View();
        }

        public IActionResult More()
        {
            return View();
        }
      
        public IActionResult Error() => View();
    }
}
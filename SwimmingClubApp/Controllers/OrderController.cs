using Microsoft.AspNetCore.Mvc;

namespace SwimmingClubApp.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

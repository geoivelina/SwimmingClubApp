using Microsoft.AspNetCore.Mvc;

namespace SwimmingClubApp.Controllers
{
    public class ClubShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

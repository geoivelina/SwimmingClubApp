using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Controllers
{
    public class HomeController : Controller
    {
       
        public IActionResult Index()
        {
            if (this.User.IsInRole(AdminRoleName))
            {
                return RedirectToAction("Index", "Home", new { area = AreaName });
            }

            return View();
        }

        [Authorize]
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
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Newses;
using SwimmingClubApp.Services.Products;
using SwimmingClubApp.Services.Sponsors;

namespace SwimmingClubApp.Areas.Admin.Controllers
{
    public class HomeController : AdminController
    {
        private readonly ICoachService coaches;
        private readonly IProductService products;
        private readonly INewsService newses;
        private readonly ISponsorService sponsors;

        public HomeController(
                INewsService newses, 
                IProductService products, 
                ICoachService coaches, 
                ISponsorService sponsors)
        {
            this.newses = newses;
            this.products = products;
            this.coaches = coaches;
            this.sponsors = sponsors;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllSponsors() => View(this.sponsors.AllSponsors());
        public IActionResult AllCoaches() => View(this.coaches.AllCoaches());
    }
}

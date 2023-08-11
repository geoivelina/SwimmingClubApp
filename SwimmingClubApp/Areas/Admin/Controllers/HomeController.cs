using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Entries;
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
        private readonly IJoinusService entries;


        public HomeController(
                INewsService newses,
                IProductService products,
                ICoachService coaches,
                ISponsorService sponsors,
                IJoinusService entries)
        {
            this.newses = newses;
            this.products = products;
            this.coaches = coaches;
            this.sponsors = sponsors;
            this.entries = entries;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AllSponsors() => View(this.sponsors.AllSponsors());
        public IActionResult AllNews() => View(this.newses.AllNews());
        public IActionResult AllCoaches() => View(this.coaches.AllCoaches());
        public IActionResult AllProducts() => View(this.products.AllProducts().Products);

    }
}

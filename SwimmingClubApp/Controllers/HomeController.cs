using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models;
using SwimmingClubApp.Models.About;
using System.Diagnostics;

namespace SwimmingClubApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly SimmingClubDbContext data;

        public HomeController(SimmingClubDbContext data)
        {
            this.data = data;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult AddNews()
        {
            return View();

        }
        [HttpPost]
        public IActionResult AddNews(AddNewsFormModel news)
        {

            if (!ModelState.IsValid)
            {
                return View(news);

            }
            var model = new News
            {
                DateCreated = DateTime.Now,
                Desctioption = news.Desctioption,
                Image = news.Image,
                Title = news.Title

            };

            this.data.Newses.Add(model);
            this.data.SaveChanges();

            return RedirectToAction(nameof(Index));
        }


        public IActionResult LatestNews()
        {
            var newses = this.data
                .Newses
                .OrderBy(n => n.Id)
                .Select(n => new NewsViewModel()
                {
                    Title = n.Title,
                    DateCreated = n.DateCreated,
                    Desctioption = n.Desctioption
                })
                .Take(3)
                .ToList();
            return View(newses);
        }
        //public IActionResult Details()
        //{

        //}



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
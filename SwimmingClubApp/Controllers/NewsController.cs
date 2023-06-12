using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.News;

namespace SwimmingClubApp.Controllers
{
    public class NewsController : Controller
    {
        private readonly SimmingClubDbContext data;

        public NewsController(SimmingClubDbContext data)
        {
            this.data = data;
        }

        [Authorize]
        public IActionResult AddNews()
        {
            return View();

        }


        [HttpPost]
        [Authorize]
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


        public IActionResult All()
        {
            var news = this.data
                .Newses
                .OrderBy(n => n.Id)
                .Select(n => new NewsViewModel()
                {
                    Title = n.Title,
                    DateCreated = n.DateCreated,
                })
                .ToList();

            return View(news);
        }


        public IActionResult Details(int id)
        {
            var news = this.data
                .Newses
                .Where(n => n.Id == id)
                .Select(n => new NewsDetailsViewModel()
                {
                    Title = n.Title,
                    DateCreated = n.DateCreated,
                    Desctioption = n.Desctioption,
                    Image = n.Image
                })
                .FirstOrDefault();

            return View(news);
        }

        [Authorize]
        public IActionResult Edit(int id)
        {

            return View();
        }

        [Authorize]
        public IActionResult Delete(int id)
        {

            return View();
        }
    }
}

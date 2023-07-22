using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Models.News;
using SwimmingClubApp.Services.Newses;
using SwimmingClubApp.Services.Newses.Models;

using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Controllers
{
    //[Authorize(Roles = AdminRoleName)]
    public class NewsController : Controller
    {
        private readonly INewsService newses;

        public NewsController( INewsService newses)
        {
            this.newses = newses;
        }

        [HttpGet]
        public IActionResult AddNews()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddNews(NewsFormModel news)
        {
            if (!this.newses.NewsExists(news.Id))
            {
                this.ModelState.AddModelError(nameof(news.Id), "News does not exist");
            }

            if (!ModelState.IsValid)
            {
                return View(news);
            }

            this.newses.CreateNews(news.DateCreated, news.Desctioption, news.Image, news.Title);

            return RedirectToAction(nameof(All));
        }

        [AllowAnonymous]
        public IActionResult All()
        {
            var newses = this.newses.All();

            return View(newses);
        }

        [AllowAnonymous]
        public IActionResult Details(int id)
        {
            var news = this.newses.Details(id);

            return View(news);
        }


        [HttpGet]
        public IActionResult Edit(int id)
        {

            if (!this.newses.NewsExists(id))
            {
                return RedirectToAction(nameof(All));
            }

            var news = this.newses.Details(id);

            var editNews = new NewsDetailsServiceModel()
            {
               Image = news.Image,
               DateCreated = DateTime.UtcNow,
               Desctioption = news.Desctioption,
               Title = news.Title,
            };

            return View(editNews);
        }


        [HttpPost]
        public IActionResult Edit(NewsDetailsServiceModel news, int id)
        {
            if (!this.newses.NewsExists(id))
            {
                ModelState.AddModelError("", "News does not exist");

                return View(news);
            }


            if (!ModelState.IsValid)
            {
                return View(news);
            }

            this.newses.Edit(id, news);

            return RedirectToAction(nameof(All));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (!this.newses.NewsExists(id))
            {
                ModelState.AddModelError("", "News does not exist");

                return RedirectToAction(nameof(All));
            }

            var news = this.newses.Details(id);

            var toDelete = new NewsDetailsServiceModel
            {
                Title = news.Title,
                Desctioption = news.Desctioption,
                DateCreated = news.DateCreated,
                Image = news.Image,
                IsActive = news.IsActive
            };
            return View(toDelete);
        }

        [HttpPost]
        public IActionResult Delete(int id, NewsDetailsServiceModel news)
        {
            if (!this.newses.NewsExists(id))
            {
                ModelState.AddModelError("", "News does not exist");

                return RedirectToAction(nameof(All));
            }

            this.newses.Delete(id);

            return RedirectToAction(nameof(All));
        }
    }
}

﻿using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Newses.Models;

namespace SwimmingClubApp.Services.Newses
{
    public class NewsService : INewsService
    {
        private readonly SimmingClubDbContext data;

        public NewsService(SimmingClubDbContext data)
        {
            this.data = data;
        }

        public int CreateNews(DateTime dateCreated, string desctioption, string image, string title)
        {
            var news = new News
            {
                DateCreated = DateTime.Now,
                Desctioption = desctioption,
                Image = image,
                Title = title
            };

            this.data.Newses.Add(news);
            this.data.SaveChanges();

            return news.Id;
        }
        public void Edit(int id, NewsDetailsServiceModel news)
        {
            var toEdit = this.data.Newses.Find(id);

            toEdit.Title = news.Title;
            toEdit.DateCreated = DateTime.UtcNow;
            toEdit.Image = news.Image;
            toEdit.Desctioption = news.Desctioption;

            this.data.SaveChanges();
        }

        public void Delete(int id)
        {
            var toDelete = this.data.Newses.Find(id);
            toDelete.IsAvtive = false;

            this.data.SaveChanges();
        }
        public NewsDetailsServiceModel Details(int id)
        {
            return this.data
                .Newses
                .Where(n => n.Id == id && n.IsAvtive)
                .Select(n => new NewsDetailsServiceModel()
                {
                    Title = n.Title,
                    DateCreated = n.DateCreated,
                    Desctioption = n.Desctioption,
                    Image = n.Image
                })
                .FirstOrDefault();
        }

        public bool NewsExists(int newsId)
        {
            return this.data.Newses.Any(c => c.Id == newsId);
        }
        public IEnumerable<NewsServiceModel> All()
        {
            return this.data
                .Newses
                .Where(n => n.IsAvtive)
                .Select(n => new NewsServiceModel
                {
                    Id = n.Id,
                    DateCreated = n.DateCreated,
                    Image = n.Image,
                    Title = n.Title
                })
                .ToList();
        }
    }
}

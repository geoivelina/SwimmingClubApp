using AutoMapper;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Newses.Models;

namespace SwimmingClubApp.Services.Newses
{
    public class NewsService : INewsService
    {
        private readonly SwimmingClubDbContext data;
        private readonly IMapper mapper;

        public NewsService(SwimmingClubDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
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
        public void EditNews(int id, NewsDetailsServiceModel news)
        {
            var toEdit = this.data.Newses.Find(id);

            toEdit.Title = news.Title;
            toEdit.DateCreated = DateTime.UtcNow;
            toEdit.Image = news.Image;
            toEdit.Desctioption = news.Desctioption;

            this.data.SaveChanges();
        }
        public void DeleteNews(int id)
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
               .To<NewsDetailsServiceModel>()
                .FirstOrDefault();
        }
        public bool NewsExists(int newsId)
        {
            return this.data.Newses.Any(c => c.Id == newsId);
        }
        public IEnumerable<NewsServiceModel> AllNews()
        {
            return this.data
                .Newses
                .Where(n => n.IsAvtive)
                .To<NewsServiceModel>()
                .ToList();
        }
    }
}

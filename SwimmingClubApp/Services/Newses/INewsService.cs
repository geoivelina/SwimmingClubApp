using SwimmingClubApp.Services.Newses.Models;

namespace SwimmingClubApp.Services.Newses
{
    public interface INewsService
    {
        bool NewsExists(int coachId);
        int CreateNews(DateTime dateCreated, string desctioption, string image, string title);
        IEnumerable<NewsServiceModel> All();
        NewsDetailsServiceModel Details(int id);
        void Edit(int id, NewsDetailsServiceModel news);
        void Delete(int id);
    }
}

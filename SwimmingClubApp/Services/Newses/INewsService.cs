using SwimmingClubApp.Services.Newses.Models;

namespace SwimmingClubApp.Services.Newses
{
    public interface INewsService
    {
        bool NewsExists(int coachId);
        int CreateNews(DateTime dateCreated, string desctioption, string image, string title);
        IEnumerable<NewsServiceModel> AllNews();
        NewsDetailsServiceModel Details(int id);
        void EditNews(int id, NewsDetailsServiceModel news);
        void DeleteNews(int id);
    }
}

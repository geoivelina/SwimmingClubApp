using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Tests.Data
{
    public static class Newses
    {
        public static IEnumerable<News> NewsData()
        {
            var news = new List<News>()
        {
            new News()
            {
                Id = 1,
                DateCreated = DateTime.UtcNow,
                Desctioption = "Some very long news here",
                Image = "http://someimg.com",
                Title = "Very fancy tatle"
            },
            new News()
            {
                Id = 2,
                DateCreated = DateTime.UtcNow,
                Desctioption = "Some very long news here2",
                Image = "http://someimg2.com",
                Title = "Very fancy tatle2"
            }
        };
            return news;
        }
    }
}

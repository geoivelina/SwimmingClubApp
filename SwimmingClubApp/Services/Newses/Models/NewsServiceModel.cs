using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Newses.Models
{
    public class NewsServiceModel: IMapFrom<News>, IMapTo<News>
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public DateTime DateCreated { get; set; }

        public string Image { get; set; } = null!;

    }
}

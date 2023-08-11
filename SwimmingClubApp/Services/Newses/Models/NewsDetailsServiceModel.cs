using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Newses.Models
{
    public class NewsDetailsServiceModel : NewsServiceModel, IMapFrom<News>, IMapTo<News>
    {
        public string Desctioption { get; set; } = null!;
        public bool IsActive { get; set; }

    }
}

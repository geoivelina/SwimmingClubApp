using SwimmingClubApp.Models.News;

namespace SwimmingClubApp.Services.Newses.Models
{
    public class NewsDetailsServiceModel : NewsServiceModel
    {
        public string Desctioption { get; set; } = null!;
        public bool IsActive { get; set; }

    }
}

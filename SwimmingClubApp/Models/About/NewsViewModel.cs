using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Models.About
{
    public class NewsViewModel
    {
      
        public string Title { get; set; } = null!;

        public DateTime DateCreated { get; set; }

        public string Image { get; set; } = null!;

        public string Desctioption { get; set; } = null!;
       
    }
}

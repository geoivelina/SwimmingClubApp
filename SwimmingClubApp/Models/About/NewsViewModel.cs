namespace SwimmingClubApp.Models.About
{
    public class NewsViewModel
    {
      
        public string Title { get; set; }

        public DateTime DateCreated { get; set; }

        public string Image { get; set; }

        public string Desctioption { get; set; } = null!;
    }
}

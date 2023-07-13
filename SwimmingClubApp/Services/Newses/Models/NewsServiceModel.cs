namespace SwimmingClubApp.Services.Newses.Models
{
    public class NewsServiceModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public DateTime DateCreated { get; set; }

        public string Image { get; set; } = null!;

    }
}

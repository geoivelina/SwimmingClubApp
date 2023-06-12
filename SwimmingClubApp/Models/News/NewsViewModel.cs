namespace SwimmingClubApp.Models.News
{
    public class NewsViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;

        public DateTime DateCreated { get; set; }

        public string Image { get; set; } = null!;

    }
}

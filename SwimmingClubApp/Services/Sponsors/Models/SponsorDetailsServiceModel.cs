namespace SwimmingClubApp.Services.Sponsors.Models
{
    public class SponsorDetailsServiceModel : SponsorServiceModel
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsActive { get; set; }
    }
}

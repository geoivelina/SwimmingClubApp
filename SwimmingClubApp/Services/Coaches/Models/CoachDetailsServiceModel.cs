namespace SwimmingClubApp.Services.Coaches.Models
{
    public class CoachDetailsServiceModel : CoachServiceModel
    {
        public int Id { get; set; }
        public bool IsActive { get; set; }
    }
}

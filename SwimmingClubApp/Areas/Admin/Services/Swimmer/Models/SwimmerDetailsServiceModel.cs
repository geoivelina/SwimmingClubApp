namespace SwimmingClubApp.Areas.Admin.Services.Swimmer.Models
{
    public class SwimmerDetailsServiceModel
    {
        public int Id { get; set; }
        public string FullName { get; set; } = null!;
        public int Age { get; set; }
        public string ContactPersonName { get; set; } = null!;
        public string RelationshipToSwimmer { get; set; } = null!;
        public string PhoneNumber { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string Address { get; set; } = null!;
        public string MedicalDatails { get; set; }
        public string SwimmingExperience { get; set; } = null!;
        public int SquadId { get; set; }

        public string SquadName { get; set; }
        public bool IsApproved { get; set; }
    }
}

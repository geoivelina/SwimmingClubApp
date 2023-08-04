using SwimmingClubApp.Services.Entries.Models;
using System.ComponentModel.DataAnnotations;

namespace SwimmingClubApp.Areas.Admin.Services.Swimmer.Models
{
    public class SwimmerEntryServiceModel
    {
        public int Id { get; set; }

        [Display(Name = "Full Name")]
        public string FullName { get; set; } = null!;
        public int Age { get; set; }

        [Display(Name = "Contact Person Name")]
        public string ContactPersonName { get; set; } = null!;

        [Display(Name = "Relationship To Swimmer")]
        public string RelationshipToSwimmer { get; set; } = null!;

        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        public string Email { get; set; } = null!;

        [Display(Name = "Confirm Email")]
        public string ConfirmEmail { get; set; } = null!;
        public string Address { get; set; } = null!;


        [Display(Name = "Important Medical Information")]
        public string MedicalDatails { get; set; }

        [Display(Name = "Swimming Experince")]
        public string SwimmingExperience { get; set; } = null!;

        [Display(Name = "Squad")]
        public int SquadId { get; set; }

        public IEnumerable<SwimmerSquadServiceModel> Squads { get; set; } = new List<SwimmerSquadServiceModel>();
    }
}

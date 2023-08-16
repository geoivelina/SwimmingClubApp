using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Swimmer;


namespace SwimmingClubApp.Data.Models
{
    public class Swimmer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(FullNameMaxLength)]
        public string FullName { get; set; } = null!;

        [Required]
        [Range(MinAge, MaxAge)]
        public int Age { get; set; }


        [MaxLength(ContactPersonNameMaxLength)]
        public string ContactPersonName { get; set; } = null!;


        [MaxLength(ContactPersonNameMaxLength)]
        public string RelationshipToSwimmer { get; set; } = null!;

        [Required]
        public string PhoneNumber { get; set; } = null!;


        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        public string MedicalDatails { get; set; }

        [Required]
        [MaxLength(SwimmingExperienceMaxLength)]
        public string SwimmingExperience { get; set; } = null!;

        [Required]
        public int SquadId { get; set; }
        public Squad Squad { get; set; }

        public bool IsApproved { get; set; }
        public bool IsActive { get; set; }

    }
}

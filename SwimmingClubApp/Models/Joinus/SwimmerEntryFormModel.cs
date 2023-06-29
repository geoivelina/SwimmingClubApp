using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Swimmer;

namespace SwimmingClubApp.Models.Joinus
{
    public class SwimmerEntryFormModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        [StringLength(FullNameMaxLength, MinimumLength = FullNameMinLength, ErrorMessage = "The Full Name feild must be between {2} and {1} symbols")]
        public string FullName { get; set; } = null!;

        [Required]
        [Range(MinAge, MaxAge, ErrorMessage = "The age of the participant must be between {1} and {2} years old")]
        public int Age { get; set; }

              
        [Display(Name ="Contact Person Name")]
        [StringLength(ContactPersonNameMaxLength, MinimumLength = ContactPersonNameMinLength, ErrorMessage = "The Contact Person feild must be between {2} and {1} symbols")]
        //allows null, will be used only if the swimmer is under 18yo
        public string ContactPersonName { get; set; }
              
        [Display(Name ="Relationship To Swimmer")]
        [StringLength(ContactPersonNameMaxLength, MinimumLength =RelationshipToSwimmerMinLength, ErrorMessage = "The Relationship  feild must be between {2} and {1} symbols")]
        //allows null, will be used only if the swimmer is under 18yo
        public string RelationshipToSwimmer { get; set; }

        [Required]
        [Phone]
        [Display(Name = "Phone Number")]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [EmailAddress]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength, ErrorMessage = "Please, provide a valid email address.")]
        public string Email { get; set; } = null!;


        [Required]
        [EmailAddress]
        [Display(Name = "Confirm Email")]
        [Compare(nameof(Email), ErrorMessage = "Email does not match.")]
        [StringLength(EmailMaxLength, MinimumLength = EmailMinLength)]
        public string ConfirmEmail { get; set; } = null!;

        [Required]
        [StringLength(AddressMaxLength, MinimumLength = AddressMinLength)]
        public string Address { get; set; } = null!;


        [Display(Name = "Important Medical Information")]
        [StringLength(MedicalDetalsMaxLength, MinimumLength = MedicalDetalsMinLength, ErrorMessage = "The Medical Details feild must be between {2} and {1} symbols")]

        public string MedicalDatails { get; set; }

        [Required]
        [Display(Name = "Swimming Experince")]
        [StringLength(SwimmingExperienceMaxLength, MinimumLength = SwimmingExperienceMinLength, ErrorMessage = "The Swimming Experience feild must be between {2} and {1} symbols")]
        public string SwimmingExperience { get; set; } = null!;

        [Display(Name = "Squad")]
        public int SquadId { get; set; }

        public IEnumerable<SwimmerSquadModel> Squads { get; set; } = new List<SwimmerSquadModel>();
    }
}

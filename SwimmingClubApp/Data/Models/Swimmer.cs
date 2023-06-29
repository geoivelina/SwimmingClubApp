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
        //allows null, will be used only if the swimmer is under 18yo
        public string ContactPersonName { get; set; }

       
        [MaxLength(ContactPersonNameMaxLength)]
        //allows null, will be used only if the swimmer is under 18yo
        public string RelationshipToSwimmer { get; set; }

        [Required]
        [MaxLength(AddressMaxLength)]
        public string Address { get; set; } = null!;

        public string MedicalDatails { get; set; }

        [Required]
        [MaxLength(SwimmingExperienceMaxLength)]
        public string SwimmingExperience { get; set; } = null!;

        [Required]
        public int SquadId { get; set; }

        [Required]
        public int UserId { get; set; }
        public bool IsApproved { get; set; }
    }
}

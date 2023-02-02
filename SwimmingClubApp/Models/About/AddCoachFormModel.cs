using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.Coach;

namespace SwimmingClubApp.Models.About
{
    public class AddCoachFormModel
    {
        [Required]
        [StringLength(FullNameMaxLength, MinimumLength = FullNameMinLength, ErrorMessage = "The Full Name feild must be between {2} and {1} symbols")]
        [Display(Name = "Full Name")]
        public string FullName { get; set; } = null!;

        [Required]
        [Display(Name = "Image URL")]
        [Url]
        /*
         * TODO Change it to file upload into the View. LOok for references in ASP-NET-Core-Working-with-Data 2020-21 pages 22-23
         * 
         <form method="post" enctype="multipart/form-data" asp-controller="Files" asp-action="Upload">
         <input type = "file" name="file">
        <button type = "submit" value="Upload" />
        </form> 
        */

        public string Image { get; set; } = null!;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = null!;

        [Required]
        [StringLength(JobPOsiotionMaxLength, MinimumLength = JobPOsiotionMinLength, ErrorMessage = "The Job Position feild must be between {2} and {1} symbols")]
        [Display(Name = "Job Position")]
        public string JobPosition { get; set; } = null!;

        [Display(Name = "Squad")]
        public int SquadId { get; set; }

        public IEnumerable<CoachSquadViewModel> Squads { get; set; } = new List<CoachSquadViewModel>();

    }
}

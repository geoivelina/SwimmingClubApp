using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.News;

namespace SwimmingClubApp.Data.Models
{
    public class News
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(TitleMaxLenth)]
        public string Title { get; set; } = null!;

        [Required]
        public DateTime DateCreated { get; set; }

        [Required]
        public string Image { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLenth)]
        public string Desctioption { get; set; } = null!;
    }
}

using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.User;

namespace SwimmingClubApp.Data.Models
{
    public class User : IdentityUser
    {
      
        [MaxLength(FullNameMaxLenth)]
        public string UserFullName { get; set; } = null!;
    }
}

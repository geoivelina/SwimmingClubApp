using Microsoft.AspNetCore.Identity;
using SwimmingClubApp.Services.Data.Models;
using System.ComponentModel.DataAnnotations;
using static SwimmingClubApp.Data.DataConstants.User;

namespace SwimmingClubApp.Data.Models
{
    public class User : IdentityUser
    {

        [MaxLength(UserFullNameMaxLenth)]
        public string UserFullName { get; set; } = null!;
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}

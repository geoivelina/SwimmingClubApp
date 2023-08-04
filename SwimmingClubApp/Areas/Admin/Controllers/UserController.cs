using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Areas.Admin.Models.User;
using SwimmingClubApp.Data;

namespace SwimmingClubApp.Areas.Admin.Controllers
{
    public class UserController : AdminController
    {
        private readonly SwimmingClubDbContext data;

        public UserController(SwimmingClubDbContext data)
        {
            this.data = data;
        }

        public IEnumerable<UserDetailsViewModel> AllUsers()
        {
            var users = this.data.Users.Select(u => new UserDetailsViewModel
            {
                 Id = u.Id,
                 UserFullName = u.UserName,
                 Email = u.Email
            }).ToList();

            return users;
        }
    }
}

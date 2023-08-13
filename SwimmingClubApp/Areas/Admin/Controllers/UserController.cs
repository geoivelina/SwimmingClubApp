using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Areas.Admin.Models.User;
using SwimmingClubApp.Services.Users;

namespace SwimmingClubApp.Areas.Admin.Controllers
{
    public class UserController : AdminController
    {
        private readonly IUserService users;

        public UserController(IUserService users)
        {
            this.users = users;
        }

        public IActionResult AllUsers()=> View(this.users.AllUsers());
        
    }
}

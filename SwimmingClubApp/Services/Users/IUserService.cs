using SwimmingClubApp.Areas.Admin.Models.User;

namespace SwimmingClubApp.Services.Users
{
    public interface IUserService
    {
        string UserFullName(string userId);
        IEnumerable<UserDetailsViewModel> AllUsers();
    }
}

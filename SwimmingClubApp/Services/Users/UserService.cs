using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Users
{
    public class UserService : IUserService, IMapFrom<User>
    {
        private readonly SwimmingClubDbContext data;

        public UserService(SwimmingClubDbContext data)
        {
            this.data = data;
        }

        public string UserFullName(string userId)
        {
            var user = this.data.Users.Find(userId);

            if (string.IsNullOrEmpty(user.UserFullName))
            {
                return null;
            }

            return user.UserFullName;
        }
    }
}

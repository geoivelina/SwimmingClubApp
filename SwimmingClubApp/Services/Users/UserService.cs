using SwimmingClubApp.Data;

namespace SwimmingClubApp.Services.Users
{
    public class UserService : IUserService
    {
        private readonly SimmingClubDbContext data;

        public UserService(SimmingClubDbContext data)
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

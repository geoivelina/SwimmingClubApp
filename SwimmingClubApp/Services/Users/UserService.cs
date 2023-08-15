using AutoMapper;
using AutoMapper.QueryableExtensions;
using SwimmingClubApp.Areas.Admin.Models.User;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Services.Users
{
    public class UserService : IUserService
    {
        private readonly SwimmingClubDbContext data;
        private readonly IMapper mapper;

        public UserService(SwimmingClubDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }


        public string UserFullName(string userId)
        {
            var user = this.data.Users.Find(userId);
            
            if (user == null)
            {
                throw new NullReferenceException("User does not exsist.");
            }

            if (string.IsNullOrEmpty(user.UserFullName))
            {
                throw new NullReferenceException("UserFullName does not exsist.");
            }

            return user.UserFullName;
        }

        public IEnumerable<UserDetailsViewModel> AllUsers()
        {
            return this.data.Users
                .ProjectTo<UserDetailsViewModel>(this.mapper.ConfigurationProvider)
                .ToList();
        }
    }
}

using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Tests.Data
{
    public static class Users
    {
        public static IEnumerable<User> UsersData()
           => new List<User>
                {
                    new User
                    {
                        Id ="c9aa458e-5fd0-48a2-b64d-7a31c8f7c65e",
                        UserFullName = "Test Test1",
                        Email = "test1@mail.com"
                    },
                    new User
                    {
                        Id = "359b285d-706d-4144-bb31-18e48e79addd",
                        UserFullName = "Test Test2",
                        Email = "test2@mail.com"
                    }
                };
    }
}

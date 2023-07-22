using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure
{
    public class UsersConfiguration : IEntityTypeConfiguration<User>
    {
        private User GeustUser { get; set; } = null!;
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasData(CreateUsers());
        }
        private User CreateUsers()
        {
            var hasher = new PasswordHasher<User>();

           this.GeustUser = new User()
            {
                Id = "a8cf3ed6-7921-4e33-8da6-7ebb70d5f4c3",
                Email = "guest@mail.com",
                NormalizedEmail = "GUEST@MAIL.COM",
                UserName = "guest@mail.com",
                NormalizedUserName = "GUEST@MAIL.COM",
                UserFullName = "Guest User"
            };

            this.GeustUser.PasswordHash = hasher.HashPassword(this.GeustUser, "guest123");
            return this.GeustUser;
        }
    }
}

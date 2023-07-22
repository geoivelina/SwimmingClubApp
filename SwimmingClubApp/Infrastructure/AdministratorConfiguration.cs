using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Infrastructure
{

    internal class AdministratorConfiguration : IEntityTypeConfiguration<User>
    {
        private User AdminUser { get; set; } = null!;

        public void Configure(EntityTypeBuilder<User> builder)
        {
          builder.HasData(CreateAdministrator());
        }

        private User CreateAdministrator()
        {
            var hasher = new PasswordHasher<User>();

            this.AdminUser = new User()
            {
                Id = "a1259a89-da2c-413d-94b9-fa5860faa017",
                Email = AdminEmail,
                NormalizedEmail = NormalizedAdminEmail,
                UserName = AdminEmail,
                NormalizedUserName = NormalizedAdminEmail,
                UserFullName = "Admin"
            };

            this.AdminUser.PasswordHash = hasher.HashPassword(this.AdminUser, "admin123");

            return this.AdminUser;
        }
    }
}
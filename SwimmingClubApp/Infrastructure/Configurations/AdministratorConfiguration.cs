using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;
using static SwimmingClubApp.Data.DataConstants.AdminConstants;

namespace SwimmingClubApp.Infrastructure.Configurations
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

            AdminUser = new User()
            {
                Id = "a1259a89-da2c-413d-94b9-fa5860faa017",
                Email = AdminEmail,
                NormalizedEmail = NormalizedAdminEmail,
                UserName = AdminEmail,
                NormalizedUserName = NormalizedAdminEmail,
                UserFullName = "Admin"
            };

            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "admin123");

            return AdminUser;
        }
    }
}
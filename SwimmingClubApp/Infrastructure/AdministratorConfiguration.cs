using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure
{

    internal class AdministratorConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
           // CreateAdministrator();
        }

        private static void CreateAdministrator(IServiceProvider services)
        {
            //var userManager = services.GetRequiredService<UserManager<User>>();
            //var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            //Task.Run(async () =>
            //{
            //    if (await roleManager.RoleExistsAsync(AdministratorRoleName))
            //    {
            //        return;
            //    }
            //    var role = new IdentityRole { Name = AdministratorRoleName };

            //    await roleManager.CreateAsync(role);

            //    const string adminEmail = "admin@mail.com";
            //    const string adminPassword = "admin123";

            //    var user = new User
            //    {
            //        Email = adminEmail,
            //        UserName = adminEmail,
            //        FullName = "Admin"
            //    };

            //    await userManager.CreateAsync(user, adminPassword);

            //    await userManager.AddToRoleAsync(user, role.Name);
            //})
            //    .GetAwaiter()
            //    .GetResult();
        }
    }
}
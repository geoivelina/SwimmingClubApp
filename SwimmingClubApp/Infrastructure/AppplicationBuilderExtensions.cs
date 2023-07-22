using Microsoft.AspNetCore.Identity;
using SwimmingClubApp.Data.Models;

using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Infrastructure
{
    public static class AppplicationBuilderExtensions
    {
        public static IApplicationBuilder SeedAdmin(this IApplicationBuilder app)
        {
            using var scoopedServices = app.ApplicationServices.CreateScope();

            var services = scoopedServices.ServiceProvider;

            var userManager = services.GetRequiredService<UserManager<User>>();
            var roleManager = services.GetRequiredService<RoleManager<IdentityRole>>();

            Task.Run(async () =>
            {
                if (await roleManager.RoleExistsAsync(AdminRoleName))
                {
                    return;
                }

                var role = new IdentityRole { Name = AdminRoleName };
                await roleManager.CreateAsync(role);

                var admin = await userManager.FindByNameAsync(AdminEmail);

                await userManager.AddToRoleAsync(admin, role.Name);
            })
                .GetAwaiter()
                .GetResult();

            return app;
        }
    }
}

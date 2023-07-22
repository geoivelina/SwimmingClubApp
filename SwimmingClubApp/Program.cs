using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Entries;
using SwimmingClubApp.Services.Newses;
using SwimmingClubApp.Services.Products;
using SwimmingClubApp.Services.Sponsors;
using SwimmingClubApp.Services.Users;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<SimmingClubDbContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

builder.Services.AddDefaultIdentity<User>(options =>
{
    options.Password.RequireDigit = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequireUppercase = false;
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<SimmingClubDbContext>();

//builder.Services.ConfigureApplicationCookie(options =>
//{
//    options.AccessDeniedPath = "";
//    options.LoginPath = "";
//    options.LogoutPath = "";
//});

builder.Services.AddControllersWithViews()
    .AddMvcOptions(options =>
    {
        options.Filters.Add<AutoValidateAntiforgeryTokenAttribute>();
    });

builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<ICoachService, CoachService>();
builder.Services.AddTransient<ISponsorService, SponsorService>();
builder.Services.AddTransient<INewsService, NewsService>();
builder.Services.AddTransient<IUserService, UserService>();
builder.Services.AddTransient<IJoinusService, JoinusService>();

//builder.Services.AddAutoMapper(typeof(IProductService).Assembly, typeof(ClubShopController).Assembly);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseMigrationsEndPoint();
}
else
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.SeedAdmin();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();
app.UseAuthorization();



app.UseEndpoints(endpoints =>
{
    endpoints.MapControllerRoute(
      name: "Areas",
      pattern: "{area:exists}/{controller=Home}/{action=Index}/{id?}"
    );

    endpoints.MapDefaultControllerRoute();
    endpoints.MapRazorPages();
});

app.Run();

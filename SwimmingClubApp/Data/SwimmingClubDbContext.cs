using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure.Configurations;
using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Data
{
    public class SwimmingClubDbContext : IdentityDbContext<User, IdentityRole, string>
    {
        public SwimmingClubDbContext(DbContextOptions<SwimmingClubDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new CoachesConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
            builder.ApplyConfiguration(new ProductCategoriesConfiguration());
            builder.ApplyConfiguration(new ProductsConfiguration());
            builder.ApplyConfiguration(new SizeOptionConfiguration());
            builder.ApplyConfiguration(new SponsorsConfiguration());
            builder.ApplyConfiguration(new SquadsConfiguration());
            builder.ApplyConfiguration(new AdministratorConfiguration());
            builder.ApplyConfiguration(new UsersConfiguration());
            builder.ApplyConfiguration(new SwimmersConfiguration());
            builder.ApplyConfiguration(new OrderStatusConfiguration());



            base.OnModelCreating(builder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
            base.OnConfiguring(optionsBuilder);
        }
        public DbSet<Coach> Coaches { get; set; } = null!;
        public DbSet<News> Newses { get; set; } = null!;
        public DbSet<Product> Products { get; set; } = null!;
        public DbSet<ProductCategory> ProductCategories { get; set; } = null!;
        public DbSet<SizeOption> SizeOptions { get; set; } = null!;
        public DbSet<Sponsor> Sponsors { get; set; } = null!;
        public DbSet<Squad> Squads { get; set; } = null!;
        public DbSet<Swimmer> Swimmers { get; set; } = null!;
        public DbSet<Order> Orders { get; set; } = null!;
        public DbSet<OrderStatus> OrderStatuses { get; set; } = null!;
        public DbSet<Invoice> Invoices { get; set; } = null!;

    }

}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure;

namespace SwimmingClubApp.Data
{
    public class SimmingClubDbContext : IdentityDbContext<User>
    {
        public SimmingClubDbContext(DbContextOptions<SimmingClubDbContext> options)
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
       // public DbSet<ProductSize> ProductSizes { get; set; } = null!;
        public DbSet<SizeOption> SizeOptions { get; set; } = null!;
        public DbSet<Sponsor> Sponsors { get; set; } = null!;
        public DbSet<Squad> Squads { get; set; } = null!;
        public DbSet<Swimmer> Swimmers { get; set; } = null!;



    }

}
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Infrastructure;

namespace SwimmingClubApp.Data
{
    public class SimmingClubDbContext : IdentityDbContext
    {
        public SimmingClubDbContext(DbContextOptions<SimmingClubDbContext> options)
            : base(options)
        {
        }

       

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SquadsConfiguration());
            builder.ApplyConfiguration(new CoachesConfiguration());
            builder.ApplyConfiguration(new NewsConfiguration());
           // builder.ApplyConfiguration(new ShopConfiguration());
            builder.ApplyConfiguration(new SponsorsConfiguration());


            base.OnModelCreating(builder);
        }
        public DbSet<Coach> Coaches { get; set; } = null!;
        public DbSet<Squad> Squads { get; set; } = null!;
        public DbSet<News> Newses { get; set; } = null!;
        public DbSet<Sponsor> Sponsors { get; set; } = null!;
    }
}
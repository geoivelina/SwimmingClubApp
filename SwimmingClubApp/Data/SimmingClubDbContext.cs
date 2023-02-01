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

        public DbSet<Coach> Coaches { get; set; } = null!;
        public DbSet<Squad> Squads { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new SquadsConfiguration());


            base.OnModelCreating(builder);
        }
    }
}
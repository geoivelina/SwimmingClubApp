using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Data
{
    public class SimmingClubDbContext : IdentityDbContext
    {
        public SimmingClubDbContext(DbContextOptions<SimmingClubDbContext> options)
            : base(options)
        {
        }

        public DbSet<Coach> Coaches { get; set; } = null!;


    }
}
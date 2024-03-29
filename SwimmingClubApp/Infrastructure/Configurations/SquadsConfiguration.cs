﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure.Configurations
{
    internal class SquadsConfiguration : IEntityTypeConfiguration<Squad>
    {
        public void Configure(EntityTypeBuilder<Squad> builder)
        {
            builder.HasData(CreateSquads());
        }
        private List<Squad> CreateSquads()
        {
            List<Squad> squads = new List<Squad>()
            {
                new Squad()
                {
                    Id= 1,
                    SquadName = "Beginner"
                },
                 new Squad()
                {
                    Id= 2,
                    SquadName = "Professional"
                },
                  new Squad()
                {
                    Id= 3,
                    SquadName = "Fithness"
                }
            };
            return squads;
        }
    }
}

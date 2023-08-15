using SwimmingClubApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwimmingClubApp.Tests.Data
{
    public static class Squads
    {
        public static IEnumerable<Squad> SquadsData()
        {
            var squads = new List<Squad>()
            {
               
                new Squad()
                {
                    Id= 1,
                    SquadName = "Some"
                },
                 new Squad()
                {
                    Id= 2,
                    SquadName = "Some1"
                },
                  new Squad()
                {
                    Id= 3,
                    SquadName = "Some2"
                }
            };
            return squads;
        }
    }
}

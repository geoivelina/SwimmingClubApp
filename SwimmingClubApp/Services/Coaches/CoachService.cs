﻿using AutoMapper;
using AutoMapper.QueryableExtensions;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Services.Coaches.Models;
using SwimmingClubApp.Services.Data.Models;

namespace SwimmingClubApp.Services.Coaches
{
    public class CoachService : ICoachService
    {

        private readonly SwimmingClubDbContext data;
        private readonly IMapper mapper;

        public CoachService(SwimmingClubDbContext data, IMapper mapper)
        {
            this.data = data;
            this.mapper = mapper;
        }

        public IEnumerable<CoachListingServiceModel> AllCoaches()
        {
            return this.data
                  .Coaches
                  .Where(c => c.IsAvtive)
                  //.ProjectTo<CoachListingServiceModel>(this.mapper.ConfigurationProvider)
                  .Select(c => new CoachListingServiceModel
                  {
                      Id = c.Id,
                      FullName = c.FullName,
                      Email = c.Email,
                      Image = c.Image,
                      Squad = c.Squad.SquadName,
                      JobPosition = c.JobPosition,
                      IsAvtive = c.IsAvtive
                  })
                  .ToList();
        }

        public CoachDetailsServiceModel CoachDetails(int coachId)
        {
            return this.data.Coaches
                 .Where(c => c.Id == coachId && c.IsAvtive)
                 .Select(c => new CoachDetailsServiceModel
                 {
                     Image = c.Image,
                     Email = c.Email,
                     FullName = c.FullName,
                     JobPosition = c.JobPosition,
                     SquadId = c.SquadId,
                     IsActive = c.IsAvtive
                 })
                 .FirstOrDefault();
        }

        public bool CoachExists(int coachId)
        {
            return this.data.Coaches.Any(c => c.Id == coachId && c.IsAvtive);
        }

        public int CreateCoach(string fullName, string image, string email, int squadId, string jobPosition)
        {
            var newCoach = new Coach
            {
                FullName = fullName,
                Image = image,
                Email = email,
                SquadId = squadId,
                JobPosition = jobPosition,
                IsAvtive = true,
            };

            this.data.Coaches.Add(newCoach);
            this.data.SaveChanges();

            return newCoach.Id;
        }

        public void Edit(int id, CoachFormModel coach)
        {
            var toEdit = this.data.Coaches.Find(id);

            toEdit.FullName = coach.FullName;
            toEdit.Email = coach.Email;
            toEdit.Image = coach.Image;
            toEdit.JobPosition = coach.JobPosition;
            toEdit.SquadId = coach.SquadId;

            this.data.SaveChanges();
        }
        public void Delete(int id)
        {
            var toDelete = this.data.Coaches.Find(id);
            toDelete.IsAvtive = false;

            this.data.SaveChanges();
        }

        public bool SquadExists(int squadId)
        {
            return this.data.Squads.Any(s => s.Id == squadId);
        }
        public IEnumerable<CoachSquadServiceModel> AllSquads()
        {
            return this.data
                  .Squads
                  .Select(s => new CoachSquadServiceModel
                  {
                      Id = s.Id,
                      SquadName = s.SquadName
                  })
                  .ToList();
        }
    }
}

﻿using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.About;

namespace SwimmingClubApp.Controllers
{
    public class AboutController : Controller
    {
        private readonly SimmingClubDbContext data;

        public AboutController(SimmingClubDbContext data)
        {
            this.data = data;
        }

        public IActionResult History()
        {
            return View();
        }

        public IActionResult AddCoach()
        {
            return View(new AddCoachFormModel
            {
                Squads = this.GetSquads()
            });

        }
        [HttpPost]
        public IActionResult AddCoach(AddCoachFormModel coach)
        {
            if (!this.data.Squads.Any(s => s.Id == coach.SquadId))
            {
                this.ModelState.AddModelError(nameof(coach.SquadId), "Squad does not exist");
            }
            if (!ModelState.IsValid)
            {
                coach.Squads = this.GetSquads();
                return View(coach);

            }
            var newCoach = new Coach
            {
                FullName = coach.FullName,
                Image = coach.Image,
                Email = coach.Email,
                SquadId = coach.SquadId
            };

            this.data.Coaches.Add(newCoach);
            this.data.SaveChanges();

            return RedirectToAction("Index", "Home");
        }
        private IEnumerable<CoachSquadViewModel> GetSquads()
        {
            return this.data
                .Squads
                .Select(s => new CoachSquadViewModel
                {
                    Id = s.Id,
                    SquadName = s.SquadName
                })
                .ToList();
        }

    }
}

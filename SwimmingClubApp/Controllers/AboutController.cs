using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.About;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Sponsors;

namespace SwimmingClubApp.Controllers
{
    public class AboutController : Controller
    {
        private readonly ICoachService coaches;
        private readonly ISponsorService sponsors;

        public AboutController(ICoachService coaches, ISponsorService sponsors)
        {
            this.coaches = coaches;
            this.sponsors = sponsors;
        }

        public IActionResult History()
        {
            return View();
        }



        public IActionResult Fundrising()
        {
            return View();
        }


        public IActionResult AddCoach()
        {
            return View(new CoachFormModel
            {
                Squads = this.coaches.AllSquads()
            });

        }


        [HttpPost]
        public IActionResult AddCoach(CoachFormModel coach)
        {
            if (!this.coaches.SquadExists(coach.SquadId))
            {
                this.ModelState.AddModelError(nameof(coach.SquadId), "Squad does not exist");
            }
            if (!ModelState.IsValid)
            {
                coach.Squads = this.coaches.AllSquads();
                return View(coach);

            }

            this.coaches.CreateCoach(coach.FullName, coach.Image, coach.Email, coach.SquadId, coach.JobPosition);

            return RedirectToAction(nameof(AllCoaches));
        }

        [HttpGet]
        public IActionResult EditCoach(int id)
        {
            if (!this.coaches.CoachExists(id))
            {
                return RedirectToAction(nameof(AllCoaches));
            }

            var coach = this.coaches.CoachDetails(id);

            var editCocah = new CoachFormModel()
            {
                FullName = coach.FullName,
                Email = coach.Email,
                Image = coach.Image,
                JobPosition = coach.JobPosition,
                SquadId = coach.SquadId,
                Squads = this.coaches.AllSquads()
            };
           
            return View(editCocah);
        }

        [HttpPost]
        public IActionResult EditCoach(CoachFormModel coach, int id)
        {
            if (!this.coaches.CoachExists(id))
            {
                ModelState.AddModelError("", "Coach does not exist");

                return View(coach);
            }

           
            if (!this.coaches.SquadExists(coach.SquadId))
            {
                ModelState.AddModelError(nameof(coach.SquadId), "Squat does not exist");
              
                return View(coach);
            }

            if (!ModelState.IsValid)
            {
                coach.Squads = this.coaches.AllSquads();
                return View(coach);
            }

            this.coaches.Edit(id, coach);

            return RedirectToAction(nameof(AllCoaches));
        }

        public IActionResult DeletCoach()
        {
            return View();
        }

        public IActionResult AllCoaches()
        {
            var coaches = this.coaches.AllCoaches();

            return View(coaches);
        }


        public IActionResult AddSponsor()
        {
            return View();
        }


        [HttpPost]
        public IActionResult AddSponsor(SponsorFormModel sponsor)
        {
            if (!ModelState.IsValid)
            {
                return View(sponsor);
            }

            this.sponsors.CreateSponsor(sponsor.Name, sponsor.Link, sponsor.Logo);

            return RedirectToAction(nameof(AllSponsors));
        }

        public IActionResult EditSposor()
        {
            return View();
        }

        public IActionResult DeleteSponsor()
        {
            return View();
        }

        public IActionResult AllSponsors()
        {
            var sponsors = this.sponsors.AllSponsors();

            return View(sponsors);
        }


    }
}

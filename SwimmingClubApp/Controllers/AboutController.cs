using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Models.About;
using SwimmingClubApp.Services.Coaches;
using SwimmingClubApp.Services.Coaches.Models;
using SwimmingClubApp.Services.Sponsors;
using SwimmingClubApp.Services.Sponsors.Models;
using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Controllers
{
    [Authorize(Roles = AdminRoleName)]

    public class AboutController : Controller
    {
        private readonly ICoachService coaches;
        private readonly ISponsorService sponsors;
        private readonly IMapper mapper;

        public AboutController(ICoachService coaches, ISponsorService sponsors, IMapper mapper)
        {
            this.coaches = coaches;
            this.sponsors = sponsors;
            this.mapper = mapper;
        }

        [AllowAnonymous]
        public IActionResult History()
        {
            return View();
        }


        [AllowAnonymous]
        public IActionResult Fundrising()
        {
            return View();
        }

        [HttpGet]
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

            var editCocach = new CoachFormModel()
            {
                FullName = coach.FullName,
                Email = coach.Email,
                Image = coach.Image,
                JobPosition = coach.JobPosition,
                SquadId = coach.SquadId,
                Squads = this.coaches.AllSquads()
            };

            return View(editCocach);
        }

        [HttpPost]
        public IActionResult EditCoach(CoachFormModel coach, int id)
        {
            if (!this.coaches.CoachExists(id))
            {
                ModelState.AddModelError("", "Coach does not exist");

                return RedirectToAction(nameof(AllCoaches));
            }


            if (!this.coaches.SquadExists(coach.SquadId))
            {
                ModelState.AddModelError(nameof(coach.SquadId), "Squad does not exist");

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

        [HttpGet]
        public IActionResult DeleteCoach(int id)
        {
            if (!this.coaches.CoachExists(id))
            {
                ModelState.AddModelError("", "Coach does not exist");

                return RedirectToAction(nameof(AllCoaches));
            }

            var coach = this.coaches.CoachDetails(id);

            if (!this.coaches.SquadExists(coach.SquadId))
            {
                ModelState.AddModelError(nameof(coach.SquadId), "Squat does not exist");

                return View(nameof(AllCoaches));
            }
            
            var toDelete = new CoachDetailsServiceModel
            {
                FullName = coach.FullName,
                Image = coach.Image,
                Email = coach.Email,
                JobPosition = coach.JobPosition,
                SquadId = coach.SquadId,
                IsActive = coach.IsActive
            };

            return View(toDelete);
        }

        [HttpPost]
        public IActionResult DeleteCoach(CoachDetailsServiceModel coach, int id)
        {
            if (!this.coaches.CoachExists(id))
            {
                ModelState.AddModelError("", "Coach does not exist");

                return RedirectToAction(nameof(AllCoaches));
            }

            var coachDetails = this.coaches.CoachDetails(id);

            if (!this.coaches.SquadExists(coachDetails.SquadId))
            {
                ModelState.AddModelError(nameof(coach.SquadId), "Squat does not exist");

                return View(coach);
            }

            this.coaches.Delete(id);

            return RedirectToAction(nameof(AllCoaches));
        }

        [AllowAnonymous]
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

        [HttpGet]
        public IActionResult EditSponsor(int id)
        {
            if (!this.sponsors.SponsorExists(id))
            {
                return RedirectToAction(nameof(AllSponsors));
            }

            var sponsor = this.sponsors.Details(id);

            var toEdit = new SponsorFormModel()
            {
                Name = sponsor.Name,
                Logo = sponsor.Logo,
                Link = sponsor.Link,
            };

            return View(toEdit);
        }


        [HttpPost]
        public IActionResult EditSponsor(int id, SponsorFormModel sponsor)
        {
            if (!this.sponsors.SponsorExists(id))
            {
                return RedirectToAction(nameof(AllSponsors));
            }

            if (!ModelState.IsValid)
            {
                return View(sponsor);
            }

            this.sponsors.Edit(id, sponsor);

            return RedirectToAction(nameof(AllSponsors));
        }

        [HttpGet]
        public IActionResult DeleteSponsor(int id)
        {
            if (!this.sponsors.SponsorExists(id))
            {
                ModelState.AddModelError("", "Spondor does not exist");

                return RedirectToAction(nameof(AllSponsors));
            }

            var sponsor = this.sponsors.Details(id);

            var toDelete = new SponsorDetailsServiceModel
            {
               Link = sponsor.Link,
               Logo = sponsor.Logo,
               Name = sponsor.Name,
               IsActive = sponsor.IsActive
            };
            return View(toDelete);
        }


        [HttpPost]
        public IActionResult DeleteSponsor(int id, SponsorDetailsServiceModel sponsor)
        {
            if (!this.sponsors.SponsorExists(id))
            {
                ModelState.AddModelError("", "Spondor does not exist");

                return RedirectToAction(nameof(AllSponsors));
            }

            this.sponsors.DeleteSponsor(id);

            return RedirectToAction(nameof(AllSponsors));
        }

        [AllowAnonymous]
        public IActionResult AllSponsors()
        {
            var sponsors = this.sponsors.AllSponsors();

            return View(sponsors);
        }


    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
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



        public IActionResult Fundrising()
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

        [Authorize]
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
                SquadId = coach.SquadId,
                JobPosition = coach.JobPosition
            };

            this.data.Coaches.Add(newCoach);
            this.data.SaveChanges();

            return RedirectToAction(nameof(AllCoaches));
        }



        public IActionResult EditCoach()
        {
            return View();
        }

        public IActionResult DeletCoach()
        {
            return View();
        }

        public IActionResult AllCoaches()
        {
            var coaches = this.data
                .Coaches
                .Select(c => new CoachListingViewModel
                {
                    FullName = c.FullName,
                    Email = c.Email,
                    Image = c.Image,
                    Squad = c.Squad.SquadName,
                    JobPosition = c.JobPosition
                })
                .ToList();

            return View(coaches);
        }

        [HttpPost]
        [Authorize]
        public IActionResult AddSponsor(AddSponsorFormModel sponsor)
        {

            if (!ModelState.IsValid)
            {
                return View();

            }
            var newSponsor = new Sponsor
            {
                Name = sponsor.Name,
                Link = sponsor.Link,
                Logo = sponsor.Logo
            };

            this.data.Sponsors.Add(newSponsor);
            this.data.SaveChanges();

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
            var sponsors = this.data
                .Sponsors
                .Select(c => new SponsorViewModel
                {
                    Logo = c.Logo,
                    HomePageLink = c.Link
                })
                .ToList();

            return View(sponsors);
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

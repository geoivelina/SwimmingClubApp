using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Areas.Admin.Services.Swimmer.Models;
using SwimmingClubApp.Areas.Admin.Services.Swimmers;

namespace SwimmingClubApp.Areas.Admin.Controllers
{
    public class SwimmerController : AdminController
    {

        private readonly ISwimmerService entries;

        public SwimmerController(ISwimmerService entries)
        {
            this.entries = entries;
        }

        public IActionResult AllEntries() => View(this.entries.AllSwimmers());
        public IActionResult AllSwimmers() => View(this.entries.AllApprovedSwimmers());
        public IActionResult AllDisapproved() => View(this.entries.AllDiaspprovedSwimmers());
        public IActionResult Approve(int id)
        {
            this.entries.Approve(id);
            return RedirectToAction(nameof(AllEntries));
        }

        public IActionResult Disapprive(int id)
        {
            this.entries.Disapprove(id);
            return RedirectToAction(nameof(AllEntries));
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            if (!this.entries.SwimmerExists(id))
            {
                ModelState.AddModelError("", "Swimmer does not exist");

                return RedirectToAction(nameof(AllSwimmers));
            }

            var swimmer = this.entries.SwimmerDetails(id);

            var editSwimmer = new SwimmerEntryServiceModel
            {
                FullName = swimmer.FullName,
                Age = swimmer.Age,
                Address = swimmer.Address,
                PhoneNumber = swimmer.PhoneNumber,
                Email = swimmer.Email,
                ContactPersonName = swimmer.ContactPersonName,
                RelationshipToSwimmer = swimmer.RelationshipToSwimmer,
                MedicalDatails = swimmer.MedicalDatails,
                SwimmingExperience = swimmer.SwimmingExperience,
                Squads = this.entries.AllSquads()
            };

            return View(editSwimmer);
        }

        [HttpPost]
        public IActionResult Edit(int id, SwimmerEntryServiceModel swimmer)
        {
            if (!this.entries.SquadExists(swimmer.SquadId))
            {
                ModelState.AddModelError(nameof(swimmer.SquadId), "Squad does not exist");

                return View(swimmer);
            }

            if (!ModelState.IsValid)
            {
                swimmer.Squads = this.entries.AllSquads();
                return View(swimmer);
            }

            this.entries.Edit(id, swimmer);

            return RedirectToAction(nameof(AllEntries));
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            if (!this.entries.SwimmerExists(id))
            {
                ModelState.AddModelError("", "Swimmer does not exist");

                return RedirectToAction(nameof(AllSwimmers));
            }

            var swimmer = this.entries.SwimmerDetails(id);

            var toDelete = new SwimmerEntryServiceModel
            {
                FullName = swimmer.FullName,
                Age = swimmer.Age,
                Address = swimmer.Address,
                PhoneNumber = swimmer.PhoneNumber,
                Email = swimmer.Email,
                ContactPersonName = swimmer.ContactPersonName,
                RelationshipToSwimmer = swimmer.RelationshipToSwimmer,
                MedicalDatails = swimmer.MedicalDatails,
                SwimmingExperience = swimmer.SwimmingExperience,
                Squads = this.entries.AllSquads()
            };

            return View(toDelete);
        }

        [HttpPost]
        public IActionResult Delete(int id, SwimmerEntryServiceModel swimmer)
        {
            if (!this.entries.SquadExists(swimmer.SquadId))
            {
                ModelState.AddModelError(nameof(swimmer.SquadId), "Squad does not exist");

                return View(swimmer);
            }

            if (!ModelState.IsValid)
            {
                swimmer.Squads = this.entries.AllSquads();
                return View(swimmer);
            }

            this.entries.Delete(id);

            return RedirectToAction(nameof(AllEntries));
        }
    }
}

using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Models.Joinus;
using SwimmingClubApp.Services.Entries;

using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Controllers
{
    [Authorize(Roles = AdminRoleName)]
    public class JoinusController : Controller
    {
        private readonly IJoinusService entries;

        public JoinusController(IJoinusService entries)
        {
            this.entries = entries;
        }

        [AllowAnonymous]
        [HttpGet]
        public IActionResult EntryForm()
        {
            return View(new SwimmerEntryFormModel
            {
                Squads = this.entries.AllSquads()
            });
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult EntryForm(SwimmerEntryFormModel swimmer)
        {
            if (!this.entries.SquadExists(swimmer.SquadId))
            {
                this.ModelState.AddModelError(nameof(swimmer.SquadId), "Squad does not exist.");
            }

            if (!ModelState.IsValid)
            {
                swimmer.Squads = this.entries.AllSquads();
                return View(swimmer);
            }

            this.entries.CreateEntry(
                        swimmer.FullName, 
                        swimmer.Age,
                        swimmer.Email,
                        swimmer.PhoneNumber,
                        swimmer.ContactPersonName,
                        swimmer.RelationshipToSwimmer, 
                        swimmer.Address, 
                        swimmer.MedicalDatails, 
                        swimmer.SwimmingExperience, 
                        swimmer.SquadId);

            return RedirectToAction(nameof(Thankyou));
        }


        [AllowAnonymous]
        public IActionResult Thankyou()
        {
            return View();
        }
    }
}

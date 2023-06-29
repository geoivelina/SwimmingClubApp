using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Data;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.Joinus;

namespace SwimmingClubApp.Controllers
{
    public class JoinusController : Controller
    {
        private readonly SimmingClubDbContext data;

        public JoinusController(SimmingClubDbContext data)
        {
            this.data = data;
        }
        public IActionResult EntryForm()
        {
            return View(new SwimmerEntryFormModel
            {
                Squads = this.GetSquads()
            }); ;
        }

        [HttpPost]
        public IActionResult EntryForm(SwimmerEntryFormModel swimmer)
        {
            if (!this.data.Squads.Any(s=> s.Id == swimmer.SquadId))
            {
                this.ModelState.AddModelError(nameof(swimmer.SquadId), "Squad does not exist.");
            }

            if (!ModelState.IsValid)
            {
                swimmer.Squads = this.GetSquads();
                return View(swimmer);
            }

            var newSwimmer = new Swimmer
            {
                FullName = swimmer.FullName,
                Age = swimmer.Age,
                ContactPersonName = swimmer.ContactPersonName,
                RelationshipToSwimmer = swimmer.RelationshipToSwimmer,
                Address = swimmer.Address,
                MedicalDatails = swimmer.MedicalDatails,
                SwimmingExperience = swimmer.SwimmingExperience,
                SquadId = swimmer.SquadId,
                IsApproved = false
            };
         

            this.data.Swimmers.Add(newSwimmer);
            this.data.SaveChanges();

            return RedirectToAction(nameof(Thankyou));
        }

        private IEnumerable<SwimmerSquadModel> GetSquads()
        {
            return this.data
                .Squads
                .Select(s => new SwimmerSquadModel
                {
                    Id = s.Id,
                    SquadName = s.SquadName
                })
                .ToList();
        }
    
        public IActionResult Thankyou()
        {
            return View();
        }
    }
}

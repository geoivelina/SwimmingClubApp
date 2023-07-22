using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Services.Entries;
using SwimmingClubApp.Services.Entries.Models;

namespace SwimmingClubApp.Areas.Admin.Controllers
{
    public class SwimmerController : Controller
    {

        private readonly IJoinusService entries;

        public SwimmerController(IJoinusService entries)
        {
            this.entries = entries;
        }

        public IActionResult AllSwimmers() => View(this.entries.AllSwimmers());

        public IActionResult AllEntries() => View(this.entries.SwimmersToApprove());


       
        public void Delete(int id)
        {
            var toDelete = this.data.Coaches.Find(id);
            toDelete.IsAvtive = false;

            this.data.SaveChanges();
        }
    }
}

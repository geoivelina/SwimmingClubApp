using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SwimmingClubApp.Services.Entries;

using static SwimmingClubApp.Areas.Admin.AdminConstants;

namespace SwimmingClubApp.Areas.Admin.Controllers
{
    [Area(AreaName)]
    [Authorize(Roles = AdminRoleName)]
    public class AdminController : Controller
    {


    }
}

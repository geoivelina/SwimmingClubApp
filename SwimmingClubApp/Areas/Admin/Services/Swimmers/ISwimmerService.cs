using SwimmingClubApp.Services.Entries.Models;

namespace SwimmingClubApp.Areas.Admin.Services.Swimmers
{
    public interface ISwimmerService
    {
        void Edit(int id, SwimmerServiceModel swimmer);
    }
}

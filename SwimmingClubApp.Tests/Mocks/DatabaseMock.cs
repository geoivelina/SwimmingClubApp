using Microsoft.EntityFrameworkCore;
using SwimmingClubApp.Data;

namespace SwimmingClubApp.Test.Mocks
{
    public static class DatabaseMock
    {
        public static SwimmingClubDbContext Inctance
        {
            get
            {
                var dbContextOptions = new DbContextOptionsBuilder<SwimmingClubDbContext>()
                    .UseInMemoryDatabase(Guid.NewGuid().ToString())
                    .Options;

                return new SwimmingClubDbContext(dbContextOptions);
            }
        }
    }
}

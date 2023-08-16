using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Tests.Data
{
    public static class Sizes
    {
        public static IEnumerable<SizeOption> SizesData()
        {
            var sizes = new List<SizeOption>()
            {
                new SizeOption()
                {
                    Id = 1,
                    Description = "Size1"
                },
                new SizeOption()
                {
                    Id = 2,
                   Description= "Size2L"
                },
                new SizeOption()
                {
                    Id = 3,
                   Description = "Size3"
                }
            };
            return sizes;
        }
    }
}

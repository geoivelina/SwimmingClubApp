using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure
{
    internal class NewsConfiguration : IEntityTypeConfiguration<News>
    {
        public void Configure(EntityTypeBuilder<News> builder)
        {
            builder.HasData(CreateNews());
        }

        private List<News> CreateNews()
        {
            List<News> news = new List<News>()
            {
                new News()
                {
                    Id = 1,
                    DateCreated =DateTime.Now,
                    Title = "January Swimmers of the Month",
                    Desctioption = "Here are our athletes for the month of January." +
                    "Begginer 1: Levi Miller & Lena Yang" +

                    "Begginer 2: Leah Jin & Alex Xiao" +

                    "Begginer 3: Karim Belal & Angela Xiao" +

                    "Fithness 1: Austin Ouyang & Ava Senn" +

                    "Fithness 2: Brock Sever & Lucy Bojrab" +

                    "Fithness 3: Flynn Keyser & Ella Harrity" +

                    "Professional 1: Adam Smith & Maggie Welsh" +

                    "Professional 2: Chis Martin & Nina Simone" +

                    "Professionals 3: Sam Burg & Ava Max",
                    Image = "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg"
                },
                new News()
                {
                    Id=2,
                    DateCreated =DateTime.Now,
                    Title = "February Swimmers of the Month",
                    Desctioption = "Here are our athletes for the month of February." +
                    "Begginer 1: Levi Miller & Lena Yang" +

                    "Begginer 2: Leah Jin & Alex Xiao" +

                    "Begginer 3: Karim Belal & Angela Xiao" +

                    "Fithness 1: Austin Ouyang & Ava Senn" +

                    "Fithness 2: Brock Sever & Lucy Bojrab" +

                    "Fithness 3: Flynn Keyser & Ella Harrity" +

                    "Professional 1: Adam Smith & Maggie Welsh" +

                    "Professional 2: Chis Martin & Nina Simone" +

                    "Professionals 3: Sam Burg & Ava Max",
                    Image = "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg"

                },
                new News()
                {
                    Id = 3,
                    DateCreated =DateTime.Now,
                    Title = "Anual Fundrising Event",
                    Desctioption = "Join us on 24th of July 2023 in SemmerSet Venue at 20:00 h for our Anual Fundrising gathering. You can meet our athleats, their coaches and see their result. Tickets for the event could be found at the receprion desk. If you need more information or would like to join organisation team contact the coordinators: event@mail.com. ",
                    Image = "https://s3.amazonaws.com/images.ecwid.com/images/16075414/1126948529.jpg"
                },
                new News()
                {
                    Id = 4,
                    DateCreated =DateTime.Now,
                    Title = "March Swimmers of the Month",
                    Desctioption = "Here are our athletes for the month of March." +
                    "Begginer 1: Levi Miller & Lena Yang" +

                    "Begginer 2: Leah Jin & Alex Xiao" +

                    "Begginer 3: Karim Belal & Angela Xiao" +

                    "Fithness 1: Austin Ouyang & Ava Senn" +

                    "Fithness 2:  Sever & Lucy Bojrab" +

                    "Fithness 3: Flynn Keyser & Ella Harrity" +

                    "Professional 1: Adam Smith & Maggie Welsh" +

                    "Professional 2: Chis Martin & Nina Simone" +

                    "Professionals 3: Sam Burg & Ava Max",
                    Image = "https://i.pinimg.com/originals/c8/67/fb/c867fbdf7a1952905f883e8294eb6498.jpg"
                }
            };
            return news;
        }
    }
}

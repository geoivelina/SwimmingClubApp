namespace SwimmingClubApp.Data
{
    public class DataConstants
    {
      public  class Coach
        {
            public const int FullNameMinLength = 5;
            public const int FullNameMaxLength = 50;

            public const int EmailMinLength = 10;
            public const int EmailMaxLength = 50;

            public const int JobPOsiotionMinLength = 5;
            public const int JobPOsiotionMaxLength = 30;
        }

        public class Squad
        {
            public const int SquadNameMinLength = 5;
            public const int SquadNameMaxLength = 15;
        }
        public class News
        {
            public const int TitleMinLenth = 10;
            public const int TitleMaxLenth = 50;

            public const int DescriptionMinLenth = 200;
            public const int DescriptionMaxLenth = 2500;
        }

        public class Sponsor
        {
            public const int NameMinLenth = 3;
            public const int NameMaxLenth = 25;

        }
    }
}

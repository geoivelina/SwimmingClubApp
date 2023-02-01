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
        }

        public class Squad
        {
            public const int SquadNameMinLength = 5;
            public const int SquadNameMaxLength = 15;
        }
    }
}

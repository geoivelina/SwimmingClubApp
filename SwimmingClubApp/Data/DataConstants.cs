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
            public const int JobPOsiotionMaxLength = 50;
        }

        public class Squad
        {
            public const int SquadNameMinLength = 5;
            public const int SquadNameMaxLength = 15;
        }

        public class Swimmer
        {
            public const int FullNameMinLength = 5;
            public const int FullNameMaxLength = 50;

            public const int EmailMinLength = 10;
            public const int EmailMaxLength = 50;

            public const int AddressMinLength = 10;
            public const int AddressMaxLength = 150;

            public const int MinAge = 6;
            public const int MaxAge = 70;

            public const int ContactPersonNameMinLength = 5;
            public const int ContactPersonNameMaxLength = 50;

            public const int MedicalDetalsMinLength = 4;
            public const int MedicalDetalsMaxLength = 150;


            public const int RelationshipToSwimmerMinLength = 4;
            public const int RelationshipToSwimmerMaxLength = 20;

            public const int SwimmingExperienceMinLength = 4;
            public const int SwimmingExperienceMaxLength = 150;
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

        public class User
        {
            public const int FullNameMinLenth = 3;
            public const int FullNameMaxLenth = 25;

        }
    }
}

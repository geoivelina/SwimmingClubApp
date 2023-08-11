using AutoMapper;


namespace SwimmingClubApp.Infrastructure.Mapping
{
    public interface IHaveCustomMappings
    {
        void CreateMappings(IProfileExpression configuration);
    }
}

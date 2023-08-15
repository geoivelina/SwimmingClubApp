using AutoMapper;
using SwimmingClubApp.Infrastructure.Mapping;

namespace SwimmingClubApp.Test.Mocks
{
    public class MapperMock
    {

        public static IMapper Instance
        {
            get
            {

                var mapperConfiguration = new MapperConfiguration(cfg =>
                {
                    cfg.AddProfile<ServiceMappingProfile>();
                });

                return new Mapper(mapperConfiguration);

            }
        }
    }
}

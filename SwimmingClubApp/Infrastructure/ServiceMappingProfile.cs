using AutoMapper;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Services.Coaches.Models;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Orders.Models;
using SwimmingClubApp.Services.Products.Models;

namespace SwimmingClubApp.Infrastructure
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            this.CreateMap<ProductDetailsServiceModel, ProductFormModel>();
            this.CreateMap<Squad, CoachSquadServiceModel>();
            this.CreateMap<Coach, CoachListingServiceModel>();
            this.CreateMap<ProductOrderInputModel, OrderServiceModel>();
            this.CreateMap<OrderServiceModel, Order>().ReverseMap();
            this.CreateMap<OrderCartViewModel, OrderServiceModel>();
        }
    }
}

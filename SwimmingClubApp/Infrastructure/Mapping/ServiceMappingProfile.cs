using AutoMapper;
using SwimmingClubApp.Data.Models;
using SwimmingClubApp.Models.ClubShop;
using SwimmingClubApp.Models.Invoice;
using SwimmingClubApp.Services.Coaches.Models;
using SwimmingClubApp.Services.Data.Models;
using SwimmingClubApp.Services.Entries.Models;
using SwimmingClubApp.Services.Invoices.Models;
using SwimmingClubApp.Services.Newses.Models;
using SwimmingClubApp.Services.Orders.Models;
using SwimmingClubApp.Services.Products.Models;
using SwimmingClubApp.Services.Sponsors.Models;
using System.Reflection;

namespace SwimmingClubApp.Infrastructure.Mapping
{
    public class ServiceMappingProfile : Profile
    {
        public ServiceMappingProfile()
        {
            AutoMapperConfig.RegisterMappings(
                typeof(ProductDetailsServiceModel).GetTypeInfo().Assembly,
                typeof(ProductServiceModel).GetTypeInfo().Assembly);

            CreateMap<Coach, CoachListingServiceModel>()
                .ForMember(c => c.Squad, cfg => cfg.MapFrom(s => s.Squad.SquadName));

            CreateMap<ProductSize, ProductSizeServiceModel>().ReverseMap();

            CreateMap<Invoice, InvoiceServiceModel>();
            CreateMap<InvoiceServiceModel, InvoiceDetailsViewModel>()
                .ForMember(u => u.ClientName, cfg => cfg.MapFrom(c => c.Client.UserFullName));
            CreateMap<InvoiceServiceModel, InvoiceProfileViewModel>()
                .ForMember(des => des.TotalSum,
                cfg => cfg.MapFrom(origin => origin.Orders.Sum(o => o.Product.Price * o.Quantity)));

            CreateMap<Order, OrderServiceModel>();
            CreateMap<OrderServiceModel, InvoiceDetailsOrderViewModel>();
            CreateMap<OrderServiceModel, OrderCartViewModel>();
            CreateMap<OrderStatus, OrderStatusServiceModel>();

            CreateMap<User, UserServiceModel>();

            CreateMap<Product, ProductServiceModel>();
            CreateMap<ProductCategory, ProductCategoryServiceModel>();
            CreateMap<ProductOrderInputModel, OrderServiceModel>();


            CreateMap<Squad, SwimmerSquadServiceModel>();
            CreateMap<News, NewsServiceModel>();
            CreateMap<Sponsor, SponsorServiceModel>();

        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SwimmingClubApp.Data.Models;

namespace SwimmingClubApp.Infrastructure.Configurations
{
    public class OrderStatusConfiguration : IEntityTypeConfiguration<OrderStatus>
    {
        public void Configure(EntityTypeBuilder<OrderStatus> builder)
        {
            builder.HasData(CreateStatuses());
        }

        private List<OrderStatus> CreateStatuses()
        {
            List<OrderStatus> statuses = new List<OrderStatus>()
            {
                new OrderStatus()
                {
                    Id = 1,
                    Name = "Active"
                },
                new OrderStatus()
                {
                    Id = 2,
                    Name = "Completed"
                }
            };
            return statuses;
        }
    }
}

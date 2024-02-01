using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Project.Shared.Domain;

namespace Project.Server.Configurations.Entities
{
    public class UserPurchaseHistorySeedConfiguration : IEntityTypeConfiguration<UserPurchaseHistory>
    {
        public void Configure(EntityTypeBuilder<UserPurchaseHistory> builder)
        {
            // No data seeding, only configuration
        }
    }
}
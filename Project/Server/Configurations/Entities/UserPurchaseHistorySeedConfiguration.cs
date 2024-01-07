using Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class UserPurchaseHistorySeedConfiguration : IEntityTypeConfiguration<UserPurchaseHistory>
    {
        public void Configure(EntityTypeBuilder<UserPurchaseHistory> builder)
        {
            builder.HasData(
               new UserPurchaseHistory
               {
                   Id = 1,
                   PurchaseId = 1,
                   CustomerId = 1,
                   Car = "Toyota",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now
               },
               new UserPurchaseHistory
               {
                   Id = 2,
                   PurchaseId = 2,
                   CustomerId = 1,
                   Car = "Nissan",
                   DateCreated = DateTime.Now,
                   DateUpdated = DateTime.Now
               }
               );;
        }
    }
}

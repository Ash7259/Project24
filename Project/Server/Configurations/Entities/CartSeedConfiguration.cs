using Project.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Server.Configurations.Entities
{
    public class CartSeedConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasData(
               new Cart
               {
                   Id = 1,
                   PurchaseId = 1,
                   CustomerId = 1,
                   CarName = "Toyota",
                   RentStart = DateTime.Now,
                   RentEnd = DateTime.Now.AddDays(7),
                   CreatedBy = "System",
                   UpdatedBy = "System",
                   IsCompleted = true
               },
               new Cart
               {
                   Id = 2,
                   PurchaseId = 2,
                   CustomerId = 1,
                   CarName = "Nissan",
                   RentStart = DateTime.Now,
                   RentEnd = DateTime.Now.AddDays(8),
                   CreatedBy = "System",
                   UpdatedBy = "System",
                   IsCompleted = true
               },
               new Cart
               {
                   Id = 3,
                   PurchaseId = 3,
                   CustomerId = 2,
                   CarName = "Honda",
                   RentStart = DateTime.Now,
                   RentEnd = DateTime.Now.AddDays(9),
                   CreatedBy = "System",
                   UpdatedBy = "System",
                   IsCompleted = true
               }
               ); ;
        }
    }
}

using BookStore.Dal.Domain;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class OrderConfiguration : BaseEntityConfiguration<Order>
    {
        public override void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.UserId).IsRequired(true);
            builder.Property(p => p.BookId).IsRequired(true);
            builder.Property(p => p.CreatedAt).IsRequired(true);
            builder.Property(p => p.CreatedBy);
            builder.Property(p => p.PaymantMethod).IsRequired(true);
            builder.Property(p => p.Total).IsRequired(true);
            builder.Property(p => p.Quatity).IsRequired(true);

            builder
                .HasOne<User>(o => o.User)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.UserId);

            builder
                .HasOne<Book>(o => o.Book)
                .WithMany(o => o.Orders)
                .HasForeignKey(o => o.BookId);

            builder.HasData(new List<Order>
            {
                new Order
                {
                    Id = 1,
                    UserId = 5,
                    BookId = 2,
                    CreatedBy = "jasirbuirc",
                    Quatity = 2,
                    Total = 38,
                    PaymantMethod = "Paypal"
                },
                 new Order
                {
                    Id = 2,
                    UserId = 5,
                    BookId = 2,
                    CreatedBy = "jasirbuirc",
                    Quatity = 1,
                    Total = 19,
                    PaymantMethod = "Paypal"
                },
                  new Order
                {
                    Id = 3,
                    UserId = 2,
                    BookId = 1,
                    CreatedBy = "jasirbuirc",
                    Quatity = 2,
                    Total = 10,
                    PaymantMethod = "Paypal"
                },
            });
        }
    }
}

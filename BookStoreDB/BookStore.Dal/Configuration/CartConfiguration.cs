using BookStore.Dal.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class CartConfiguration : BaseEntityConfiguration<Cart>
    {
        public override void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.UserId).IsRequired(true);
            builder.Property(p => p.BookId).IsRequired(true);
            builder.Property(p => p.CreatedAt).IsRequired(true);
            builder.Property(p => p.CreatedBy);
            builder.Property(p => p.Quantity).IsRequired(true);

            builder
                .HasOne(ub => ub.User)
                .WithMany(ub => ub.Carts)
                .HasForeignKey(ub => ub.UserId);

            builder
                .HasOne(ub => ub.Book)
                .WithMany(ub => ub.Carts)
                .HasForeignKey(ub => ub.BookId);
        }
    }
}

using BookStore.Dal.Domain;
using BookStore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class UserBookConfiguration : BaseEntityConfiguration<UserBook>
    {
        public override void Configure(EntityTypeBuilder<UserBook> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.UserId).IsRequired(true);
            builder.Property(p => p.BookId).IsRequired(true);
            builder.Property(p => p.CreatedAt).IsRequired(true);
            builder.Property(p => p.CreatedBy);
            builder.Property(p => p.isWhishList).IsRequired(true);
            builder.Property(p => p.isCart).IsRequired(true);
            builder.Property(p => p.Quatity).IsRequired(true);

            builder
                .HasOne<User>(ub => ub.User)
                .WithMany(ub => ub.UserBooks)
                .HasForeignKey(ub => ub.UserId);

            builder
                .HasOne<Book>(ub => ub.Book)
                .WithMany(ub => ub.UserBooks)
                .HasForeignKey(ub => ub.BookId);
        }
    }
}

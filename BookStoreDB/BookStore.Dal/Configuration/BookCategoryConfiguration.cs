using BookStore.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    class BookCategoryConfiguration : IEntityTypeConfiguration<BookCategory>
    {
        public void Configure(EntityTypeBuilder<BookCategory> builder)
        {
            builder.HasKey(p => new { p.BookId, p.CategoryId });

            builder
                .HasOne(p => p.Book)
                .WithMany(p => p.BookCategories)
                .HasForeignKey(p => p.BookId);

            builder
               .HasOne(p => p.Category)
               .WithMany(p => p.BookCategories)
               .HasForeignKey(p => p.CategoryId);
        }
    }
}

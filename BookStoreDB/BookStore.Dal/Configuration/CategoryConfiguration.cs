using BookStore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    class CategoryConfiguration : BaseEntityConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Name);

            builder
                .HasMany(b => b.BookCategories)
                .WithOne(c => c.Category)
                .HasForeignKey(b => b.CategoryId);
        }
    }
}

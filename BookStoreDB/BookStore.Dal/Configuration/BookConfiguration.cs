using BookStore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class BookConfiguration : BaseEntityConfiguration<Book>
    {
        public override void Configure(EntityTypeBuilder<Book> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired(true);
            builder.Property(p => p.Price).IsRequired(true);
            builder.Property(p => p.Currrency).IsRequired(true);
            builder.Property(p => p.Description).IsRequired(true);
            builder.Property(p => p.Author).IsRequired(true);
            builder.Property(p => p.Image);
            builder.Property(p => p.Quantity);

            builder.HasData(new List<Book> {
                new Book
                {
                    Id = 1,
                    CreatedBy = "jasirbuirc",
                    Name = "Orlovi rano lete",
                    Price = 5,
                    Currrency = "BAM",
                    Description = "Dobar Roman",
                    Author = "Neki_autor1",
                    Quantity = 13
                },
                 new Book
                {
                     Id = 2,
                    CreatedBy = "jasirbuirc",
                    Name = "Odgoj dijece u islamu",
                    Price = 19,
                    Currrency = "BAM",
                    Description = "Knjiga za svaki uzrast",
                    Author = "Neki_autor2",
                    Quantity = 7
                },
                  new Book
                {
                    Id = 3,
                    CreatedBy = "jasirbuirc",
                    Name = "Zeleno busenje",
                    Price = 7,
                    Currrency = "BAM",
                    Description = "Dobar Roman",
                    Author = "Neki_autor3",
                    Quantity = 9
                },
            });
        }
    }
}

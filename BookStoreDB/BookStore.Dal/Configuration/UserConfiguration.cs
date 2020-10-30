using BookStore.Domain;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BookStore.Dal.Configuration
{
    public class UserConfiguration : BaseEntityConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            base.Configure(builder);
            builder.HasKey(p => p.Id);
            builder.Property(p => p.FirstName).IsRequired(true);
            builder.Property(p => p.LastName).IsRequired(true);
            builder.Property(p => p.Email).IsRequired(true);
            builder.Property(p => p.Password).IsRequired(true);
            builder.Property(p => p.Address).IsRequired(true);
            builder.Property(p => p.IsAdmin);

            builder.HasData(new List<User>
            {
                new User
                {
                    Id = 1,
                    FirstName = "Jasir",
                    LastName = "Buric",
                    Email = "jasir.buric@edu.fit.ba",
                    Password = "123445566666",
                    Address = "Gorazdanska 96",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "jasirburic"
                },
                  new User
                {
                    Id = 2,
                    FirstName = "Muhamed",
                    LastName = "Halkic",
                    Email = "muhamed.halkic@edu.fit.ba",
                    Password = "lksdjfllkl44444",
                    Address = "Halkici 23",
                    CreatedAt = DateTime.UtcNow,
                    CreatedBy = "jasirburic"
                }
            });

        }
    }
}

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

            builder
                .HasMany(ub => ub.Carts)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookId);

            builder
                .HasMany(o => o.Orders)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookId);

            builder
                .HasMany(o => o.BookCategories)
                .WithOne(b => b.Book)
                .HasForeignKey(b => b.BookId);

            builder.HasData(new List<Book> {
                new Book
                {
                    Id = 1,
                    CreatedBy = "jasirburic",
                    Name = "Vjenčanje",
                    Image="../../assets/Vjencanje.jpg",
                    Author = "Julie Garwood",
                    Price = 22,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Roman Vjenčanje nezaboravna je ljubavna priča puna strasti i uzbudljivih intriga iz pera nenadmašne Julie Garwood. Putujući iz Engleske u Škotsku kako bi se udala."
                },
                 new Book
                {
                    Id = 2,
                    CreatedBy = "jasirburic",
                    Name = "Mi protiv vas",
                    Image="../../assets/Mi_protiv_vas.jpg",
                    Author = "Fredrik Bakman",
                    Price = 20,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Ponekad je tako jednostavno potaći ljude da mrze jedni druge da je prosto neshvatljivo kako bilo šta drugo i radimo. Nakon užasnih zbivanja koja su potresla Medvjedgrad."
                },
                  new Book
                {
                    Id = 3,
                    CreatedBy = "jasirburic",
                    Name = "Životinja srca",
                    Image="../../assets/Zivotinja_srca.jpg",
                    Author = "Herta Miler",
                    Price = 15,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Dobitnica Nobelove nagrade. Lolino samoubistvo, koje je možda i ubistvo, povezuje četvoro mladih ljudi. Između njih se razvija neraskidivo prijateljstvo."
                },
                  new Book
                {
                    Id = 4,
                    CreatedBy = "jasirburic",
                    Name = "Živim tiho",
                    Image="../../assets/Zivim_tiho.jpg",
                    Author = "Fadil Duranović",
                    Price = 15,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Fadil Duranović se suočio sa sobom i svijetom, a potom zatočen slikom i međusobnim odnosom, pjesnički osvijestio svoju komunikaciju."
                },
                  new Book
                {
                    Id = 5,
                    CreatedBy = "jasirburic",
                    Name = "Časovničareva kći",
                    Image="../../assets/Casovnicareva_kci.jpg",
                    Author = "Kejt Morton",
                    Price = 26,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Mog pravog imena niko se ne seća. Istinu o tom letu niko ne zna. U leto 1862. grupa mladih umetnika na čelu sa talentovanim Edvardom Redklifom."
                },
                  new Book
                {
                    Id = 6,
                    CreatedBy = "jasirburic",
                    Name = "Tuđa pravila",
                    Image="../../assets/Tudja_pravila.jpg",
                    Author = "Džon Irving",
                    Price = 30,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Radnja ovog romana odvija se u ruralnim krajevima Nove Engleske u prvoj polovini dvadesetog veka. To je priča o doktoru Vilburu Larču."
                },
                  new Book
                {
                    Id = 7,
                    CreatedBy = "jasirburic",
                    Name = "Garavi sokak",
                    Image="../../assets/Garavi_sokak.jpg",
                    Author = "Miroslav Antić",
                    Price = 16,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Veselo cigansko vašarište sa nekoliko suza i kapi kiše Miroslav Antić posvećuje ovu knjigu mladom Ciganinu Miletu Dileji, koga su fašisti jedne noći odveli."
                },
                  new Book
                {
                    Id = 8,
                    CreatedBy = "jasirburic",
                    Name = "Ime ruže",
                    Image="../../assets/Ime_ruze.jpg",
                    Author = "Umberto Eko",
                    Price = 15,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Jedan od temeljnih postmodernističkih romana o fatalnom dejstvu jedne zabranjene knjige smješten je u godinu 1327. Franjevački monasi u bogatoj italijanskoj opatiji."
                },
                  new Book
                {
                    Id = 9,
                    CreatedBy = "jasirburic",
                    Name = "Medvjedgrad",
                    Image="../../assets/Medvjedgrad.jpg",
                    Author = "Fredrik Bakman",
                    Price = 20,
                    Currrency = "BAM",
                    Quantity = 13,
                    Description = "Roman Medvjedgrad prvi je dio autorove duologije o problemima što ih donosi život u maloj zajednici. Problemima što ih se lako može preslikati i na šire i veće zajednice."
                },
            });
        }
    }
}

using MAFBurger.WebApp.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAFBurger.WebApp.Data.EntityConfiguration
{
    public class SauceConfiguration : IEntityTypeConfiguration<Sauce>
    {
        public void Configure(EntityTypeBuilder<Sauce> builder)
        {
            builder.Property(e => e.Name).HasColumnType("nvarchar(30)");

            builder.HasData(new Sauce
            {
                Id = 1,
                Name = "Acı Sos",
                Price = 10.00m,
                CreatedDate = new DateTime(2024, 11, 21, 12, 45, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
            builder.HasData(new Sauce
            {
                Id = 2,
                Name = "Sarımsaklı Mayonez",
                Price = 10.00m,
                CreatedDate = new DateTime(2024, 11, 21, 12, 47, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
            builder.HasData(new Sauce
            {
                Id = 3,
                Name = "Ballı Hardal",
                Price = 10.00m,
                CreatedDate = new DateTime(2024, 11, 21, 12, 50, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
            builder.HasData(new Sauce
            {
                Id = 4,
                Name = "Ranch Sos",
                Price = 10.00m,
                CreatedDate = new DateTime(2024, 11, 21, 12, 51, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
            builder.HasData(new Sauce
            {
                Id = 5,
                Name = "Barbekü Sos",
                Price = 10.00m,
                CreatedDate = new DateTime(2024, 11, 21, 12, 53, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
        }
    }
}

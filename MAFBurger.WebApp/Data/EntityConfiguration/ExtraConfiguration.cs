using MAFBurger.WebApp.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAFBurger.WebApp.Data.EntityConfiguration
{
    public class ExtraConfiguration : IEntityTypeConfiguration<Extra>
    {
        public void Configure(EntityTypeBuilder<Extra> builder)
        {
            builder.Property(e => e.Name).HasColumnType("nvarchar(70)");

            builder.HasData(new Extra
            {
                Id = 1,
                Name = "Extra Patates Kızartması (küçük boy)",
                Price = 35.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 45, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });

            builder.HasData(new Extra
            {
                Id = 2,
                Name = "Extra Patates Kızartması (orta boy)",
                Price = 50.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 46, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });

            builder.HasData(new Extra
            {
                Id = 3,
                Name = "Extra Patates Kızartması (baya büyük boy)",
                Price = 70.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 47, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });

            builder.HasData(new Extra
            {
                Id = 4,
                Name = "Extra Köfte",
                Price = 90.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 47, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });

            builder.HasData(new Extra
            {
                Id = 5,
                Name = "Extra Soğan Halkası (8'li)",
                Price = 60.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 49, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });

            builder.HasData(new Extra
            {
                Id = 6,
                Name = "Extra Chicken Stick (8'li)",
                Price = 85.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 49, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
            builder.HasData(new Extra
            {
                Id = 7,
                Name = "Sarımsaklı Mayonez + Ballı Hardal",
                Price = 15.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 52, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
            builder.HasData(new Extra
            {
                Id = 8,
                Name = "Acı Sos + Sarımsaklı Mayonez ",
                Price = 15.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 53, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
            builder.HasData(new Extra
            {
                Id = 9,
                Name = "Apple Pie",
                Price = 70.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 54, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
            builder.HasData(new Extra
            {
                Id = 10,
                Name = "Sufle + Dondurma",
                Price = 85.00m,
                CreatedDate = new DateTime(2024, 11, 18, 11, 54, 51, 585, DateTimeKind.Local).AddTicks(9444),
                IsActive = true,
            });
        }
    }
    
}

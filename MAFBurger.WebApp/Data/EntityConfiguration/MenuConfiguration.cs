using MAFBurger.WebApp.Data.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MAFBurger.WebApp.Data.EntityConfiguration
{
    public class MenuConfiguration : IEntityTypeConfiguration<Menu>
    {
        public void Configure(EntityTypeBuilder<Menu> builder)
        {
            builder.Property(m => m.Name).HasColumnType("nvarchar(30)");

            builder.HasData(
                new Menu
                {
                    Id = 1,
                    Name = "Normal Hamburger",
                    Price = 290.00m,
                    Description = "Bildiğimiz normal hamburger. Köfte + Marul + Turşu + Soğan + Ketçap/Mayonez",
                    IsActive = true,
                    CreatedDate = new DateTime(2024, 11, 18, 11, 06, 51, 585, DateTimeKind.Local).AddTicks(9444)
                }
            );
            builder.HasData(
                new Menu
                {
                    Id = 2,
                    Name = "Cheese Burger",
                    Price = 310.00m,
                    Description = "Bildiğimiz normal cheeseburger. Köfte + Cheddar + Marul + Turşu + Soğan + Ketçap/ Mayonez",
                    IsActive = true,
                    CreatedDate = new DateTime(2024, 11, 18, 11, 23, 51, 585, DateTimeKind.Local).AddTicks(9444)
                }
            );
            builder.HasData(
                new Menu
                {
                    Id = 3,
                    Name = "Mushroom Burger",
                    Price = 340.00m,
                    Description = "Bildiğimiz normal mushroomburger. İçinde harika sotelenmiş kuzukulağı mantarları var. Köfte + Kuzukulağı Mantarı + Marul + Turşu + Soğan + Ketçap/Mayonez",
                    IsActive = true,
                    CreatedDate = new DateTime(2024, 11, 18, 11, 23, 51, 585, DateTimeKind.Local).AddTicks(9444)
                }
            );
            builder.HasData(
                new Menu
                {
                    Id = 4,
                    Name = "Karamelize Soğan Burger",
                    Price = 340.00m,
                    Description = "Bildiğimiz normal hamburgerin içinde karamelize soğan var. Köfte + Karamelize Soğan + Marul + Turşu + Soğan + Ketçap/Mayonez",
                    IsActive = true,
                    CreatedDate = new DateTime(2024, 11, 18, 11, 29, 51, 585, DateTimeKind.Local).AddTicks(9444)
                }
            );
            builder.HasData(
                new Menu
                {
                    Id = 5,
                    Name = "Sloppy Joe",
                    Price = 355.00m,
                    Description = "Bu çok güzel bi lezzet. Anlatılmaz, deneyin.",
                    IsActive = true,
                    CreatedDate = new DateTime(2024, 11, 18, 11, 29, 51, 585, DateTimeKind.Local).AddTicks(9444)
                }
            );
            builder.HasData(
                new Menu
                {
                    Id = 6,
                    Name = "SmashBurger",
                    Price = 335.00m,
                    Description = "Çıtıra yakın bir hamburger köftesi + özel sos + biraz sevgi.",
                    IsActive = true,
                    CreatedDate = new DateTime(2024, 11, 18, 11, 32, 51, 585, DateTimeKind.Local).AddTicks(9444)
                }
            );
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class MenuTableSeedDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Menus",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENhC3b17xnQ327ZNB1AanrNM+K9YFiag9v9kjjsXw6ZB2mSPK6VEORi8i88n4b7j4w==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJG23aqX885uEWMlvQ15XWi/ng98rCF1DuIaSiN5+7L4FLzIctDhPnsinAZqBkY8Kw==");

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Beverages", "BurgerExtras", "CreatedDate", "DeletedDate", "Description", "IsActive", "IsDeleted", "Name", "Price", "Sauces", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2024, 11, 18, 11, 6, 51, 585, DateTimeKind.Local).AddTicks(9444), null, "Bildiğimiz normal hamburger. Köfte + Marul + Turşu + Soğan + Ketçap/Mayonez", true, false, "Normal Hamburger", 290.00m, null, null },
                    { 2, null, null, new DateTime(2024, 11, 18, 11, 23, 51, 585, DateTimeKind.Local).AddTicks(9444), null, "Bildiğimiz normal cheeseburger. Köfte + Cheddar + Marul + Turşu + Soğan + Ketçap/ Mayonez", true, false, "Cheese Burger", 310.00m, null, null },
                    { 3, null, null, new DateTime(2024, 11, 18, 11, 23, 51, 585, DateTimeKind.Local).AddTicks(9444), null, "Bildiğimiz normal mushroomburger. İçinde harika sotelenmiş kuzukulağı mantarları var. Köfte + Kuzukulağı Mantarı + Marul + Turşu + Soğan + Ketçap/Mayonez", true, false, "Mushroom Burger", 340.00m, null, null },
                    { 4, null, null, new DateTime(2024, 11, 18, 11, 29, 51, 585, DateTimeKind.Local).AddTicks(9444), null, "Bildiğimiz normal hamburgerin içinde karamelize soğan var. Köfte + Karamelize Soğan + Marul + Turşu + Soğan + Ketçap/Mayonez", true, false, "Karamelize Soğan Burger", 340.00m, null, null },
                    { 5, null, null, new DateTime(2024, 11, 18, 11, 29, 51, 585, DateTimeKind.Local).AddTicks(9444), null, "Bu çok güzel bi lezzet. Anlatılmaz, deneyin.", true, false, "Sloppy Joe", 355.00m, null, null },
                    { 6, null, null, new DateTime(2024, 11, 18, 11, 32, 51, 585, DateTimeKind.Local).AddTicks(9444), null, "Çıtıra yakın bir hamburger köftesi + özel sos + biraz sevgi.", true, false, "SmashBurger", 335.00m, null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKQtbMp74sEMF8XAAfFNie5OXurhvhaT1CUr/zuodwSsbRvaygYsKvGeKclNtFsiMQ==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKmcmur9YVoEC2Sc/8r60GaDIxP4rNJXjCoki13Ry/kBoeptwXoQ21zG63kG3DJ5TQ==");
        }
    }
}

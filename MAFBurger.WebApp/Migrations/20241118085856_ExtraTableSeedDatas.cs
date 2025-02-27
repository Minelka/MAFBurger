using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class ExtraTableSeedDatas : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Extras",
                type: "nvarchar(70)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEFlIjRcbQnspYlTl7znQLVsifm7DVc2JgaGKHv5bUCZbZI6zK0wxZQyJo6W5TAnYVg==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAELG0m5h6RWIr6+ZIuiISykF44LjV/yE8P2W59d7EdcgDwM1QDwiGiD2kl0tKkx5G0w==");

            migrationBuilder.InsertData(
                table: "Extras",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 18, 11, 45, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Extra Patates Kızartması (küçük boy)", 35.00m, null },
                    { 2, new DateTime(2024, 11, 18, 11, 46, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Extra Patates Kızartması (orta boy)", 50.00m, null },
                    { 3, new DateTime(2024, 11, 18, 11, 47, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Extra Patates Kızartması (baya büyük boy)", 70.00m, null },
                    { 4, new DateTime(2024, 11, 18, 11, 47, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Extra Köfte", 90.00m, null },
                    { 5, new DateTime(2024, 11, 18, 11, 49, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Extra Soğan Halkası (8'li)", 60.00m, null },
                    { 6, new DateTime(2024, 11, 18, 11, 49, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Extra Chicken Stick (8'li)", 85.00m, null },
                    { 7, new DateTime(2024, 11, 18, 11, 52, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Sarımsaklı Mayonez + Ballı Hardal", 15.00m, null },
                    { 8, new DateTime(2024, 11, 18, 11, 53, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Acı Sos + Sarımsaklı Mayonez ", 15.00m, null },
                    { 9, new DateTime(2024, 11, 18, 11, 54, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Apple Pie", 70.00m, null },
                    { 10, new DateTime(2024, 11, 18, 11, 54, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Sufle + Dondurma", 85.00m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Extras",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Extras",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(70)");

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
        }
    }
}

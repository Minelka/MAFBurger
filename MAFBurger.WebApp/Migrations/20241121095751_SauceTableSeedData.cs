using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SauceTableSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sauces",
                type: "nvarchar(30)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "329d3be5-8001-4997-85a9-ebc16be771c2",
                column: "CreatedDate",
                value: new DateTime(2024, 11, 21, 12, 57, 50, 518, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "c9bbce7e-7372-47f2-80e9-029ce117f245",
                column: "CreatedDate",
                value: new DateTime(2024, 11, 21, 12, 57, 50, 518, DateTimeKind.Local).AddTicks(8779));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 21, 12, 57, 50, 519, DateTimeKind.Local).AddTicks(1144), "AQAAAAIAAYagAAAAEK3AujPoL8vL+RPW5A20lJfbTx5nUsBEhI/Bt8U5/UlPV2wvCvtKTCBPCsJ7eJOinA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 21, 12, 57, 50, 592, DateTimeKind.Local).AddTicks(6769), "AQAAAAIAAYagAAAAEHRvMU2PPQXWAdWA0AwO/TVDGYztdKH8kG8Xi8XcvpQXAO947EZnmUxNrv1FPo+rnw==" });

            migrationBuilder.InsertData(
                table: "Sauces",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "Name", "Price", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 11, 21, 12, 45, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Acı Sos", 10.00m, null },
                    { 2, new DateTime(2024, 11, 21, 12, 47, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Sarımsaklı Mayonez", 10.00m, null },
                    { 3, new DateTime(2024, 11, 21, 12, 50, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Ballı Hardal", 10.00m, null },
                    { 4, new DateTime(2024, 11, 21, 12, 51, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Ranch Sos", 10.00m, null },
                    { 5, new DateTime(2024, 11, 21, 12, 53, 51, 585, DateTimeKind.Local).AddTicks(9444), null, true, false, "Barbekü Sos", 10.00m, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Sauces",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sauces",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sauces",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sauces",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sauces",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Sauces",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "329d3be5-8001-4997-85a9-ebc16be771c2",
                column: "CreatedDate",
                value: new DateTime(2024, 11, 21, 12, 47, 44, 982, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "c9bbce7e-7372-47f2-80e9-029ce117f245",
                column: "CreatedDate",
                value: new DateTime(2024, 11, 21, 12, 47, 44, 982, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 21, 12, 47, 44, 982, DateTimeKind.Local).AddTicks(4974), "AQAAAAIAAYagAAAAEAFCkMEmMQMMmiouuSXKE8SouMwLFjS5kEUt+8Gj3hWaU8r3j/jKAyXyOhQVL5TzHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 21, 12, 47, 45, 66, DateTimeKind.Local).AddTicks(2834), "AQAAAAIAAYagAAAAEKFZiu6bovSednfddeY9Vxmj7Y+lpGDCdVX5thj3AWsewmZvbqY2Muyg5MUjWOIk2A==" });
        }
    }
}

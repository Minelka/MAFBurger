using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class Accountcontrollerandadminview : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "329d3be5-8001-4997-85a9-ebc16be771c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9bbce7e-7372-47f2-80e9-029ce117f245");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "AspNetUsers",
                type: "bit",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "AspNetUsers",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserType",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "AppRole",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRole", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AppRole",
                columns: new[] { "Id", "ConcurrencyStamp", "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "Name", "NormalizedName", "UpdatedDate" },
                values: new object[,]
                {
                    { "329d3be5-8001-4997-85a9-ebc16be771c2", null, new DateTime(2024, 11, 21, 9, 55, 44, 646, DateTimeKind.Local).AddTicks(2597), null, true, false, "Admin", "ADMIN", null },
                    { "c9bbce7e-7372-47f2-80e9-029ce117f245", null, new DateTime(2024, 11, 21, 9, 55, 44, 646, DateTimeKind.Local).AddTicks(2645), null, true, false, "Customer", "CUSTOMER", null }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                columns: new[] { "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "PasswordHash", "UpdatedDate", "UserType" },
                values: new object[] { new DateTime(2024, 11, 21, 9, 55, 44, 646, DateTimeKind.Local).AddTicks(5011), null, true, false, "AQAAAAIAAYagAAAAEHvAS6jbx/rI8DaI+fmBTlvhIdcTrJi7qOMYea5JrjMq990S55Ocb+De6y7IhzvbTA==", null, 0 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                columns: new[] { "CreatedDate", "DeletedDate", "IsActive", "IsDeleted", "PasswordHash", "UpdatedDate", "UserType" },
                values: new object[] { new DateTime(2024, 11, 21, 9, 55, 44, 767, DateTimeKind.Local).AddTicks(7319), null, true, false, "AQAAAAIAAYagAAAAED+a23slItXDUEAiyfO4f6EzwqkAjOCa3jarBGNcoO87h6Is3BjaIcznfKvhP2ehVg==", null, 0 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRole");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "DeletedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "UserType",
                table: "AspNetUsers");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetRoles",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "329d3be5-8001-4997-85a9-ebc16be771c2", null, "AppRole", "Admin", "ADMIN" },
                    { "c9bbce7e-7372-47f2-80e9-029ce117f245", null, "AppRole", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAJmBASkvT5i1FwKFKLjP5qhi10sPdc6A2zv+n6jnDZsy/cIhZ2T+tVorDTfL97E2g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEI2GjXSRJhWhqtxyNifn1HAeGqtA0Fl+VvqJHL0tyd16B4u7ro9SA3vHjUCfVBuTDg==");
        }
    }
}

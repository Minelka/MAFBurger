using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class SaucesTableCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Sauces",
                table: "Menus",
                newName: "SaucesId");

            migrationBuilder.CreateTable(
                name: "Sauces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sauces", x => x.Id);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Menus_SaucesId",
                table: "Menus",
                column: "SaucesId");

            migrationBuilder.AddForeignKey(
                name: "FK_Menus_Sauces_SaucesId",
                table: "Menus",
                column: "SaucesId",
                principalTable: "Sauces",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Menus_Sauces_SaucesId",
                table: "Menus");

            migrationBuilder.DropTable(
                name: "Sauces");

            migrationBuilder.DropIndex(
                name: "IX_Menus_SaucesId",
                table: "Menus");

            migrationBuilder.RenameColumn(
                name: "SaucesId",
                table: "Menus",
                newName: "Sauces");

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "329d3be5-8001-4997-85a9-ebc16be771c2",
                column: "CreatedDate",
                value: new DateTime(2024, 11, 21, 9, 55, 44, 646, DateTimeKind.Local).AddTicks(2597));

            migrationBuilder.UpdateData(
                table: "AppRole",
                keyColumn: "Id",
                keyValue: "c9bbce7e-7372-47f2-80e9-029ce117f245",
                column: "CreatedDate",
                value: new DateTime(2024, 11, 21, 9, 55, 44, 646, DateTimeKind.Local).AddTicks(2645));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 21, 9, 55, 44, 646, DateTimeKind.Local).AddTicks(5011), "AQAAAAIAAYagAAAAEHvAS6jbx/rI8DaI+fmBTlvhIdcTrJi7qOMYea5JrjMq990S55Ocb+De6y7IhzvbTA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                columns: new[] { "CreatedDate", "PasswordHash" },
                values: new object[] { new DateTime(2024, 11, 21, 9, 55, 44, 767, DateTimeKind.Local).AddTicks(7319), "AQAAAAIAAYagAAAAED+a23slItXDUEAiyfO4f6EzwqkAjOCa3jarBGNcoO87h6Is3BjaIcznfKvhP2ehVg==" });
        }
    }
}

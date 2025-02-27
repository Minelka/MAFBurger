using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class UserRoleSeedDataInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "329d3be5-8001-4997-85a9-ebc16be771c2", "252d1809-cd07-4ebd-87d1-83cefac3b78c" },
                    { "c9bbce7e-7372-47f2-80e9-029ce117f245", "777d1907-cd07-4ebd-87f1-83fecac3b78c" }
                });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEKV6fB2SuCHsYOqSmgVuBD/WN8Nhqanfenba47bWgtxIhrT1NPV22nyz1bplmQRE4Q==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEAtKoqwicFfU/IlOyaXpmBz4TnEn2wsg25OCb1uxRg5J4aAX/SCenBkVJLiKWMw7Lw==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "329d3be5-8001-4997-85a9-ebc16be771c2", "252d1809-cd07-4ebd-87d1-83cefac3b78c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c9bbce7e-7372-47f2-80e9-029ce117f245", "777d1907-cd07-4ebd-87f1-83fecac3b78c" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK4iEjyj++AGeqKAKWcYVA/v8KERgPTamVslDnPy7xJ1/FfDt2fM/i6KJ1wxgcqt9g==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAENAWV+UGE7EXQbht8eUe5Ad/fOCthj3tXz7vSy5Q0VPHV+VoEMKXSrCqfGohib2nZQ==");
        }
    }
}

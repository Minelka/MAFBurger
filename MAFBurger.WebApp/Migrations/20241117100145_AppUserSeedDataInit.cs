using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AppUserSeedDataInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "252d1809-cd07-4ebd-87d1-83cefac3b78c", 0, "55c5fc1a-1d71-4de4-b65e-e14eed798ade", "admin@gmail.com", true, false, null, null, "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEObrFtWbhETpTXC7ejDsJYwwqDOFW/D3Mkqv25zteIsO5iOKGqokNonlVLlFYJ2SuA==", null, false, "87b82a5e-69c1-4831-87d0-678b208084ae", false, "admin@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c");
        }
    }
}

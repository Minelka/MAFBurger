using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class CustomerSeedDataInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEK4iEjyj++AGeqKAKWcYVA/v8KERgPTamVslDnPy7xJ1/FfDt2fM/i6KJ1wxgcqt9g==");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "777d1907-cd07-4ebd-87f1-83fecac3b78c", 0, "60c5fc1a-1d71-4de4-b65e-e14eed798ade", "customer@gmail.com", true, false, null, null, "CUSTOMER@GMAIL.COM", "AQAAAAIAAYagAAAAENAWV+UGE7EXQbht8eUe5Ad/fOCthj3tXz7vSy5Q0VPHV+VoEMKXSrCqfGohib2nZQ==", null, false, "50b82a5e-69c1-4831-87d0-678b208084ae", false, "customer@gmail.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEGSWSUTX2a0IqSRqCdpBcqJnyNdJg3okpuZcdWIJpKcDXdsLlNVF0eDpL80Waefe2Q==");
        }
    }
}

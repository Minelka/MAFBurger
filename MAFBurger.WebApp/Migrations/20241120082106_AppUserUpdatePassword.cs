using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class AppUserUpdatePassword : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}

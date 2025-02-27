using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class MenuTableUpdateColums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Beverages",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BurgerExtras",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Sauces",
                table: "Menus",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "252d1809-cd07-4ebd-87d1-83cefac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEJ67PRUw0Zsfzt2saDjtDsMXtIv8yGycQd1e9mjgQ5gv94B0uAPHVR2p2+n690d2Fw==");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "777d1907-cd07-4ebd-87f1-83fecac3b78c",
                column: "PasswordHash",
                value: "AQAAAAIAAYagAAAAEH6vAvPExbu1EWfiaMOB3fvnpU+aq4IXLgeXel8/cENRxoqcySAl98EfcPAAbU52AA==");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Beverages",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "BurgerExtras",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Menus");

            migrationBuilder.DropColumn(
                name: "Sauces",
                table: "Menus");

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
    }
}

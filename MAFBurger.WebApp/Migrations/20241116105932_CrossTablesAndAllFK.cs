using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MAFBurger.WebApp.Migrations
{
    /// <inheritdoc />
    public partial class CrossTablesAndAllFK : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "OrdersExtras",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ExtraId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersExtras", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersExtras_Extras_ExtraId",
                        column: x => x.ExtraId,
                        principalTable: "Extras",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersExtras_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrdersMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    MenuId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrdersMenus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrdersMenus_Menus_MenuId",
                        column: x => x.MenuId,
                        principalTable: "Menus",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrdersMenus_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrdersExtras_ExtraId",
                table: "OrdersExtras",
                column: "ExtraId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersExtras_OrderId",
                table: "OrdersExtras",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersMenus_MenuId",
                table: "OrdersMenus",
                column: "MenuId");

            migrationBuilder.CreateIndex(
                name: "IX_OrdersMenus_OrderId",
                table: "OrdersMenus",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrdersExtras");

            migrationBuilder.DropTable(
                name: "OrdersMenus");
        }
    }
}

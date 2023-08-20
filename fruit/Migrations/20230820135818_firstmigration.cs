using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fruit.Migrations
{
    /// <inheritdoc />
    public partial class firstmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoriesId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InventoryId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "accountsphonenum",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "phonenum",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "accountsphonenum",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "phonenum",
                table: "Contacts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Customer_name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    date = table.Column<int>(type: "int", nullable: false),
                    shippingaddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    itemspurchased = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    quantities = table.Column<int>(type: "int", nullable: false),
                    total = table.Column<int>(type: "int", nullable: false),
                    phonenum = table.Column<int>(type: "int", nullable: false),
                    accountsphonenum = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.ID);
                    table.ForeignKey(
                        name: "FK_order_accounts_accountsphonenum",
                        column: x => x.accountsphonenum,
                        principalTable: "accounts",
                        principalColumn: "phonenum",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_accountsphonenum",
                table: "products",
                column: "accountsphonenum");

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoriesId",
                table: "products",
                column: "CategoriesId");

            migrationBuilder.CreateIndex(
                name: "IX_products_InventoryId",
                table: "products",
                column: "InventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Contacts_accountsphonenum",
                table: "Contacts",
                column: "accountsphonenum");

            migrationBuilder.CreateIndex(
                name: "IX_order_accountsphonenum",
                table: "order",
                column: "accountsphonenum");

            migrationBuilder.AddForeignKey(
                name: "FK_Contacts_accounts_accountsphonenum",
                table: "Contacts",
                column: "accountsphonenum",
                principalTable: "accounts",
                principalColumn: "phonenum",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_accounts_accountsphonenum",
                table: "products",
                column: "accountsphonenum",
                principalTable: "accounts",
                principalColumn: "phonenum",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_category_CategoriesId",
                table: "products",
                column: "CategoriesId",
                principalTable: "category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_products_inventories_InventoryId",
                table: "products",
                column: "InventoryId",
                principalTable: "inventories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Contacts_accounts_accountsphonenum",
                table: "Contacts");

            migrationBuilder.DropForeignKey(
                name: "FK_products_accounts_accountsphonenum",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_category_CategoriesId",
                table: "products");

            migrationBuilder.DropForeignKey(
                name: "FK_products_inventories_InventoryId",
                table: "products");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropIndex(
                name: "IX_products_accountsphonenum",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoriesId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_InventoryId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_Contacts_accountsphonenum",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "CategoriesId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "InventoryId",
                table: "products");

            migrationBuilder.DropColumn(
                name: "accountsphonenum",
                table: "products");

            migrationBuilder.DropColumn(
                name: "phonenum",
                table: "products");

            migrationBuilder.DropColumn(
                name: "accountsphonenum",
                table: "Contacts");

            migrationBuilder.DropColumn(
                name: "phonenum",
                table: "Contacts");
        }
    }
}

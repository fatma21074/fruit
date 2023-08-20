using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace fruit.Migrations
{
    /// <inheritdoc />
    public partial class first : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "phonenum",
                table: "products",
                newName: "Accontphonenum");

            migrationBuilder.RenameColumn(
                name: "phonenum",
                table: "order",
                newName: "Accontphonenum");

            migrationBuilder.RenameColumn(
                name: "phonenum",
                table: "Contacts",
                newName: "Accontphonenum");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Accontphonenum",
                table: "products",
                newName: "phonenum");

            migrationBuilder.RenameColumn(
                name: "Accontphonenum",
                table: "order",
                newName: "phonenum");

            migrationBuilder.RenameColumn(
                name: "Accontphonenum",
                table: "Contacts",
                newName: "phonenum");
        }
    }
}

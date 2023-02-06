using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ChangeLocationForeignKeyToItemId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Items_VendorId",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "VendorId",
                table: "Locations",
                newName: "ItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Items_ItemId",
                table: "Locations",
                column: "ItemId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Locations_Items_ItemId",
                table: "Locations");

            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "Locations",
                newName: "VendorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Locations_Items_VendorId",
                table: "Locations",
                column: "VendorId",
                principalTable: "Items",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

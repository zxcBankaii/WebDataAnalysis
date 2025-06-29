using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebDataAnalysis.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddStatusAndCategory2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Category_CategoryId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_StatusDevice_StatusDeviceId",
                table: "Devices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusDevice",
                table: "StatusDevice");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Category",
                table: "Category");

            migrationBuilder.RenameTable(
                name: "StatusDevice",
                newName: "StatusDevices");

            migrationBuilder.RenameTable(
                name: "Category",
                newName: "Categories");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusDevices",
                table: "StatusDevices",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Categories",
                table: "Categories",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Categories_CategoryId",
                table: "Devices",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_StatusDevices_StatusDeviceId",
                table: "Devices",
                column: "StatusDeviceId",
                principalTable: "StatusDevices",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Devices_Categories_CategoryId",
                table: "Devices");

            migrationBuilder.DropForeignKey(
                name: "FK_Devices_StatusDevices_StatusDeviceId",
                table: "Devices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StatusDevices",
                table: "StatusDevices");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Categories",
                table: "Categories");

            migrationBuilder.RenameTable(
                name: "StatusDevices",
                newName: "StatusDevice");

            migrationBuilder.RenameTable(
                name: "Categories",
                newName: "Category");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StatusDevice",
                table: "StatusDevice",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Category",
                table: "Category",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_Category_CategoryId",
                table: "Devices",
                column: "CategoryId",
                principalTable: "Category",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Devices_StatusDevice_StatusDeviceId",
                table: "Devices",
                column: "StatusDeviceId",
                principalTable: "StatusDevice",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

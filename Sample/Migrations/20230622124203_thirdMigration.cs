using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sample.Migrations
{
    /// <inheritdoc />
    public partial class thirdMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_LenderTypeLocalizations_LenderTypes_LenderTypeId",
                table: "LenderTypeLocalizations");

            migrationBuilder.DropIndex(
                name: "IX_LenderTypeLocalizations_LenderTypeId",
                table: "LenderTypeLocalizations");

            migrationBuilder.DropColumn(
                name: "LenderTypeId",
                table: "LenderTypeLocalizations");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "LenderTypeId",
                table: "LenderTypeLocalizations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_LenderTypeLocalizations_LenderTypeId",
                table: "LenderTypeLocalizations",
                column: "LenderTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_LenderTypeLocalizations_LenderTypes_LenderTypeId",
                table: "LenderTypeLocalizations",
                column: "LenderTypeId",
                principalTable: "LenderTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

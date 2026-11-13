using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class AddSearchSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EnableHideOnSearch",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableSmartDisplay",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnableHideOnSearch",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableSmartDisplay",
                table: "Settings");
        }
    }
}

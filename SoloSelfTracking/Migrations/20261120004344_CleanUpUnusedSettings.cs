using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class CleanUpUnusedSettings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClearClipboardOnValidPaste",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableIframing",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableTradieDetector",
                table: "Settings");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "ClearClipboardOnValidPaste",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableIframing",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableTradieDetector",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }
    }
}

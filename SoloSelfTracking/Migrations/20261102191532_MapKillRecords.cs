using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class MapKillRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MapCurrency",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MapDivCards",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MapMaps",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MapMonsterPackSize",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MapQuantity",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MapRarity",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MapScarabs",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MapCurrency",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "MapDivCards",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "MapMaps",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "MapMonsterPackSize",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "MapQuantity",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "MapRarity",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "MapScarabs",
                table: "KillRecords");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class IncursionRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AreaLevel",
                table: "KillRecords",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "KillRecords",
                type: "TEXT",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ObstructedRooms",
                table: "KillRecords",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OpenRooms",
                table: "KillRecords",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AreaLevel",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "ObstructedRooms",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "OpenRooms",
                table: "KillRecords");
        }
    }
}

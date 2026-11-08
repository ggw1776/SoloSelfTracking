using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class MoveRewardToFateRecord : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reward",
                table: "Fate");

            migrationBuilder.AddColumn<string>(
                name: "Reward",
                table: "KillRecords",
                type: "TEXT",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reward",
                table: "KillRecords");

            migrationBuilder.AddColumn<string>(
                name: "Reward",
                table: "Fate",
                type: "TEXT",
                nullable: false,
                defaultValue: "");
        }
    }
}

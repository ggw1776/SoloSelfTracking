using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalSettingsPages : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "EnableAnomaly",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableBosses",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableExpedition",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableFates",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableHeist",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableIncursion",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableInviteBosses",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableKingsmarchMapping",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableKingsmarchShipping",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableLab",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableMappingStrats",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableNightmares",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableRegexDictionary",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableSanctum",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableSimulacrum",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableStash",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableT0s",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableTimeline",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableUbers",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "EnableWombgifts",
                table: "Settings",
                type: "INTEGER",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EnableAnomaly",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableBosses",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableExpedition",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableFates",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableHeist",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableIncursion",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableInviteBosses",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableKingsmarchMapping",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableKingsmarchShipping",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableLab",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableMappingStrats",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableNightmares",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableRegexDictionary",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableSanctum",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableSimulacrum",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableStash",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableT0s",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableTimeline",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableUbers",
                table: "Settings");

            migrationBuilder.DropColumn(
                name: "EnableWombgifts",
                table: "Settings");
        }
    }
}

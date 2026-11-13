using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class AddMappingInputs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AbyssThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BestiaryThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BetrayalThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BlightThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BreachThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ExpeditionThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IncursionThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LegionThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "RitualThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StrategyUri",
                table: "KillRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "UltimatumThreads",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AbyssThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "BestiaryThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "BetrayalThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "BlightThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "BreachThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "ExpeditionThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "IncursionThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "LegionThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "RitualThreads",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "StrategyUri",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "UltimatumThreads",
                table: "KillRecords");
        }
    }
}

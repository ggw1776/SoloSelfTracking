using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class Timers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Deaths",
                table: "SimulacrumRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ElapsedTime",
                table: "SimulacrumRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<int>(
                name: "Deaths",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "ElapsedTime",
                table: "KillRecords",
                type: "TEXT",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Deaths",
                table: "SimulacrumRecords");

            migrationBuilder.DropColumn(
                name: "ElapsedTime",
                table: "SimulacrumRecords");

            migrationBuilder.DropColumn(
                name: "Deaths",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "ElapsedTime",
                table: "KillRecords");
        }
    }
}

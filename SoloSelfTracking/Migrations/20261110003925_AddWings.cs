using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class AddWings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Wings",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Wings",
                table: "KillRecords");
        }
    }
}

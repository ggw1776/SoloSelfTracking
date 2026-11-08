using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class AddAdditionalMapModSupport : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MapAtlasDrops",
                table: "KillRecords",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MapAtlasDrops",
                table: "KillRecords");
        }
    }
}

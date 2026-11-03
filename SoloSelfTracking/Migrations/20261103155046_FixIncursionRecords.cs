using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class FixIncursionRecords : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Discriminator",
                table: "KillRecords",
                newName: "RecordType");

            migrationBuilder.Sql("""
            UPDATE KillRecords
            SET RecordType = 'KillRecord'
            WHERE RecordType IS NULL OR RecordType = '';
            """);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "RecordType",
                table: "KillRecords",
                newName: "Discriminator");
        }
    }
}

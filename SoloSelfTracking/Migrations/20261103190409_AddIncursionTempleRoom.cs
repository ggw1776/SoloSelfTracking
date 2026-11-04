using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class AddIncursionTempleRoom : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ObstructedRooms",
                table: "KillRecords");

            migrationBuilder.DropColumn(
                name: "OpenRooms",
                table: "KillRecords");

            migrationBuilder.CreateTable(
                name: "TempleRoom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Tier = table.Column<int>(type: "INTEGER", nullable: false),
                    IncursionRecordId = table.Column<int>(type: "INTEGER", nullable: true),
                    IncursionRecordId1 = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TempleRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TempleRoom_KillRecords_IncursionRecordId",
                        column: x => x.IncursionRecordId,
                        principalTable: "KillRecords",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_TempleRoom_KillRecords_IncursionRecordId1",
                        column: x => x.IncursionRecordId1,
                        principalTable: "KillRecords",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TempleRoom_IncursionRecordId",
                table: "TempleRoom",
                column: "IncursionRecordId");

            migrationBuilder.CreateIndex(
                name: "IX_TempleRoom_IncursionRecordId1",
                table: "TempleRoom",
                column: "IncursionRecordId1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TempleRoom");

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
    }
}

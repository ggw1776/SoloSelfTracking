using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SoloSelfTracking.Migrations
{
    /// <inheritdoc />
    public partial class IncursionTempleRoomRemoveCascade : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TempleRoom_KillRecords_IncursionRecordId",
                table: "TempleRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_TempleRoom_KillRecords_IncursionRecordId1",
                table: "TempleRoom");

            migrationBuilder.AddForeignKey(
                name: "FK_TempleRoom_KillRecords_IncursionRecordId",
                table: "TempleRoom",
                column: "IncursionRecordId",
                principalTable: "KillRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TempleRoom_KillRecords_IncursionRecordId1",
                table: "TempleRoom",
                column: "IncursionRecordId1",
                principalTable: "KillRecords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TempleRoom_KillRecords_IncursionRecordId",
                table: "TempleRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_TempleRoom_KillRecords_IncursionRecordId1",
                table: "TempleRoom");

            migrationBuilder.AddForeignKey(
                name: "FK_TempleRoom_KillRecords_IncursionRecordId",
                table: "TempleRoom",
                column: "IncursionRecordId",
                principalTable: "KillRecords",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_TempleRoom_KillRecords_IncursionRecordId1",
                table: "TempleRoom",
                column: "IncursionRecordId1",
                principalTable: "KillRecords",
                principalColumn: "Id");
        }
    }
}

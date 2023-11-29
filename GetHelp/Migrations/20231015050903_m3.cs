using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetHelp.Migrations
{
    /// <inheritdoc />
    public partial class m3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Level",
                value: 1);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Level",
                value: 0);
        }
    }
}

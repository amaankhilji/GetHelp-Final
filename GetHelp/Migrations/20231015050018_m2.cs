          using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GetHelp.Migrations
{
    /// <inheritdoc />
    public partial class m2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Level",
                table: "Problem",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "Id",
                keyValue: 1,
                column: "Level",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Problem",
                keyColumn: "Id",
                keyValue: 2,
                column: "Level",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Level",
                table: "Problem");
        }
    }
}

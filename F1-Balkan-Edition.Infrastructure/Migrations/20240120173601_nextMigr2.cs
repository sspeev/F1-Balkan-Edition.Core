using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1_Balkan_Edition.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class nextMigr2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                comment: "The name of the racer");
        }
    }
}

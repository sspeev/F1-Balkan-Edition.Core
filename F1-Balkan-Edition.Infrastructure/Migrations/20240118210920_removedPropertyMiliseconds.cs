using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1_Balkan_Edition.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class removedPropertyMiliseconds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Miliseconds",
                table: "Users");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "Miliseconds",
                table: "Users",
                type: "bigint",
                nullable: false,
                defaultValue: 0L,
                comment: "Lap time in miliseconds");
        }
    }
}

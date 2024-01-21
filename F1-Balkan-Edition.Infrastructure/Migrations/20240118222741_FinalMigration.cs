using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1_Balkan_Edition.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FinalMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rank",
                table: "Users");

            migrationBuilder.AddColumn<string>(
                name: "CarBrand",
                table: "Cars",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "",
                comment: "The brand of the car");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CarBrand",
                table: "Cars");

            migrationBuilder.AddColumn<int>(
                name: "Rank",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                comment: "Property which will be used in the ranking to sort the users");
        }
    }
}

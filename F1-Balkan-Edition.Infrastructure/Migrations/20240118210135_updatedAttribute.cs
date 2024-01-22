using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1_Balkan_Edition.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updatedAttribute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Track",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                comment: "This is the track where the lap has been set",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldComment: "This is the track where the lap has been set");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Track",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                comment: "This is the track where the lap has been set",
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100,
                oldComment: "This is the track where the lap has been set");
        }
    }
}

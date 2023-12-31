using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace F1_Balkan_Edition.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identificator of the car")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The model of the car"),
                    Power = table.Column<string>(type: "nvarchar(max)", nullable: false, comment: "The horsepower of the car"),
                    UserId = table.Column<int>(type: "int", nullable: false, comment: "Identificator of the user")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false, comment: "Identificator of the user")
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LapTime = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false, comment: "Lap time formatted: 00:00:00"),
                    Miliseconds = table.Column<long>(type: "bigint", nullable: false, comment: "Lap time in miliseconds"),
                    Rank = table.Column<int>(type: "int", nullable: false, comment: "Property which will be used in the ranking to sort the users"),
                    CarId = table.Column<int>(type: "int", nullable: false, comment: "Identificator of the car")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Cars_CarId",
                        column: x => x.CarId,
                        principalTable: "Cars",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cars_UserId",
                table: "Cars",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_CarId",
                table: "Users",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cars_Users_UserId",
                table: "Cars");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilkTeaManagement.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddShiftsAndModifyUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "HourlySalary",
                table: "AspNetUsers",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Shifts",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    EmployeeId = table.Column<string>(type: "varchar(50)", nullable: false),
                    Time = table.Column<int>(type: "int", nullable: false),
                    Mo = table.Column<bool>(type: "bit", nullable: false),
                    Tu = table.Column<bool>(type: "bit", nullable: false),
                    We = table.Column<bool>(type: "bit", nullable: false),
                    Th = table.Column<bool>(type: "bit", nullable: false),
                    Fr = table.Column<bool>(type: "bit", nullable: false),
                    Sa = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shifts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shifts_AspNetUsers_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shifts_EmployeeId",
                table: "Shifts",
                column: "EmployeeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Shifts");

            migrationBuilder.DropColumn(
                name: "HourlySalary",
                table: "AspNetUsers");
        }
    }
}

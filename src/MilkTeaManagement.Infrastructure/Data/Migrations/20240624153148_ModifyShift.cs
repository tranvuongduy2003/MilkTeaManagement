using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MilkTeaManagement.Infrastructure.Data.Migrations
{
    /// <inheritdoc />
    public partial class ModifyShift : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Su",
                table: "Shifts",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Su",
                table: "Shifts");
        }
    }
}

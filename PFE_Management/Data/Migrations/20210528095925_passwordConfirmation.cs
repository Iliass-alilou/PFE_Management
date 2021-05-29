using Microsoft.EntityFrameworkCore.Migrations;

namespace PFE_Management.Data.Migrations
{
    public partial class passwordConfirmation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PasswordConfirmation",
                table: "Instructor",
                maxLength: 100,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PasswordConfirmation",
                table: "Instructor");
        }
    }
}

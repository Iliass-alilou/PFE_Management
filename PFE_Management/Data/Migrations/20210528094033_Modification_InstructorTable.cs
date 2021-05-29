using Microsoft.EntityFrameworkCore.Migrations;

namespace PFE_Management.Data.Migrations
{
    public partial class Modification_InstructorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Instructor",
                maxLength: 254,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Instructor",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "etatAccount",
                table: "Instructor",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Email",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Instructor");

            migrationBuilder.DropColumn(
                name: "etatAccount",
                table: "Instructor");
        }
    }
}

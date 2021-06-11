using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PFE_Management.Data.Migrations
{
    public partial class tableStage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Stage",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: false),
                    Prenom = table.Column<string>(nullable: false),
                    Genre = table.Column<string>(nullable: false),
                    CIN = table.Column<string>(nullable: false),
                    CNE = table.Column<string>(nullable: false),
                    Email = table.Column<string>(nullable: false),
                    DateNaissance = table.Column<DateTime>(nullable: false),
                    Annee = table.Column<string>(nullable: false),
                    Telephone = table.Column<int>(nullable: false),
                    OrganismeDacceuil = table.Column<string>(nullable: false),
                    EncadrantExterne = table.Column<string>(nullable: true),
                    EmailEncadrantExterne = table.Column<string>(nullable: false),
                    TelephoneEncadrantExterne = table.Column<int>(nullable: false),
                    PosteEncadrantExterne = table.Column<string>(nullable: false),
                    TitreStage = table.Column<string>(nullable: false),
                    DescriptionStage = table.Column<string>(nullable: true),
                    VilleStage = table.Column<string>(nullable: false),
                    PaysStage = table.Column<string>(nullable: false),
                    EtatStage = table.Column<bool>(nullable: false),
                    DateDebutStage = table.Column<DateTime>(nullable: false),
                    DateFinStage = table.Column<DateTime>(nullable: false),
                    DepartmentID = table.Column<int>(nullable: false),
                    InstructorID = table.Column<int>(nullable: false),
                    StudentIDhashed = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Stage", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Stage_Department_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "Department",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Stage_Instructor_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructor",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Stage_DepartmentID",
                table: "Stage",
                column: "DepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Stage_InstructorID",
                table: "Stage",
                column: "InstructorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Stage");
        }
    }
}

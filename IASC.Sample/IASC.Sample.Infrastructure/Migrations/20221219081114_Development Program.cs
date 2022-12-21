using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IASC.Sample.Infrastructure.Migrations
{
    public partial class DevelopmentProgram : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competencies_CompetencyModels_CompetencyModelId",
                table: "Competencies");

            migrationBuilder.AlterColumn<int>(
                name: "CompetencyModelId",
                table: "Competencies",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateTable(
                name: "DevelopmentProgram",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Goal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    CurrentPostId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopmentProgram", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevelopmentProgram_Employees_EmployeeId",
                        column: x => x.EmployeeId,
                        principalTable: "Employees",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DevelopmentProgram_Posts_CurrentPostId",
                        column: x => x.CurrentPostId,
                        principalTable: "Posts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DevelopmentProgramItem",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CurrentScore = table.Column<double>(type: "float", nullable: false),
                    Program = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpectedLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedAppearance = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EfficiencyValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExecutionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false),
                    EvaluationMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AnnouncementDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DevelopmentProgramId = table.Column<int>(type: "int", nullable: false),
                    CompetencyId = table.Column<int>(type: "int", nullable: false),
                    CreationTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModificationTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DevelopmentProgramItem", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DevelopmentProgramItem_Competencies_CompetencyId",
                        column: x => x.CompetencyId,
                        principalTable: "Competencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DevelopmentProgramItem_DevelopmentProgram_DevelopmentProgramId",
                        column: x => x.DevelopmentProgramId,
                        principalTable: "DevelopmentProgram",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentProgram_CurrentPostId",
                table: "DevelopmentProgram",
                column: "CurrentPostId");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentProgram_EmployeeId",
                table: "DevelopmentProgram",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentProgramItem_CompetencyId",
                table: "DevelopmentProgramItem",
                column: "CompetencyId");

            migrationBuilder.CreateIndex(
                name: "IX_DevelopmentProgramItem_DevelopmentProgramId",
                table: "DevelopmentProgramItem",
                column: "DevelopmentProgramId");

            migrationBuilder.AddForeignKey(
                name: "FK_Competencies_CompetencyModels_CompetencyModelId",
                table: "Competencies",
                column: "CompetencyModelId",
                principalTable: "CompetencyModels",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Competencies_CompetencyModels_CompetencyModelId",
                table: "Competencies");

            migrationBuilder.DropTable(
                name: "DevelopmentProgramItem");

            migrationBuilder.DropTable(
                name: "DevelopmentProgram");

            migrationBuilder.AlterColumn<int>(
                name: "CompetencyModelId",
                table: "Competencies",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Competencies_CompetencyModels_CompetencyModelId",
                table: "Competencies",
                column: "CompetencyModelId",
                principalTable: "CompetencyModels",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

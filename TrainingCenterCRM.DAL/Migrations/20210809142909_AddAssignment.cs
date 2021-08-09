using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TrainingCenterCRM.DAL.Migrations
{
    public partial class AddAssignment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StudentToGroupAssignments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<int>(type: "int", nullable: false),
                    AssignmentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Result = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentToGroupAssignments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentToGroupAssignments_Groups_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Groups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentToGroupAssignments_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_StudentToGroupAssignments_GroupId",
                table: "StudentToGroupAssignments",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentToGroupAssignments_StudentId",
                table: "StudentToGroupAssignments",
                column: "StudentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StudentToGroupAssignments");
        }
    }
}

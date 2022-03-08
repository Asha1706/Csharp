using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFMVC.Migrations
{
    public partial class ManyToMany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "SubjectTeacher",
                columns: table => new
                {
                    SubjectTeacherTeacherId = table.Column<int>(type: "int", nullable: false),
                    TeacherSubjectSubjectId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubjectTeacher", x => new { x.SubjectTeacherTeacherId, x.TeacherSubjectSubjectId });
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Subjects_TeacherSubjectSubjectId",
                        column: x => x.TeacherSubjectSubjectId,
                        principalTable: "Subjects",
                        principalColumn: "SubjectId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SubjectTeacher_Teachers_SubjectTeacherTeacherId",
                        column: x => x.SubjectTeacherTeacherId,
                        principalTable: "Teachers",
                        principalColumn: "TeacherId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_SubjectTeacher_TeacherSubjectSubjectId",
                table: "SubjectTeacher",
                column: "TeacherSubjectSubjectId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SubjectTeacher");
        }
    }
}

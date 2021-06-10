using Microsoft.EntityFrameworkCore.Migrations;

namespace LearningEFProject.Migrations
{
    public partial class InitializeskillsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "skills",
                columns: table => new
                {
                    SkillName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SkillDescription = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skills", x => x.SkillName);
                });

            migrationBuilder.InsertData(
                table: "skills",
                columns: new[] { "SkillName", "SkillDescription" },
                values: new object[] { "Java", "OOPS" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "skills");
        }
    }
}

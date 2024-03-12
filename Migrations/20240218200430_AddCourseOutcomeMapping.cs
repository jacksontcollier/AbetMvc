using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbetMvc.Migrations
{
    /// <inheritdoc />
    public partial class AddCourseOutcomeMapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce09244d-3eae-4f75-b60c-5a6aee4a6025");

            migrationBuilder.CreateTable(
                name: "CourseOutcomeMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CourseId = table.Column<string>(type: "TEXT", nullable: true),
                    OutcomeId = table.Column<int>(type: "INTEGER", nullable: true),
                    Major = table.Column<int>(type: "INTEGER", nullable: true),
                    Semester = table.Column<int>(type: "INTEGER", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CourseOutcomeMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CourseOutcomeMappings_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CourseOutcomeMappings_Outcomes_OutcomeId",
                        column: x => x.OutcomeId,
                        principalTable: "Outcomes",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c6c78390-84da-4ea1-a2d2-9a48c9fda596", 0, "b0813a24-fd18-46cc-a901-08f35aca4937", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "7e2a7c12-8893-4e93-ac9b-f88730306c28", false, "gwashington" });

            migrationBuilder.CreateIndex(
                name: "IX_CourseOutcomeMappings_CourseId",
                table: "CourseOutcomeMappings",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_CourseOutcomeMappings_OutcomeId",
                table: "CourseOutcomeMappings",
                column: "OutcomeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CourseOutcomeMappings");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c6c78390-84da-4ea1-a2d2-9a48c9fda596");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ce09244d-3eae-4f75-b60c-5a6aee4a6025", 0, "f2193949-8287-41f5-a98b-bd5ba8a0cd5a", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "77ab15ff-84ea-46d5-981a-b1bd14378f95", false, "gwashington" });
        }
    }
}

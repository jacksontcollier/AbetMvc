using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbetMvc.Migrations
{
    /// <inheritdoc />
    public partial class CreateOutcomeResultModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb7d3964-f9f0-4c28-a841-f064d7adee98");

            migrationBuilder.CreateTable(
                name: "OutcomeResults",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    SectionId = table.Column<int>(type: "INTEGER", nullable: true),
                    OutcomeId = table.Column<int>(type: "INTEGER", nullable: true),
                    Major = table.Column<int>(type: "INTEGER", nullable: false),
                    PerformanceLevel = table.Column<int>(type: "INTEGER", nullable: false),
                    NumberOfStudents = table.Column<short>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutcomeResults", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OutcomeResults_Outcomes_OutcomeId",
                        column: x => x.OutcomeId,
                        principalTable: "Outcomes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_OutcomeResults_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "ce09244d-3eae-4f75-b60c-5a6aee4a6025", 0, "f2193949-8287-41f5-a98b-bd5ba8a0cd5a", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "77ab15ff-84ea-46d5-981a-b1bd14378f95", false, "gwashington" });

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeResults_SectionId",
                table: "OutcomeResults",
                column: "SectionId"
            );

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeResults_OutcomeId",
                table: "OutcomeResults",
                column: "OutcomeId");

            migrationBuilder.CreateIndex(
                name: "IX_OutcomeResults_SectionId_OutcomeId_PerformanceLevel_Major",
                table: "OutcomeResults",
                columns: new[] { "SectionId", "OutcomeId", "PerformanceLevel", "Major" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OutcomeResults");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce09244d-3eae-4f75-b60c-5a6aee4a6025");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eb7d3964-f9f0-4c28-a841-f064d7adee98", 0, "6f6bde8a-07e8-4e42-a4ba-22216684e836", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "b390b8a4-85fe-4fd2-a31a-2dbec5d1907c", false, "gwashington" });
        }
    }
}

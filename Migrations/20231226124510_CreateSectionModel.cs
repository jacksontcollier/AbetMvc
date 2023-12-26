using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbetMvc.Migrations
{
    /// <inheritdoc />
    public partial class CreateSectionModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8197ef96-40c1-4f05-ace8-363e096227e6");

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    InstructorId = table.Column<string>(type: "TEXT", nullable: true),
                    CourseId = table.Column<string>(type: "TEXT", nullable: true),
                    Semester = table.Column<int>(type: "INTEGER", nullable: true),
                    Year = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_AspNetUsers_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Sections_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8689f9bd-b070-481f-b320-b4a6407f03ed", 0, "673b559d-5724-4188-b0ad-c08ac3ea17b5", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "e67b8714-6faa-4876-bdfb-37b7a164da01", false, "gwashington" });

            migrationBuilder.CreateIndex(
                name: "IX_Sections_CourseId",
                table: "Sections",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_InstructorId",
                table: "Sections",
                column: "InstructorId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8689f9bd-b070-481f-b320-b4a6407f03ed");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8197ef96-40c1-4f05-ace8-363e096227e6", 0, "d0b687e0-3e72-4e36-a411-1c1708beab23", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "6b39e8ef-6771-4fe1-accb-e08319a1206f", false, "gwashington" });
        }
    }
}

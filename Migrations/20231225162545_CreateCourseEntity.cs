using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbetMvc.Migrations
{
    /// <inheritdoc />
    public partial class CreateCourseEntity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Title = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8197ef96-40c1-4f05-ace8-363e096227e6", 0, "d0b687e0-3e72-4e36-a411-1c1708beab23", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "6b39e8ef-6771-4fe1-accb-e08319a1206f", false, "gwashington" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8197ef96-40c1-4f05-ace8-363e096227e6");
        }
    }
}

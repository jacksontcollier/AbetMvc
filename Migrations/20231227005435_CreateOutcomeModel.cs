using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AbetMvc.Migrations
{
    /// <inheritdoc />
    public partial class CreateOutcomeModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8689f9bd-b070-481f-b320-b4a6407f03ed");

            migrationBuilder.CreateTable(
                name: "Outcomes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Number = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Major = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Outcomes", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "eb7d3964-f9f0-4c28-a841-f064d7adee98", 0, "6f6bde8a-07e8-4e42-a4ba-22216684e836", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "b390b8a4-85fe-4fd2-a31a-2dbec5d1907c", false, "gwashington" });

            migrationBuilder.CreateIndex(
                name: "IX_Outcomes_Number_Major",
                table: "Outcomes",
                columns: new[] { "Number", "Major" },
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Outcomes");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eb7d3964-f9f0-4c28-a841-f064d7adee98");

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8689f9bd-b070-481f-b320-b4a6407f03ed", 0, "673b559d-5724-4188-b0ad-c08ac3ea17b5", "gwashington@fakemail.com", false, null, null, false, null, null, null, null, "1234567890", false, "e67b8714-6faa-4876-bdfb-37b7a164da01", false, "gwashington" });
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

namespace IdentityByExamples.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "36d4043e-63d4-4463-b7a0-64a3c18faf2e", "fc1a9ad9-fcb3-43f0-a55d-fddf360661c6", "Visitor", "VISITOR" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "42984ff0-f4ce-4882-8e87-252678dbba71", "44e41e2c-4fb5-4017-b5e1-1cf0ae865631", "Administrator", "ADMINISTRATOR" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "36d4043e-63d4-4463-b7a0-64a3c18faf2e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "42984ff0-f4ce-4882-8e87-252678dbba71");
        }
    }
}

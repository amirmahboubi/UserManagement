using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Server.Infrastructure.Persistence.Migrations
{
    public partial class useradmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "IsActive", "LastName", "Mobile", "Password", "UserName" },
                values: new object[] { 1, "Admin", true, "AdminZadeh", "+989171112233", "admin*963", "Admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);
        }
    }
}

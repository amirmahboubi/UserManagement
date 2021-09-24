using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Server.Infrastructure.Persistence.Migrations
{
    public partial class userdetailadmin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "UserDetailId", "Address", "BirthDate", "Email", "UserId" },
                values: new object[] { 1, "Iran", new DateTime(2001, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "admin@admin.com", 1 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 1);
        }
    }
}

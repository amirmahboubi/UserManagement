using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Server.Infrastructure.Persistence.Migrations
{
    public partial class newuserseed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2001, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1995, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1992, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1998, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1993, 9, 24, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "IsActive", "LastName", "Mobile", "Password", "UserName" },
                values: new object[] { 6, "Sara", true, "Saravi", "+989121114433", "sara*963", "s.saravi" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 1,
                column: "BirthDate",
                value: new DateTime(2001, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 2,
                column: "BirthDate",
                value: new DateTime(1995, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 3,
                column: "BirthDate",
                value: new DateTime(1992, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 4,
                column: "BirthDate",
                value: new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));

            migrationBuilder.UpdateData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 5,
                column: "BirthDate",
                value: new DateTime(1993, 9, 23, 0, 0, 0, 0, DateTimeKind.Local));
        }
    }
}

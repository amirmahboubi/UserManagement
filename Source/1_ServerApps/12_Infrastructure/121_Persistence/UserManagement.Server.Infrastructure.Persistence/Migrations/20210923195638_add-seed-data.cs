using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace UserManagement.Server.Infrastructure.Persistence.Migrations
{
    public partial class addseeddata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FirstName", "IsActive", "LastName", "Mobile", "Password", "UserName" },
                values: new object[,]
                {
                    { 2, "Amir", true, "Mahboubi", "+989227609862", "amir*963", "a.mahboubi" },
                    { 3, "Amin", false, "Amini", "+989121112233", "amin*963", "a.amini" },
                    { 4, "Amir", false, "Amiri", "+989121112233", "amiri*963", "a.amiri" },
                    { 5, "Mina", true, "Minaee", "+989121112233", "mina*963", "m.minaee" }
                });

            migrationBuilder.InsertData(
                table: "UserDetails",
                columns: new[] { "UserDetailId", "Address", "BirthDate", "Email", "UserId" },
                values: new object[,]
                {
                    { 2, "Shiraz", new DateTime(1995, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "AmirMahboubi@outlook.com", 2 },
                    { 3, "Tabriz", new DateTime(1992, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tabriz@admin.com", 3 },
                    { 4, "Tehran", new DateTime(1998, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Tehran@admin.com", 4 },
                    { 5, "Shiraz", new DateTime(1993, 9, 23, 0, 0, 0, 0, DateTimeKind.Local), "Shiraz@admin.com", 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "UserDetails",
                keyColumn: "UserDetailId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5);
        }
    }
}

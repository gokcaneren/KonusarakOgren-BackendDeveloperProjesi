using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace KonusarakOgren.Repository.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69cc14e6-d675-4d38-a29f-888d656131fb", "efc25dc9-6f18-4737-80e9-65ead32e220d", "Admin", "ADMIN" },
                    { "9bad7b6e-a6c2-444b-86e4-bdf81a64c789", "8eda7dba-a8b6-4315-9fea-3ff67f57c761", "SysAdmin", "SYSADMIN" },
                    { "ce9a6646-08b2-40a6-baa7-f37a5b4225f2", "cb02b19f-abd7-478f-a7ee-bd048a838edf", "Customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 20, 26, 26, 476, DateTimeKind.Local).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 20, 26, 26, 476, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 20, 26, 26, 476, DateTimeKind.Local).AddTicks(9047));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 20, 26, 26, 476, DateTimeKind.Local).AddTicks(9048));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69cc14e6-d675-4d38-a29f-888d656131fb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bad7b6e-a6c2-444b-86e4-bdf81a64c789");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce9a6646-08b2-40a6-baa7-f37a5b4225f2");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 20, 16, 50, 989, DateTimeKind.Local).AddTicks(2943));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 20, 16, 50, 989, DateTimeKind.Local).AddTicks(2951));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 20, 16, 50, 989, DateTimeKind.Local).AddTicks(2952));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 9, 5, 20, 16, 50, 989, DateTimeKind.Local).AddTicks(2953));
        }
    }
}

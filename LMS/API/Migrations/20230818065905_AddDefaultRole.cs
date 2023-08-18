using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class AddDefaultRole : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "tb_m_roles",
                columns: new[] { "guid", "created_date", "modified_date", "name" },
                values: new object[] { new Guid("24706f51-2651-4cd2-9ca0-c8e510969b7d"), new DateTime(2023, 8, 18, 13, 59, 5, 126, DateTimeKind.Local).AddTicks(1690), new DateTime(2023, 8, 18, 13, 59, 5, 126, DateTimeKind.Local).AddTicks(1690), "Admin" });

            migrationBuilder.InsertData(
                table: "tb_m_roles",
                columns: new[] { "guid", "created_date", "modified_date", "name" },
                values: new object[] { new Guid("4016bbf3-5514-4478-97f8-85a3baef09c2"), new DateTime(2023, 8, 18, 13, 59, 5, 126, DateTimeKind.Local).AddTicks(1687), new DateTime(2023, 8, 18, 13, 59, 5, 126, DateTimeKind.Local).AddTicks(1688), "Student" });

            migrationBuilder.InsertData(
                table: "tb_m_roles",
                columns: new[] { "guid", "created_date", "modified_date", "name" },
                values: new object[] { new Guid("5eeda544-ee8f-495d-9366-6c04e0904a5c"), new DateTime(2023, 8, 18, 13, 59, 5, 126, DateTimeKind.Local).AddTicks(1674), new DateTime(2023, 8, 18, 13, 59, 5, 126, DateTimeKind.Local).AddTicks(1684), "Teacher" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "tb_m_roles",
                keyColumn: "guid",
                keyValue: new Guid("24706f51-2651-4cd2-9ca0-c8e510969b7d"));

            migrationBuilder.DeleteData(
                table: "tb_m_roles",
                keyColumn: "guid",
                keyValue: new Guid("4016bbf3-5514-4478-97f8-85a3baef09c2"));

            migrationBuilder.DeleteData(
                table: "tb_m_roles",
                keyColumn: "guid",
                keyValue: new Guid("5eeda544-ee8f-495d-9366-6c04e0904a5c"));
        }
    }
}

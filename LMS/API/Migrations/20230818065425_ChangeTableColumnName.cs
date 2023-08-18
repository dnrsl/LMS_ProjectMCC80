using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    public partial class ChangeTableColumnName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_account_roles_tb_m_accounts_account_guid",
                table: "tb_m_account_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_m_account_roles_tb_m_roles_role_guid",
                table: "tb_m_account_roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_m_account_roles",
                table: "tb_m_account_roles");

            migrationBuilder.RenameTable(
                name: "tb_m_account_roles",
                newName: "tb_tr_account_roles");

            migrationBuilder.RenameIndex(
                name: "IX_tb_m_account_roles_role_guid",
                table: "tb_tr_account_roles",
                newName: "IX_tb_tr_account_roles_role_guid");

            migrationBuilder.RenameIndex(
                name: "IX_tb_m_account_roles_account_guid",
                table: "tb_tr_account_roles",
                newName: "IX_tb_tr_account_roles_account_guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_tr_account_roles",
                table: "tb_tr_account_roles",
                column: "guid");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_account_roles_tb_m_accounts_account_guid",
                table: "tb_tr_account_roles",
                column: "account_guid",
                principalTable: "tb_m_accounts",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_tr_account_roles_tb_m_roles_role_guid",
                table: "tb_tr_account_roles",
                column: "role_guid",
                principalTable: "tb_m_roles",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_account_roles_tb_m_accounts_account_guid",
                table: "tb_tr_account_roles");

            migrationBuilder.DropForeignKey(
                name: "FK_tb_tr_account_roles_tb_m_roles_role_guid",
                table: "tb_tr_account_roles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_tr_account_roles",
                table: "tb_tr_account_roles");

            migrationBuilder.RenameTable(
                name: "tb_tr_account_roles",
                newName: "tb_m_account_roles");

            migrationBuilder.RenameIndex(
                name: "IX_tb_tr_account_roles_role_guid",
                table: "tb_m_account_roles",
                newName: "IX_tb_m_account_roles_role_guid");

            migrationBuilder.RenameIndex(
                name: "IX_tb_tr_account_roles_account_guid",
                table: "tb_m_account_roles",
                newName: "IX_tb_m_account_roles_account_guid");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_m_account_roles",
                table: "tb_m_account_roles",
                column: "guid");

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_account_roles_tb_m_accounts_account_guid",
                table: "tb_m_account_roles",
                column: "account_guid",
                principalTable: "tb_m_accounts",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_tb_m_account_roles_tb_m_roles_role_guid",
                table: "tb_m_account_roles",
                column: "role_guid",
                principalTable: "tb_m_roles",
                principalColumn: "guid",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

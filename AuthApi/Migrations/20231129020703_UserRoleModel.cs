using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AuthApi.Migrations
{
    public partial class UserRoleModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ROLES_USERS_UserId",
                table: "ROLES");

            migrationBuilder.DropIndex(
                name: "IX_ROLES_UserId",
                table: "ROLES");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "ROLES");

            migrationBuilder.AddColumn<long>(
                name: "phone_number",
                table: "USERS",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "USERS_ROLES",
                columns: table => new
                {
                    user_id = table.Column<long>(type: "bigint", nullable: false),
                    role_id = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_USERS_ROLES", x => new { x.user_id, x.role_id });
                    table.ForeignKey(
                        name: "FK_USERS_ROLES_ROLES_role_id",
                        column: x => x.role_id,
                        principalTable: "ROLES",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_USERS_ROLES_USERS_user_id",
                        column: x => x.user_id,
                        principalTable: "USERS",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_USERS_ROLES_role_id",
                table: "USERS_ROLES",
                column: "role_id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "USERS_ROLES");

            migrationBuilder.DropColumn(
                name: "phone_number",
                table: "USERS");

            migrationBuilder.AddColumn<long>(
                name: "UserId",
                table: "ROLES",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_ROLES_UserId",
                table: "ROLES",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_ROLES_USERS_UserId",
                table: "ROLES",
                column: "UserId",
                principalTable: "USERS",
                principalColumn: "Id");
        }
    }
}

using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Students_MVC.Data.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims");

            migrationBuilder.RenameTable(
                name: "AspNetUserTokens",
                newName: "MappingListUserTokens");

            migrationBuilder.RenameTable(
                name: "AspNetUserRoles",
                newName: "MappingListUserRoles");

            migrationBuilder.RenameTable(
                name: "AspNetUserLogins",
                newName: "MappingListUserLogins");

            migrationBuilder.RenameTable(
                name: "AspNetUserClaims",
                newName: "MappingListUserClaims");

            migrationBuilder.RenameTable(
                name: "AspNetRoles",
                newName: "MappingListRoles");

            migrationBuilder.RenameTable(
                name: "AspNetRoleClaims",
                newName: "MappingListRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "MappingListUserRoles",
                newName: "IX_MappingListUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "MappingListUserLogins",
                newName: "IX_MappingListUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "MappingListUserClaims",
                newName: "IX_MappingListUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "MappingListRoleClaims",
                newName: "IX_MappingListRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingListUserTokens",
                table: "MappingListUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingListUserRoles",
                table: "MappingListUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingListUserLogins",
                table: "MappingListUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingListUserClaims",
                table: "MappingListUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingListRoles",
                table: "MappingListRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MappingListRoleClaims",
                table: "MappingListRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_MappingListRoleClaims_MappingListRoles_RoleId",
                table: "MappingListRoleClaims",
                column: "RoleId",
                principalTable: "MappingListRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingListUserClaims_AspNetUsers_UserId",
                table: "MappingListUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingListUserLogins_AspNetUsers_UserId",
                table: "MappingListUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingListUserRoles_AspNetUsers_UserId",
                table: "MappingListUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingListUserRoles_MappingListRoles_RoleId",
                table: "MappingListUserRoles",
                column: "RoleId",
                principalTable: "MappingListRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MappingListUserTokens_AspNetUsers_UserId",
                table: "MappingListUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MappingListRoleClaims_MappingListRoles_RoleId",
                table: "MappingListRoleClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingListUserClaims_AspNetUsers_UserId",
                table: "MappingListUserClaims");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingListUserLogins_AspNetUsers_UserId",
                table: "MappingListUserLogins");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingListUserRoles_AspNetUsers_UserId",
                table: "MappingListUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingListUserRoles_MappingListRoles_RoleId",
                table: "MappingListUserRoles");

            migrationBuilder.DropForeignKey(
                name: "FK_MappingListUserTokens_AspNetUsers_UserId",
                table: "MappingListUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingListUserTokens",
                table: "MappingListUserTokens");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingListUserRoles",
                table: "MappingListUserRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingListUserLogins",
                table: "MappingListUserLogins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingListUserClaims",
                table: "MappingListUserClaims");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingListRoles",
                table: "MappingListRoles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MappingListRoleClaims",
                table: "MappingListRoleClaims");

            migrationBuilder.RenameTable(
                name: "MappingListUserTokens",
                newName: "AspNetUserTokens");

            migrationBuilder.RenameTable(
                name: "MappingListUserRoles",
                newName: "AspNetUserRoles");

            migrationBuilder.RenameTable(
                name: "MappingListUserLogins",
                newName: "AspNetUserLogins");

            migrationBuilder.RenameTable(
                name: "MappingListUserClaims",
                newName: "AspNetUserClaims");

            migrationBuilder.RenameTable(
                name: "MappingListRoles",
                newName: "AspNetRoles");

            migrationBuilder.RenameTable(
                name: "MappingListRoleClaims",
                newName: "AspNetRoleClaims");

            migrationBuilder.RenameIndex(
                name: "IX_MappingListUserRoles_RoleId",
                table: "AspNetUserRoles",
                newName: "IX_AspNetUserRoles_RoleId");

            migrationBuilder.RenameIndex(
                name: "IX_MappingListUserLogins_UserId",
                table: "AspNetUserLogins",
                newName: "IX_AspNetUserLogins_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MappingListUserClaims_UserId",
                table: "AspNetUserClaims",
                newName: "IX_AspNetUserClaims_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_MappingListRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                newName: "IX_AspNetRoleClaims_RoleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserTokens",
                table: "AspNetUserTokens",
                columns: new[] { "UserId", "LoginProvider", "Name" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserRoles",
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserLogins",
                table: "AspNetUserLogins",
                columns: new[] { "LoginProvider", "ProviderKey" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetUserClaims",
                table: "AspNetUserClaims",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoles",
                table: "AspNetRoles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AspNetRoleClaims",
                table: "AspNetRoleClaims",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                table: "AspNetUserClaims",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                table: "AspNetUserLogins",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                table: "AspNetUserRoles",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                table: "AspNetUserTokens",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

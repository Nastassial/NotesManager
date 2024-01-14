using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NotesManager.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryEntityConnection : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_Categories_CategoryId",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_CategoryId",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "Users");

            migrationBuilder.AddColumn<int>(
                name: "ContactId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NoteId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TabId",
                table: "Categories",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Categories",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ContactId",
                table: "Categories",
                column: "ContactId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_NoteId",
                table: "Categories",
                column: "NoteId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_TabId",
                table: "Categories",
                column: "TabId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_UserId",
                table: "Categories",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Contacts_ContactId",
                table: "Categories",
                column: "ContactId",
                principalTable: "Contacts",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Notes_NoteId",
                table: "Categories",
                column: "NoteId",
                principalTable: "Notes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Tabs_TabId",
                table: "Categories",
                column: "TabId",
                principalTable: "Tabs",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Categories_Users_UserId",
                table: "Categories",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Contacts_ContactId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Notes_NoteId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Tabs_TabId",
                table: "Categories");

            migrationBuilder.DropForeignKey(
                name: "FK_Categories_Users_UserId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_ContactId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_NoteId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_TabId",
                table: "Categories");

            migrationBuilder.DropIndex(
                name: "IX_Categories_UserId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "ContactId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "NoteId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "TabId",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Categories");

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "Users",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_CategoryId",
                table: "Users",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Users_Categories_CategoryId",
                table: "Users",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id");
        }
    }
}

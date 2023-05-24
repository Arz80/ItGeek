using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ItGeek.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SocialName",
                table: "AuthorsSocials");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Tags",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "CommentNum",
                table: "PostContents",
                newName: "CommentsNum");

            migrationBuilder.RenameColumn(
                name: "CommentClosed",
                table: "PostContents",
                newName: "CommentsClosed");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Categories",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Discription",
                table: "Authors",
                newName: "Description");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Tags",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "CommentsNum",
                table: "PostContents",
                newName: "CommentNum");

            migrationBuilder.RenameColumn(
                name: "CommentsClosed",
                table: "PostContents",
                newName: "CommentClosed");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Categories",
                newName: "Discription");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "Authors",
                newName: "Discription");

            migrationBuilder.AlterColumn<string>(
                name: "Slug",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "SocialName",
                table: "AuthorsSocials",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}

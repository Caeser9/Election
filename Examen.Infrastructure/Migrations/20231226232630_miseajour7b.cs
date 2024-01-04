using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Examen.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class miseajour7b : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MonBureauVote",
                table: "Votes",
                newName: "MonBureauVote_Ville");

            migrationBuilder.RenameColumn(
                name: "MonBureauVote",
                table: "Electeurs",
                newName: "MonBureauVote_Ville");

            migrationBuilder.AddColumn<string>(
                name: "MonBureauVote_Ecole",
                table: "Votes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MonBureauVote_Gouvernerat",
                table: "Votes",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MonBureauVote_NumSalle",
                table: "Votes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MonBureauVote_Ecole",
                table: "Electeurs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MonBureauVote_Gouvernerat",
                table: "Electeurs",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MonBureauVote_NumSalle",
                table: "Electeurs",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MonBureauVote_Ecole",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "MonBureauVote_Gouvernerat",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "MonBureauVote_NumSalle",
                table: "Votes");

            migrationBuilder.DropColumn(
                name: "MonBureauVote_Ecole",
                table: "Electeurs");

            migrationBuilder.DropColumn(
                name: "MonBureauVote_Gouvernerat",
                table: "Electeurs");

            migrationBuilder.DropColumn(
                name: "MonBureauVote_NumSalle",
                table: "Electeurs");

            migrationBuilder.RenameColumn(
                name: "MonBureauVote_Ville",
                table: "Votes",
                newName: "MonBureauVote");

            migrationBuilder.RenameColumn(
                name: "MonBureauVote_Ville",
                table: "Electeurs",
                newName: "MonBureauVote");
        }
    }
}

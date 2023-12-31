using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlSystem.Infrastructure.Core.Data.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionNameColunsAndTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "People",
                newName: "NamePerson");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "People",
                newName: "PersonId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NamePerson",
                table: "People",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "PersonId",
                table: "People",
                newName: "Id");
        }
    }
}

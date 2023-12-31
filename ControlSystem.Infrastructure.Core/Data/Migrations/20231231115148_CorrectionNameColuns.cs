using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ControlSystem.Infrastructure.Core.Data.Migrations
{
    /// <inheritdoc />
    public partial class CorrectionNameColuns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Identity",
                table: "People",
                newName: "IdentityPerson");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdentityPerson",
                table: "People",
                newName: "Identity");
        }
    }
}

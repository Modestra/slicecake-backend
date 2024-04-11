using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Slice.Persistance.Migrations
{
    /// <inheritdoc />
    public partial class Reload : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ShortUser",
                table: "ShortUser");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ShortUser");

            migrationBuilder.DropColumn(
                name: "Age",
                table: "ShortUser");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "ShortUser");

            migrationBuilder.DropColumn(
                name: "Sex",
                table: "ShortUser");

            migrationBuilder.RenameTable(
                name: "ShortUser",
                newName: "ShortUsers");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "ShortUsers",
                newName: "ShortUser");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "ShortUser",
                type: "uuid",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<int>(
                name: "Age",
                table: "ShortUser",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "ShortUser",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Sex",
                table: "ShortUser",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ShortUser",
                table: "ShortUser",
                column: "Id");
        }
    }
}

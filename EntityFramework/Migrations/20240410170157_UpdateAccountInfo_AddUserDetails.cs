using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccountInfo_AddUserDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "AccountInfo",
                type: "varchar(75)",
                unicode: false,
                maxLength: 75,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Phone",
                table: "AccountInfo",
                type: "INT",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "StreetAddress",
                table: "AccountInfo",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Zip",
                table: "AccountInfo",
                type: "INT",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "City",
                table: "AccountInfo");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "AccountInfo");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AccountInfo");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AccountInfo");

            migrationBuilder.DropColumn(
                name: "Phone",
                table: "AccountInfo");

            migrationBuilder.DropColumn(
                name: "StreetAddress",
                table: "AccountInfo");

            migrationBuilder.DropColumn(
                name: "Zip",
                table: "AccountInfo");
        }
    }
}

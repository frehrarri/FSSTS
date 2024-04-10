using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccountInfo_AddMetaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegistrationDate",
                table: "AccountInfo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "AccountInfo",
                type: "DATETIME",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AccountInfo",
                type: "BIT",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "bit");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AccountInfo",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<string>(
                name: "ModifiedBy",
                table: "AccountInfo",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifiedBy",
                table: "AccountInfo");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ModifiedDate",
                table: "AccountInfo",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<bool>(
                name: "IsActive",
                table: "AccountInfo",
                type: "bit",
                nullable: false,
                oldClrType: typeof(bool),
                oldType: "BIT");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "AccountInfo",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AddColumn<DateTime>(
                name: "RegistrationDate",
                table: "AccountInfo",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "getdate()");
        }
    }
}

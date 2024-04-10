using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccountInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Zip",
                table: "AccountInfo",
                newName: "ZipCode");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "AccountInfo",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryQuestion3",
                table: "AccountInfo",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryQuestion2",
                table: "AccountInfo",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryQuestion1",
                table: "AccountInfo",
                type: "varchar(100)",
                unicode: false,
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryAnswer3",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryAnswer2",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryAnswer1",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(200)",
                oldUnicode: false,
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AccountInfo",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "CreatedBy",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedBy",
                table: "AccountInfo");

            migrationBuilder.RenameColumn(
                name: "ZipCode",
                table: "AccountInfo",
                newName: "Zip");

            migrationBuilder.AlterColumn<string>(
                name: "Username",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryQuestion3",
                table: "AccountInfo",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryQuestion2",
                table: "AccountInfo",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryQuestion1",
                table: "AccountInfo",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldUnicode: false,
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryAnswer3",
                table: "AccountInfo",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryAnswer2",
                table: "AccountInfo",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "RecoveryAnswer1",
                table: "AccountInfo",
                type: "varchar(200)",
                unicode: false,
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "AccountInfo",
                type: "varchar(30)",
                unicode: false,
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "ModifiedBy",
                table: "AccountInfo",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(30)",
                oldUnicode: false,
                oldMaxLength: 30);
        }
    }
}

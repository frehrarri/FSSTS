using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RPAEntityFramework.Migrations
{
    /// <inheritdoc />
    public partial class CreateAccountInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AccountInfo",
                columns: table => new
                {
                    AccountInfoID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    Password = table.Column<string>(type: "varchar(30)", unicode: false, maxLength: 30, nullable: false),
                    RecoveryQuestion1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    RecoveryQuestion2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    RecoveryQuestion3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    RecoveryAnswer1 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    RecoveryAnswer2 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    RecoveryAnswer3 = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "datetime2", nullable: false, defaultValueSql: "getdate()"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AccountInfo", x => x.AccountInfoID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AccountInfo");
        }
    }
}

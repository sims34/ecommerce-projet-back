using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    IdArticle = table.Column<Guid>(nullable: false),
                    Label = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    PriceHT = table.Column<int>(nullable: false),
                    Tax = table.Column<int>(nullable: false),
                    Activate = table.Column<bool>(nullable: false),
                    DelievryTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.IdArticle);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Mail = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    login = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    IdAccount = table.Column<Guid>(nullable: false),
                    BillAddress = table.Column<string>(nullable: true),
                    IsClosed = table.Column<bool>(nullable: false),
                    Open = table.Column<DateTime>(nullable: false),
                    Closed = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.IdAccount);
                    table.ForeignKey(
                        name: "FK_Account_Users_IdAccount",
                        column: x => x.IdAccount,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

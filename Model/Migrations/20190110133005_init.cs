using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class init : Migration
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
                    UserId = table.Column<Guid>(nullable: false),
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
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    IdAccount = table.Column<Guid>(nullable: false),
                    BillAddress = table.Column<string>(nullable: true),
                    IsClosed = table.Column<bool>(nullable: false),
                    Open = table.Column<DateTime>(nullable: false),
                    Closed = table.Column<DateTime>(nullable: false),
                    UserId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.IdAccount);
                    table.ForeignKey(
                        name: "FK_Account_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    BasketId = table.Column<Guid>(nullable: false),
                    AccountIdAccount = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.BasketId);
                    table.ForeignKey(
                        name: "FK_Basket_Account_AccountIdAccount",
                        column: x => x.AccountIdAccount,
                        principalTable: "Account",
                        principalColumn: "IdAccount",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    IdBasketItems = table.Column<Guid>(nullable: false),
                    UnitePrice = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ArticleIdArticle = table.Column<Guid>(nullable: true),
                    BasketId = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.IdBasketItems);
                    table.ForeignKey(
                        name: "FK_BasketItems_Articles_ArticleIdArticle",
                        column: x => x.ArticleIdArticle,
                        principalTable: "Articles",
                        principalColumn: "IdArticle",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BasketItems_Basket_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Basket",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("86683ff3-824e-410f-ab95-8035ba09ead4"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "IsClosed", "Open", "UserId" },
                values: new object[] { new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"), "2 Avenue NEW-YORK, USA", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("86683ff3-824e-410f-ab95-8035ba09ead4") });

            migrationBuilder.CreateIndex(
                name: "IX_Account_UserId",
                table: "Account",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Basket_AccountIdAccount",
                table: "Basket",
                column: "AccountIdAccount");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ArticleIdArticle",
                table: "BasketItems",
                column: "ArticleIdArticle");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

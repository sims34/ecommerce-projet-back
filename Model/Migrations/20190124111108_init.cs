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
                    Discriminator = table.Column<string>(nullable: false),
                    Mail = table.Column<string>(nullable: true),
                    Address = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "InventoryItem",
                columns: table => new
                {
                    InventoryItemId = table.Column<Guid>(nullable: false),
                    ArticleIdArticle = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(nullable: false),
                    Quantity = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryItem", x => x.InventoryItemId);
                    table.ForeignKey(
                        name: "FK_InventoryItem_Articles_ArticleIdArticle",
                        column: x => x.ArticleIdArticle,
                        principalTable: "Articles",
                        principalColumn: "IdArticle",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InventorySystem",
                columns: table => new
                {
                    InventorySysID = table.Column<Guid>(nullable: false),
                    ArticleIdArticle = table.Column<Guid>(nullable: true),
                    Quantity = table.Column<int>(nullable: false),
                    DateInventory = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorySystem", x => x.InventorySysID);
                    table.ForeignKey(
                        name: "FK_InventorySystem_Articles_ArticleIdArticle",
                        column: x => x.ArticleIdArticle,
                        principalTable: "Articles",
                        principalColumn: "IdArticle",
                        onDelete: ReferentialAction.Restrict);
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
                    CustomerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.IdAccount);
                    table.ForeignKey(
                        name: "FK_Account_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Logins",
                columns: table => new
                {
                    LoginId = table.Column<Guid>(nullable: false),
                    Password = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    CustomerId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logins", x => x.LoginId);
                    table.ForeignKey(
                        name: "FK_Logins_Users_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Basket",
                columns: table => new
                {
                    BasketId = table.Column<Guid>(nullable: false),
                    AccountId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Basket", x => x.BasketId);
                    table.ForeignKey(
                        name: "FK_Basket_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "IdAccount",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BasketItems",
                columns: table => new
                {
                    IdBasketItems = table.Column<Guid>(nullable: false),
                    UnitePrice = table.Column<int>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    ArticleId = table.Column<Guid>(nullable: false),
                    BasketId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasketItems", x => x.IdBasketItems);
                    table.ForeignKey(
                        name: "FK_BasketItems_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "IdArticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BasketItems_Basket_BasketId",
                        column: x => x.BasketId,
                        principalTable: "Basket",
                        principalColumn: "BasketId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "IdArticle", "Activate", "DelievryTime", "Description", "Label", "PriceHT", "Tax" },
                values: new object[,]
                {
                    { new Guid("78ace119-29bc-4903-a68f-fa10db32bcbf"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 },
                    { new Guid("78ace119-29bc-4903-a68f-fa10db32bcaa"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 },
                    { new Guid("78ace119-29bc-4903-a68f-fa10db32bcbb"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "pomade tonic", 12, 3 },
                    { new Guid("4442f11b-de9d-4595-8970-41d4c84c6dfb"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 }
                });

            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "BasketId", "AccountId" },
                values: new object[] { new Guid("d2523f87-552e-4a07-b1d4-e0bc8ac3da59"), new Guid("add868fc-0392-4615-b311-b3db03b7cd9e") });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "FirstName", "LastName", "Address", "Country", "Mail", "Status" },
                values: new object[] { new Guid("ffd67da1-f694-4f81-b6e7-ac8d0c0b3018"), "Customer", "John", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "CustomerId", "IsClosed", "Open" },
                values: new object[] { new Guid("adf0a65c-5782-4795-b4e8-e5021c46c692"), "5 avenue new-york, usa", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("ffd67da1-f694-4f81-b6e7-ac8d0c0b3018"), true, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[,]
                {
                    { new Guid("2c19e738-7c62-4489-9f45-e3df26b27a0a"), new Guid("4442f11b-de9d-4595-8970-41d4c84c6dfb"), new Guid("d2523f87-552e-4a07-b1d4-e0bc8ac3da59"), 4, 12 },
                    { new Guid("6447012f-a162-412e-9365-48d82a1178f0"), new Guid("4442f11b-de9d-4595-8970-41d4c84c6dfb"), new Guid("d2523f87-552e-4a07-b1d4-e0bc8ac3da59"), 8, 190 },
                    { new Guid("5a8768bf-15b9-4e13-afb5-392606e0dc49"), new Guid("4442f11b-de9d-4595-8970-41d4c84c6dfb"), new Guid("d2523f87-552e-4a07-b1d4-e0bc8ac3da59"), 40, 1200 }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "CustomerId", "Password", "Username" },
                values: new object[] { new Guid("8e612e28-a34f-4f28-88a6-7901635228b7"), new Guid("ffd67da1-f694-4f81-b6e7-ac8d0c0b3018"), "admin", "admin" });

            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "BasketId", "AccountId" },
                values: new object[] { new Guid("0d5fb77d-506f-4827-ab26-40de925cba03"), new Guid("adf0a65c-5782-4795-b4e8-e5021c46c692") });

            migrationBuilder.CreateIndex(
                name: "IX_Account_CustomerId",
                table: "Account",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Basket_AccountId",
                table: "Basket",
                column: "AccountId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ArticleId",
                table: "BasketItems",
                column: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_BasketId",
                table: "BasketItems",
                column: "BasketId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryItem_ArticleIdArticle",
                table: "InventoryItem",
                column: "ArticleIdArticle");

            migrationBuilder.CreateIndex(
                name: "IX_InventorySystem_ArticleIdArticle",
                table: "InventorySystem",
                column: "ArticleIdArticle");

            migrationBuilder.CreateIndex(
                name: "IX_Logins_CustomerId",
                table: "Logins",
                column: "CustomerId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BasketItems");

            migrationBuilder.DropTable(
                name: "InventoryItem");

            migrationBuilder.DropTable(
                name: "InventorySystem");

            migrationBuilder.DropTable(
                name: "Logins");

            migrationBuilder.DropTable(
                name: "Basket");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}

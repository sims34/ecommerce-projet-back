using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class seedBasket : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Articles_ArticleIdArticle",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Basket_BasketId",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketItems_ArticleIdArticle",
                table: "BasketItems");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("1e10ba7e-469a-485d-95f4-52ec6c234e54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f2d7b0c4-dbb5-4ce8-b4af-cf4d5157197c"));

            migrationBuilder.DropColumn(
                name: "ArticleIdArticle",
                table: "BasketItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "BasketId",
                table: "BasketItems",
                nullable: false,
                oldClrType: typeof(Guid),
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ArticleId",
                table: "BasketItems",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("20f75b70-78c4-4931-9742-54b2fd8206a8"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "IsClosed", "Open", "UserId" },
                values: new object[] { new Guid("b6b00160-207e-44e1-b99f-e0b67c6e99dd"), "5 Avenue NEW-YORK, USA", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("20f75b70-78c4-4931-9742-54b2fd8206a8") });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ArticleId",
                table: "BasketItems",
                column: "ArticleId");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Articles_ArticleId",
                table: "BasketItems",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "IdArticle",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Basket_BasketId",
                table: "BasketItems",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "BasketId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Articles_ArticleId",
                table: "BasketItems");

            migrationBuilder.DropForeignKey(
                name: "FK_BasketItems_Basket_BasketId",
                table: "BasketItems");

            migrationBuilder.DropIndex(
                name: "IX_BasketItems_ArticleId",
                table: "BasketItems");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("b6b00160-207e-44e1-b99f-e0b67c6e99dd"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("20f75b70-78c4-4931-9742-54b2fd8206a8"));

            migrationBuilder.DropColumn(
                name: "ArticleId",
                table: "BasketItems");

            migrationBuilder.AlterColumn<Guid>(
                name: "BasketId",
                table: "BasketItems",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<Guid>(
                name: "ArticleIdArticle",
                table: "BasketItems",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("f2d7b0c4-dbb5-4ce8-b4af-cf4d5157197c"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "IsClosed", "Open", "UserId" },
                values: new object[] { new Guid("1e10ba7e-469a-485d-95f4-52ec6c234e54"), "5 Avenue NEW-YORK, USA", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f2d7b0c4-dbb5-4ce8-b4af-cf4d5157197c") });

            migrationBuilder.CreateIndex(
                name: "IX_BasketItems_ArticleIdArticle",
                table: "BasketItems",
                column: "ArticleIdArticle");

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Articles_ArticleIdArticle",
                table: "BasketItems",
                column: "ArticleIdArticle",
                principalTable: "Articles",
                principalColumn: "IdArticle",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BasketItems_Basket_BasketId",
                table: "BasketItems",
                column: "BasketId",
                principalTable: "Basket",
                principalColumn: "BasketId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}

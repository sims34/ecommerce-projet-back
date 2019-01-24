using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Logins_CustomerId",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Account_CustomerId",
                table: "Account");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("fd73649b-5411-4e0c-8d04-f10293bbee05"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("4e9a415c-94d9-47d9-833c-526cdad97ef1"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("5f58b1ab-652b-4138-b7a8-3bcacdffa618"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("71d30168-8889-4992-afe5-3f0eb314942a"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("521c7fb8-5e09-430d-80c9-3556ce16b2c1"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("8e746e71-a231-45c7-8c44-be3de0f9ade7"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "IdArticle",
                keyValue: new Guid("c170110d-1355-4060-9926-2028988d970c"));

            migrationBuilder.DeleteData(
                table: "Basket",
                keyColumn: "BasketId",
                keyValue: new Guid("e3c578ed-3656-4acc-aa80-84a53a11e43b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("9d6a4941-2133-4fae-a148-e4a52880ee18"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("45e13b84-31ed-4920-922a-60f01841d311"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("1fed12ee-bf69-4908-bd01-4a6b48fbf486"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "IdArticle", "Activate", "DelievryTime", "Description", "Label", "PriceHT", "Tax" },
                values: new object[] { new Guid("781131c9-4329-4364-8449-91d7ef41ce76"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "FirstName", "LastName", "Address", "Country", "Mail", "Status" },
                values: new object[] { new Guid("544b8263-44ff-4450-8026-e4bdbbb6b06a"), "Customer", "John", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "FirstName", "LastName", "Address", "Country", "Mail", "Status" },
                values: new object[] { new Guid("b79d1b9c-4ded-42fb-964a-0fea6ea0f62e"), "Customer", "John", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "CustomerId", "IsClosed", "Open" },
                values: new object[,]
                {
                    { new Guid("b658db19-f5e5-40cf-a44b-84f2854786c7"), "5 avenue new-york, usa", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("544b8263-44ff-4450-8026-e4bdbbb6b06a"), true, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("76427a7a-5b66-4b36-9643-2c6630009535"), "5 avenue new-york, usa", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("b79d1b9c-4ded-42fb-964a-0fea6ea0f62e"), true, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "CustomerId", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("38251ab3-29b9-4694-89c0-2401cf5b947e"), new Guid("544b8263-44ff-4450-8026-e4bdbbb6b06a"), "admin", "admin" },
                    { new Guid("f0d26437-5a74-4f4f-bf4f-3f244c58ec92"), new Guid("b79d1b9c-4ded-42fb-964a-0fea6ea0f62e"), "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "BasketId", "AccountId" },
                values: new object[] { new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"), new Guid("76427a7a-5b66-4b36-9643-2c6630009535") });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("64fcf97c-532e-4fba-8631-6ff30c34737e"), new Guid("781131c9-4329-4364-8449-91d7ef41ce76"), new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"), 4, 12 });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("ae391168-1b22-40fb-aa78-b90df5803458"), new Guid("781131c9-4329-4364-8449-91d7ef41ce76"), new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"), 8, 190 });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("196784ef-6277-4bfe-ba27-abc92f252b54"), new Guid("781131c9-4329-4364-8449-91d7ef41ce76"), new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"), 40, 1200 });

            migrationBuilder.CreateIndex(
                name: "IX_Logins_CustomerId",
                table: "Logins",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Account_CustomerId",
                table: "Account",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Logins_CustomerId",
                table: "Logins");

            migrationBuilder.DropIndex(
                name: "IX_Account_CustomerId",
                table: "Account");

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("b658db19-f5e5-40cf-a44b-84f2854786c7"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("196784ef-6277-4bfe-ba27-abc92f252b54"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("64fcf97c-532e-4fba-8631-6ff30c34737e"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("ae391168-1b22-40fb-aa78-b90df5803458"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("38251ab3-29b9-4694-89c0-2401cf5b947e"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("f0d26437-5a74-4f4f-bf4f-3f244c58ec92"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "IdArticle",
                keyValue: new Guid("781131c9-4329-4364-8449-91d7ef41ce76"));

            migrationBuilder.DeleteData(
                table: "Basket",
                keyColumn: "BasketId",
                keyValue: new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("544b8263-44ff-4450-8026-e4bdbbb6b06a"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("76427a7a-5b66-4b36-9643-2c6630009535"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b79d1b9c-4ded-42fb-964a-0fea6ea0f62e"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "IdArticle", "Activate", "DelievryTime", "Description", "Label", "PriceHT", "Tax" },
                values: new object[] { new Guid("c170110d-1355-4060-9926-2028988d970c"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "FirstName", "LastName", "Address", "Country", "Mail", "Status" },
                values: new object[] { new Guid("9d6a4941-2133-4fae-a148-e4a52880ee18"), "Customer", "John", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "FirstName", "LastName", "Address", "Country", "Mail", "Status" },
                values: new object[] { new Guid("1fed12ee-bf69-4908-bd01-4a6b48fbf486"), "Customer", "John", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "CustomerId", "IsClosed", "Open" },
                values: new object[,]
                {
                    { new Guid("fd73649b-5411-4e0c-8d04-f10293bbee05"), "5 avenue new-york, usa", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9d6a4941-2133-4fae-a148-e4a52880ee18"), true, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("45e13b84-31ed-4920-922a-60f01841d311"), "5 avenue new-york, usa", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("1fed12ee-bf69-4908-bd01-4a6b48fbf486"), true, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "CustomerId", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("521c7fb8-5e09-430d-80c9-3556ce16b2c1"), new Guid("9d6a4941-2133-4fae-a148-e4a52880ee18"), "admin", "admin" },
                    { new Guid("8e746e71-a231-45c7-8c44-be3de0f9ade7"), new Guid("1fed12ee-bf69-4908-bd01-4a6b48fbf486"), "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "BasketId", "AccountId" },
                values: new object[] { new Guid("e3c578ed-3656-4acc-aa80-84a53a11e43b"), new Guid("45e13b84-31ed-4920-922a-60f01841d311") });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("4e9a415c-94d9-47d9-833c-526cdad97ef1"), new Guid("c170110d-1355-4060-9926-2028988d970c"), new Guid("e3c578ed-3656-4acc-aa80-84a53a11e43b"), 4, 12 });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("71d30168-8889-4992-afe5-3f0eb314942a"), new Guid("c170110d-1355-4060-9926-2028988d970c"), new Guid("e3c578ed-3656-4acc-aa80-84a53a11e43b"), 8, 190 });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("5f58b1ab-652b-4138-b7a8-3bcacdffa618"), new Guid("c170110d-1355-4060-9926-2028988d970c"), new Guid("e3c578ed-3656-4acc-aa80-84a53a11e43b"), 40, 1200 });

            migrationBuilder.CreateIndex(
                name: "IX_Logins_CustomerId",
                table: "Logins",
                column: "CustomerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Account_CustomerId",
                table: "Account",
                column: "CustomerId",
                unique: true);
        }
    }
}

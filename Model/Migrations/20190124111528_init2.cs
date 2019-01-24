using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Basket",
                keyColumn: "BasketId",
                keyValue: new Guid("0d5fb77d-506f-4827-ab26-40de925cba03"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("2c19e738-7c62-4489-9f45-e3df26b27a0a"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("5a8768bf-15b9-4e13-afb5-392606e0dc49"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("6447012f-a162-412e-9365-48d82a1178f0"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("8e612e28-a34f-4f28-88a6-7901635228b7"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("adf0a65c-5782-4795-b4e8-e5021c46c692"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "IdArticle",
                keyValue: new Guid("4442f11b-de9d-4595-8970-41d4c84c6dfb"));

            migrationBuilder.DeleteData(
                table: "Basket",
                keyColumn: "BasketId",
                keyValue: new Guid("d2523f87-552e-4a07-b1d4-e0bc8ac3da59"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("ffd67da1-f694-4f81-b6e7-ac8d0c0b3018"));

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new Guid("4442f11b-de9d-4595-8970-41d4c84c6dfb"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 });

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
        }
    }
}

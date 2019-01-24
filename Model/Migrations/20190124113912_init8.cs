using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class init8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                values: new object[] { new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Discriminator", "FirstName", "LastName", "Address", "Country", "Mail", "Status" },
                values: new object[,]
                {
                    { new Guid("63f1d157-f395-4349-a236-d1160839a0f0"), "Customer", "John", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 },
                    { new Guid("75d13d33-003a-46e9-83a3-7ebd94326bd8"), "Customer", "John", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 },
                    { new Guid("2843e84b-9fc5-4c42-b949-a1c4d1611c65"), "Customer", "JOJO", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 },
                    { new Guid("bb2bbc75-2184-470c-87e6-c78947ecd35a"), "Customer", "MAMA", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 },
                    { new Guid("454b9371-498d-40d5-9477-b5ffcfe39e67"), "Customer", "MAMI", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 },
                    { new Guid("dff42d6d-855f-4e22-ade5-55caf903bbf6"), "Customer", "JAJAJ", "Smith", "2 Avenue NEW-YORK, USA", "USA", "smith@john.com", 1 }
                });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "CustomerId", "IsClosed", "Open" },
                values: new object[,]
                {
                    { new Guid("72f8f597-273b-4698-9187-21e2244b456f"), "5 avenue new-york, usa", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("63f1d157-f395-4349-a236-d1160839a0f0"), true, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                    { new Guid("76fb3627-a80e-47c2-8cde-08f9b1863596"), "5 avenue new-york, usa", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("75d13d33-003a-46e9-83a3-7ebd94326bd8"), true, new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) }
                });

            migrationBuilder.InsertData(
                table: "Logins",
                columns: new[] { "LoginId", "CustomerId", "Password", "Username" },
                values: new object[,]
                {
                    { new Guid("ff39f610-d3c9-4b53-afa4-611b380daf4a"), new Guid("63f1d157-f395-4349-a236-d1160839a0f0"), "admin", "admin" },
                    { new Guid("51683197-df81-4f4e-bfa8-057d5cc239f0"), new Guid("75d13d33-003a-46e9-83a3-7ebd94326bd8"), "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Basket",
                columns: new[] { "BasketId", "AccountId" },
                values: new object[] { new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"), new Guid("76fb3627-a80e-47c2-8cde-08f9b1863596") });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("4f73de1f-1e0d-434f-9b7e-493ba2108274"), new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"), new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"), 4, 12 });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("ccee01db-8602-41f7-b5be-29fcb05f209e"), new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"), new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"), 8, 190 });

            migrationBuilder.InsertData(
                table: "BasketItems",
                columns: new[] { "IdBasketItems", "ArticleId", "BasketId", "Quantity", "UnitePrice" },
                values: new object[] { new Guid("a98a531a-d453-422c-a463-62022024f51c"), new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"), new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"), 40, 1200 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("72f8f597-273b-4698-9187-21e2244b456f"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("4f73de1f-1e0d-434f-9b7e-493ba2108274"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("a98a531a-d453-422c-a463-62022024f51c"));

            migrationBuilder.DeleteData(
                table: "BasketItems",
                keyColumn: "IdBasketItems",
                keyValue: new Guid("ccee01db-8602-41f7-b5be-29fcb05f209e"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("51683197-df81-4f4e-bfa8-057d5cc239f0"));

            migrationBuilder.DeleteData(
                table: "Logins",
                keyColumn: "LoginId",
                keyValue: new Guid("ff39f610-d3c9-4b53-afa4-611b380daf4a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("2843e84b-9fc5-4c42-b949-a1c4d1611c65"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("454b9371-498d-40d5-9477-b5ffcfe39e67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("bb2bbc75-2184-470c-87e6-c78947ecd35a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("dff42d6d-855f-4e22-ade5-55caf903bbf6"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "IdArticle",
                keyValue: new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"));

            migrationBuilder.DeleteData(
                table: "Basket",
                keyColumn: "BasketId",
                keyValue: new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("63f1d157-f395-4349-a236-d1160839a0f0"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("76fb3627-a80e-47c2-8cde-08f9b1863596"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("75d13d33-003a-46e9-83a3-7ebd94326bd8"));

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
        }
    }
}

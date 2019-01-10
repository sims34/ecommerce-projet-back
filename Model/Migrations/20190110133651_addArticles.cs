using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class addArticles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("b97218c6-881e-426f-a95e-689e624bbfbe"));

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "IdArticle", "Activate", "DelievryTime", "Description", "Label", "PriceHT", "Tax" },
                values: new object[] { new Guid("78ace119-29bc-4903-a68f-fa10db32bcaa"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "IdArticle", "Activate", "DelievryTime", "Description", "Label", "PriceHT", "Tax" },
                values: new object[] { new Guid("78ace119-29bc-4903-a68f-fa10db32bcbb"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "pomade tonic", 12, 3 });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("597312d2-fb01-4cfa-bdcf-6a3fe5d727f9"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                column: "UserId",
                value: new Guid("597312d2-fb01-4cfa-bdcf-6a3fe5d727f9"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "IdArticle",
                keyValue: new Guid("78ace119-29bc-4903-a68f-fa10db32bcaa"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "IdArticle",
                keyValue: new Guid("78ace119-29bc-4903-a68f-fa10db32bcbb"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("597312d2-fb01-4cfa-bdcf-6a3fe5d727f9"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("b97218c6-881e-426f-a95e-689e624bbfbe"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                column: "UserId",
                value: new Guid("b97218c6-881e-426f-a95e-689e624bbfbe"));
        }
    }
}

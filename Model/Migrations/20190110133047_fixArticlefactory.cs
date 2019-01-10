using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class fixArticlefactory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("86683ff3-824e-410f-ab95-8035ba09ead4"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("a3910130-94d4-4bf7-8812-4b8eabdfbc53"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                column: "UserId",
                value: new Guid("a3910130-94d4-4bf7-8812-4b8eabdfbc53"));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("a3910130-94d4-4bf7-8812-4b8eabdfbc53"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("86683ff3-824e-410f-ab95-8035ba09ead4"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("0f8fad5b-d9cb-469f-a165-70867728950e"),
                column: "UserId",
                value: new Guid("86683ff3-824e-410f-ab95-8035ba09ead4"));
        }
    }
}

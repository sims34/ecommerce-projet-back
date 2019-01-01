using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class AddSeedArticle : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "IdArticle", "Activate", "DelievryTime", "Description", "Label", "PriceHT", "Tax" },
                values: new object[] { new Guid("6ffb92a3-b75a-4acc-baae-e098e1581c25"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "Creme hydradanteXXL", 12, 3 });

            migrationBuilder.InsertData(
                table: "Articles",
                columns: new[] { "IdArticle", "Activate", "DelievryTime", "Description", "Label", "PriceHT", "Tax" },
                values: new object[] { new Guid("43b566ad-345f-4f88-85b3-44d79472eb1d"), true, 3, "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", "pomade tonic", 12, 3 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "IdArticle",
                keyValue: new Guid("43b566ad-345f-4f88-85b3-44d79472eb1d"));

            migrationBuilder.DeleteData(
                table: "Articles",
                keyColumn: "IdArticle",
                keyValue: new Guid("6ffb92a3-b75a-4acc-baae-e098e1581c25"));
        }
    }
}

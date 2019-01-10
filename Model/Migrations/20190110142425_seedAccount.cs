using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class seedAccount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("515b2d27-b8c3-49b0-8463-202178dfffb6"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("9605a23c-a93d-4a34-aa64-bc7bed38fc33"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("c098a9b2-9103-49f4-a5bd-5df8c6fa636f"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("eb1d0e98-427a-4bfe-b167-dca8e5d42051"));

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("f2d7b0c4-dbb5-4ce8-b4af-cf4d5157197c"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "IsClosed", "Open", "UserId" },
                values: new object[] { new Guid("1e10ba7e-469a-485d-95f4-52ec6c234e54"), "5 Avenue NEW-YORK, USA", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("f2d7b0c4-dbb5-4ce8-b4af-cf4d5157197c") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "IdAccount",
                keyValue: new Guid("1e10ba7e-469a-485d-95f4-52ec6c234e54"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: new Guid("f2d7b0c4-dbb5-4ce8-b4af-cf4d5157197c"));

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "IdAccount", "BillAddress", "Closed", "IsClosed", "Open", "UserId" },
                values: new object[,]
                {
                    { new Guid("c098a9b2-9103-49f4-a5bd-5df8c6fa636f"), "5 Avenue NEW-YORK, USA", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("89718d9e-3e23-46e8-b9ab-4a08763723bc") },
                    { new Guid("515b2d27-b8c3-49b0-8463-202178dfffb6"), "2 Avenue NEW-YORK, USA", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("89718d9e-3e23-46e8-b9ab-4a08763723bc") },
                    { new Guid("9605a23c-a93d-4a34-aa64-bc7bed38fc33"), "4 Avenue NEW-YORK, USA", new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), true, new DateTime(2019, 1, 10, 0, 0, 0, 0, DateTimeKind.Local), new Guid("89718d9e-3e23-46e8-b9ab-4a08763723bc") }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "Address", "Country", "Discriminator", "FirstName", "LastName", "Mail" },
                values: new object[] { new Guid("eb1d0e98-427a-4bfe-b167-dca8e5d42051"), "2 Avenue NEW-YORK, USA", "USA", "User", "John", "Smith", "smith@john.com" });
        }
    }
}

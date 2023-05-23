using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class AddedInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "162e097a-402e-41b2-b016-558a193e1138");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b7ef0e5a-03e9-4911-aed0-7bfb3d933ea9");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0fbe72fe-750c-46f3-b98c-d5ca042643f4", null, "admin", "ADMIN" },
                    { "c5eee749-b082-43ce-b0ab-cb834fedfa46", null, "customer", "CUSTOMER" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 4999m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0fbe72fe-750c-46f3-b98c-d5ca042643f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c5eee749-b082-43ce-b0ab-cb834fedfa46");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "162e097a-402e-41b2-b016-558a193e1138", null, "customer", "CUSTOMER" },
                    { "b7ef0e5a-03e9-4911-aed0-7bfb3d933ea9", null, "admin", "ADMIN" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "Price",
                value: 599m);
        }
    }
}

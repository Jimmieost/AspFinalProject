using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dd47938-e7a4-4acb-a207-021ac1d9f54d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7f8fbaed-9dcd-4fbc-8ec4-87396e465358");

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1fcbf457-3dd9-492a-b7ab-789c89afcf1f", null, "customer", "CUSTOMER" },
                    { "291c298d-5402-417a-a531-770bc0735b66", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 2 },
                    { 1, 3 },
                    { 1, 4 },
                    { 1, 5 },
                    { 1, 6 },
                    { 1, 7 },
                    { 1, 8 },
                    { 1, 9 },
                    { 1, 10 },
                    { 2, 6 },
                    { 2, 7 },
                    { 2, 8 },
                    { 2, 9 },
                    { 2, 10 },
                    { 2, 11 },
                    { 2, 12 },
                    { 2, 13 },
                    { 2, 14 },
                    { 2, 15 },
                    { 3, 11 },
                    { 3, 12 },
                    { 3, 13 },
                    { 3, 14 },
                    { 3, 15 },
                    { 3, 16 },
                    { 3, 17 },
                    { 3, 18 },
                    { 3, 19 },
                    { 3, 20 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1fcbf457-3dd9-492a-b7ab-789c89afcf1f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "291c298d-5402-417a-a531-770bc0735b66");

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 4 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 5 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 1, 10 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 7 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 8 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 9 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 10 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 11 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 12 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 13 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 14 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 15 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 11 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 12 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 13 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 14 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 15 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 16 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 17 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 18 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 19 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 20 });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1dd47938-e7a4-4acb-a207-021ac1d9f54d", null, "customer", "CUSTOMER" },
                    { "7f8fbaed-9dcd-4fbc-8ec4-87396e465358", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 2, 1 },
                    { 3, 2 }
                });
        }
    }
}

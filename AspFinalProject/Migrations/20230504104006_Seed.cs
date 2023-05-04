using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace AspFinalProject.Migrations
{
    /// <inheritdoc />
    public partial class Seed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1dd47938-e7a4-4acb-a207-021ac1d9f54d", null, "customer", "CUSTOMER" },
                    { "7f8fbaed-9dcd-4fbc-8ec4-87396e465358", null, "admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "New" },
                    { 2, "Featured" },
                    { 3, "Popular" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Image", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "The Pearl Export EXX is a popular drumkit among beginner and intermediate drummers. It features high-quality hardware and comes in a variety of finishes.", "1.png", "Pearl Export EXX", 799m },
                    { 2, "The Ludwig Classic Maple is a professional-grade drumkit that has been used by many famous drummers. It is known for its warm tone and great projection.", "2.png", "Ludwig Classic Maple", 2699m },
                    { 3, "The DW Design Series is a versatile drumkit that is suitable for a wide range of musical styles. It features a low-mass tom suspension system for enhanced resonance.", "3.png", "DW Design Series", 1899m },
                    { 4, "The Gretsch Catalina Club is a compact drumkit that is ideal for smaller venues and practice spaces. It features a vintage-style design and comes in several colors.", "4.png", "Gretsch Catalina Club", 799m },
                    { 5, "The Mapex Saturn V is a high-end drumkit that offers excellent sound quality and durability. It features hybrid shells made from maple and walnut.", "5.png", "Mapex Saturn V", 1999m },
                    { 6, "The PDP Concept Maple is a versatile drumkit that is suitable for a wide range of musical styles. It features a maple shell and comes in several finishes.", "6.png", "PDP Concept Maple", 999m },
                    { 7, "The Tama Imperialstar is a popular drumkit among beginner and intermediate drummers. It features a 100% poplar shell and comes in several finishes.", "7.png", "Tama Imperialstar", 799m },
                    { 8, "The Sonor AQ2 is a mid-range drumkit that offers excellent sound quality and versatility. It features a maple shell and comes in several finishes.", "8.png", "Sonor AQ2", 1299m },
                    { 9, "The Yamaha Stage Custom is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "9.png", "Yamaha Stage Custom", 699m },
                    { 10, "The Pearl Popstar is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "10.png", "Pearl Popstar", 699m },
                    { 11, "The Yamaha Legend is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "11.png", "Yamaha Legend", 699m },
                    { 12, "The Gretch California is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "12.png", "Gretch California", 699m },
                    { 13, "The Mapex SXX is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "13.png", "Mapex SXX", 699m },
                    { 14, "The Yamaha Stage Custom is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "14.png", "Gretch Fall Out", 699m },
                    { 15, "The Premier Beatles Signature is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "15.png", "Premier Beatles Signature", 699m },
                    { 16, "The Pearl Olympic is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "16.png", "Pearl Olympic", 699m },
                    { 17, "The Tama Ulrich Signature is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "17.png", "Tama Ulrich Signature", 699m },
                    { 18, "Gretch Solar is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "18.png", "Gretch Solar", 699m },
                    { 19, "The Yamaha DKV is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "19.png", "Yamaha DKV ", 999m },
                    { 20, "The Yamaha DTX is a reliable and affordable drumkit that is suitable for beginner and intermediate drummers. It features a birch shell and comes in several finishes.", "20.png", "Yamaha DTX", 599m }
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "CategoriesId", "ProductsId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 2, 1 },
                    { 3, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 2, 1 });

            migrationBuilder.DeleteData(
                table: "ProductCategory",
                keyColumns: new[] { "CategoriesId", "ProductsId" },
                keyValues: new object[] { 3, 2 });

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}

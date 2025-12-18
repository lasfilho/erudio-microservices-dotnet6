using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace GeekShopping.ProductAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductDataTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 3L, "Photo", "Foto com logo Geek", "", "Geek Picture", 10.9m },
                    { 4L, "Material Escolar", "NoteBook com logo Geek", "", "Geek NoteBook", 49.9m },
                    { 5L, "Vestuario", "Escova com logo Geek", "", "Geek Brush", 15.9m },
                    { 6L, "Alimento", "Bolo com logo Geek", "", "Geek Cake", 12.9m },
                    { 7L, "Vestuario", "Oculos com logo Geek", "", "Geek Glass", 90.9m },
                    { 8L, "Vestuario", "Bermuda com logo Geek", "", "Geek Short", 69.9m },
                    { 9L, "Vestuario", "Luvas com logo Geek", "", "Geek Gloves", 20.9m },
                    { 10L, "Vestuario", "Bone com logo Geek", "", "Geek Hat", 69.9m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 9L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 10L);
        }
    }
}

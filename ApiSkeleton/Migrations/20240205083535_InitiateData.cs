using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiSkeleton.Migrations
{
    /// <inheritdoc />
    public partial class InitiateData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "ClassGroups",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("675dc97f-d97c-41d3-97b1-d07d54cd08a0"), "Kelas 15.S TI" },
                    { new Guid("9c78546c-4643-4a3a-8159-e0158ec143b5"), "Kelas 15.C TI" },
                    { new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Kelas 15.A TI" }
                });

            migrationBuilder.InsertData(
                table: "ClassMembers",
                columns: new[] { "Id", "ClassGroupId", "Name" },
                values: new object[,]
                {
                    { new Guid("0c25e253-1500-4517-adf6-cc6e422b22ee"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Prasetyo Adi" },
                    { new Guid("c6be1873-fd9f-4fda-94f7-117e532cec1c"), new Guid("9c78546c-4643-4a3a-8159-e0158ec143b5"), "John Dower" },
                    { new Guid("d3f844bc-c75c-4c68-bb64-ffab6ae5118a"), new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"), "Firman Putera" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ClassGroups",
                keyColumn: "Id",
                keyValue: new Guid("675dc97f-d97c-41d3-97b1-d07d54cd08a0"));

            migrationBuilder.DeleteData(
                table: "ClassMembers",
                keyColumn: "Id",
                keyValue: new Guid("0c25e253-1500-4517-adf6-cc6e422b22ee"));

            migrationBuilder.DeleteData(
                table: "ClassMembers",
                keyColumn: "Id",
                keyValue: new Guid("c6be1873-fd9f-4fda-94f7-117e532cec1c"));

            migrationBuilder.DeleteData(
                table: "ClassMembers",
                keyColumn: "Id",
                keyValue: new Guid("d3f844bc-c75c-4c68-bb64-ffab6ae5118a"));

            migrationBuilder.DeleteData(
                table: "ClassGroups",
                keyColumn: "Id",
                keyValue: new Guid("9c78546c-4643-4a3a-8159-e0158ec143b5"));

            migrationBuilder.DeleteData(
                table: "ClassGroups",
                keyColumn: "Id",
                keyValue: new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"));
        }
    }
}

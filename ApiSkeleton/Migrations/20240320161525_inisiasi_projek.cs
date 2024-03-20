using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiSkeleton.Migrations
{
    /// <inheritdoc />
    public partial class inisiasi_projek : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CompanyDeparments",
                columns: table => new
                {
                    ID_M_Department = table.Column<Guid>(type: "uuid", nullable: false),
                    ID_M_Company = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "M_Company",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Company", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_Division",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Division", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "M_Department",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    M_CompanyId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_Department", x => x.Id);
                    table.ForeignKey(
                        name: "FK_M_Department_M_Company_M_CompanyId",
                        column: x => x.M_CompanyId,
                        principalTable: "M_Company",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "DepartmentDivisions",
                columns: table => new
                {
                    ID_M_Department = table.Column<Guid>(type: "uuid", nullable: false),
                    ID_M_Division = table.Column<Guid>(type: "uuid", nullable: false),
                    DepartmentId = table.Column<Guid>(type: "uuid", nullable: false),
                    DivisionId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_DepartmentDivisions_M_Department_DepartmentId",
                        column: x => x.DepartmentId,
                        principalTable: "M_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DepartmentDivisions_M_Division_DivisionId",
                        column: x => x.DivisionId,
                        principalTable: "M_Division",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "M_DepartmentM_Division",
                columns: table => new
                {
                    DepartmentsId = table.Column<Guid>(type: "uuid", nullable: false),
                    DivisionsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_M_DepartmentM_Division", x => new { x.DepartmentsId, x.DivisionsId });
                    table.ForeignKey(
                        name: "FK_M_DepartmentM_Division_M_Department_DepartmentsId",
                        column: x => x.DepartmentsId,
                        principalTable: "M_Department",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_M_DepartmentM_Division_M_Division_DivisionsId",
                        column: x => x.DivisionsId,
                        principalTable: "M_Division",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "M_Company",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("0a2ab041-2c73-4d98-a1cb-c929ead193bd"), "Kompi2" },
                    { new Guid("44ac9b0a-a06e-4322-a628-820da257ca52"), "Kompi3" },
                    { new Guid("9a454039-5104-4870-826f-dc7f389b4368"), "Kompi1" }
                });

            migrationBuilder.InsertData(
                table: "M_Department",
                columns: new[] { "Id", "M_CompanyId", "Name" },
                values: new object[,]
                {
                    { new Guid("004851fd-df49-41d8-aa1e-e357e1a26b44"), null, "Dept2" },
                    { new Guid("10eacbeb-6f21-4e20-a4b9-3d2e28b1cfcc"), null, "Dept3" },
                    { new Guid("54c6d688-e6ef-4185-9c08-abdf3fa400f5"), null, "Dept1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentDivisions_DepartmentId",
                table: "DepartmentDivisions",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentDivisions_DivisionId",
                table: "DepartmentDivisions",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_M_Department_M_CompanyId",
                table: "M_Department",
                column: "M_CompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_M_DepartmentM_Division_DivisionsId",
                table: "M_DepartmentM_Division",
                column: "DivisionsId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CompanyDeparments");

            migrationBuilder.DropTable(
                name: "DepartmentDivisions");

            migrationBuilder.DropTable(
                name: "M_DepartmentM_Division");

            migrationBuilder.DropTable(
                name: "M_Department");

            migrationBuilder.DropTable(
                name: "M_Division");

            migrationBuilder.DropTable(
                name: "M_Company");
        }
    }
}

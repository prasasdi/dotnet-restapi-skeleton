using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ApiSkeleton.Migrations
{
    /// <inheritdoc />
    public partial class apply_produk_configuration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Produk",
                columns: new[] { "Id", "CreatedAt", "Deskripsi", "Harga", "ModifiedAt", "Nama", "Rating" },
                values: new object[,]
                {
                    { new Guid("00780bc4-4a0f-4907-9e90-cf5af58e1881"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 759671, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Special Edition - 4", 3 },
                    { new Guid("008d510b-7dc4-4ff6-9a80-264b92d99318"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 960267, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas A - 4", 4 },
                    { new Guid("00fb51d8-b575-4619-bc44-866819855d25"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 558826, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Limited Edition - 2", 4 },
                    { new Guid("027d946e-cd8d-402a-bafc-787f27d9cf18"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 723099, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas B - 4", 5 },
                    { new Guid("02ca5109-e2c3-4f10-b89c-6bd41021d094"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 511063, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Limited Edition - 5", 3 },
                    { new Guid("02d42f27-5f76-4c85-bf21-93d1f1272567"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 525528, new TimeSpan(0, 0, 0, 0, 0), "Super AA Limited Edition - 4", 5 },
                    { new Guid("0301fbcb-1661-4ab1-aab5-a62e2eeb952a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 899908, new TimeSpan(0, 0, 0, 0, 0), "Model AA Special Edition - 1", 4 },
                    { new Guid("0356e504-e113-44e8-b4db-dcbde2532517"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 895012, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas A - 3", 3 },
                    { new Guid("03f49a87-7516-4802-a94d-a36532446d09"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 935180, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas A - 2", 3 },
                    { new Guid("052ef5f3-f78c-4e53-b6ce-d5fceb3a4b15"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 723772, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas A - 3", 5 },
                    { new Guid("061be14d-e6e7-47b9-97e6-665bb029853a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 553753, new TimeSpan(0, 0, 0, 0, 0), "Model AA Special Edition - 3", 5 },
                    { new Guid("07163aad-d936-4d4c-997f-5e48dbe8800d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 817185, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas B - 4", 5 },
                    { new Guid("0726065e-4eff-4088-8192-16bbb0f6a848"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 912137, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Special Edition - 3", 3 },
                    { new Guid("07853aa1-dd1d-49de-bb00-411b492403af"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 521584, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Special Edition - 4", 5 },
                    { new Guid("07bec19e-e9cc-40a2-a449-2294ec43c6a6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 873025, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Special Edition - 2", 5 },
                    { new Guid("07ff4e07-77e1-43b3-9d55-478f93154969"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 653596, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Special Edition - 3", 5 },
                    { new Guid("09951d2e-0795-4220-bb12-98180fe5695b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 800751, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas B - 5", 3 },
                    { new Guid("09da3ac3-6408-48f7-90cc-076d92d9af55"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 963618, new TimeSpan(0, 0, 0, 0, 0), "Model AA Limited Edition - 4", 5 },
                    { new Guid("0a2a1a69-3272-4bb3-89d4-974200e9c3ec"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 862286, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas A - 5", 5 },
                    { new Guid("0b17a2f3-b05f-4428-9b14-e88420e7b1ac"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 654287, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas B - 2", 4 },
                    { new Guid("0b1e0217-e4e0-4f03-b669-e2fff9d7e199"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 511230, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas B - 3", 3 },
                    { new Guid("0ba4d14e-4153-444d-b55f-f144a9c790fb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 958906, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas B - 2", 5 },
                    { new Guid("0bc4f5f3-4bbf-4f31-9f60-08f590761c3a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 632235, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas A - 5", 5 },
                    { new Guid("0c1e02d0-67d4-464f-b329-ab956e7a0933"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 781191, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas A - 3", 3 },
                    { new Guid("0d0f5e02-eead-49f2-a53c-ac665e0d71a2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 527097, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas A - 1", 3 },
                    { new Guid("0d703fed-e2ca-41c3-bd97-e7b7c070e45b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 661676, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas B - 2", 4 },
                    { new Guid("0daca8c0-3079-4143-9346-9934b35c1831"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 678356, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas B - 1", 4 },
                    { new Guid("0f113f5d-060a-435b-b16b-913850b29fc1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 564029, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Special Edition - 5", 3 },
                    { new Guid("1079aa3a-abda-45d9-8d3d-a70b171ee930"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 785185, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas A - 4", 5 },
                    { new Guid("11b50b54-9c19-48cd-a367-e3faa3e03b42"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 848407, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas B - 5", 4 },
                    { new Guid("126ec095-d439-4848-85e7-995c381e2be8"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 664027, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas A - 1", 4 },
                    { new Guid("127d973b-6c6c-44b6-b756-d582b3f5d2d9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 838953, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas A - 4", 4 },
                    { new Guid("12be6a34-72d2-444f-87d7-c593ad62ed5a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 864505, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Special Edition - 5", 3 },
                    { new Guid("12d2e2b3-7fa0-4beb-b45c-436a15ea9098"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 516344, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Limited Edition - 1", 4 },
                    { new Guid("131a693e-006c-434c-845c-c249049bdd1e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 651015, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Special Edition - 2", 4 },
                    { new Guid("13c5ef32-328d-45e6-b5bc-f1515c92d6a3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 668098, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Special Edition - 4", 4 },
                    { new Guid("14a99cb0-a22c-49fa-a4ca-0d6046a969f4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 828876, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Special Edition - 4", 5 },
                    { new Guid("14ff03bc-36f8-4ef1-b1a0-b043e3c9a4b3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 512802, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Special Edition - 2", 4 },
                    { new Guid("15a5140d-bf01-4356-a659-32169e3aecac"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 869523, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas A - 1", 4 },
                    { new Guid("15c53a95-2c6c-481a-be97-8e208d7b452a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 569674, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Special Edition - 2", 3 },
                    { new Guid("15f11e70-ee00-4721-85bb-48eaf50764aa"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 998018, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Special Edition - 4", 5 },
                    { new Guid("164a730d-4061-4e93-9ce7-510bf1752375"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 875641, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas B - 4", 4 },
                    { new Guid("16e4e91b-aa14-44c2-b433-122a487c893b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 867648, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Limited Edition - 5", 5 },
                    { new Guid("179fe5d5-a80b-4dbb-b7c2-bfcd2740d079"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 920961, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas A - 3", 3 },
                    { new Guid("18c46480-d9dc-40f8-9ba9-6e090c0cf62b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 710647, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas A - 1", 4 },
                    { new Guid("1953faea-6634-4065-b008-f8d65feb2a15"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 775096, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Limited Edition - 4", 4 },
                    { new Guid("195920a8-a63a-450c-ac8b-032a878d615c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 739498, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas A - 1", 5 },
                    { new Guid("1959e7bb-9741-4c2d-b0cd-6eb63b819d81"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 602327, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Special Edition - 1", 3 },
                    { new Guid("1a27004b-3bf0-4461-b9ec-1ce5a765ef3a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 909617, new TimeSpan(0, 0, 0, 0, 0), "Model AB Limited Edition - 2", 5 },
                    { new Guid("1a38accd-0960-433f-977f-7c2888ce9fff"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 962478, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Special Edition - 1", 4 },
                    { new Guid("1a669db6-f13f-41f4-8940-f5a163a632ff"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 791315, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas A - 4", 3 },
                    { new Guid("1aeb689d-a1fc-415d-97ff-d6b73952cd0e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 881153, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas B - 2", 5 },
                    { new Guid("1b11b3ae-23d0-4632-8689-0b465550b63b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 885560, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas B - 2", 3 },
                    { new Guid("1b298b39-bbfe-4199-abec-17f830323dda"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 701393, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Special Edition - 1", 5 },
                    { new Guid("1c836270-c11f-48b4-8d35-1ec09b6059f4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 792162, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Special Edition - 2", 3 },
                    { new Guid("1d763b1a-7425-436e-91d9-f8b77a581bcf"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 642963, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas B - 5", 4 },
                    { new Guid("1dbcc411-97e8-4102-832b-3dfce1df7d1e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 530786, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Special Edition - 1", 4 },
                    { new Guid("1e1d8710-6c90-421a-8587-6b5d3cd01046"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 732547, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Special Edition - 4", 4 },
                    { new Guid("1e77f7f7-43d3-417f-a2be-26650c31b67b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 733826, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Special Edition - 2", 5 },
                    { new Guid("1edcffd1-4860-46fc-a6d4-dbc890ceb2bf"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 673930, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas B - 1", 3 },
                    { new Guid("200ed91c-ec09-4682-979d-82370a1bb3d4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 783799, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas A - 5", 5 },
                    { new Guid("205d08e4-2109-44af-8d30-5e04f2b5a967"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 727871, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Limited Edition - 5", 3 },
                    { new Guid("20734cbc-209a-4519-8522-71508d74e093"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 903179, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Special Edition - 2", 5 },
                    { new Guid("21481e0d-4b90-4df7-92ba-67b623bd6e2e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 981119, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas B - 4", 5 },
                    { new Guid("22e0c683-dd89-4352-9a36-488f6406d382"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 585645, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas B - 1", 4 },
                    { new Guid("2303f5bb-a8cd-4146-a530-b540bbc8fae3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 917783, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Limited Edition - 3", 3 },
                    { new Guid("237465e4-bcea-4cb4-8605-7e77de7c55b8"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 753913, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas A - 2", 4 },
                    { new Guid("242545cb-e074-415a-833f-b0df13c6b49e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 545363, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas B - 3", 5 },
                    { new Guid("24b1e0a8-7f29-475a-947d-b4a1f187902a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 634695, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Limited Edition - 4", 5 },
                    { new Guid("24e04edc-49fa-4765-a197-0d6a4111fec9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 592568, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas B - 5", 4 },
                    { new Guid("254bced8-272c-4457-ab04-e27a52c58afd"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 829254, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas A - 1", 5 },
                    { new Guid("25cbe285-db1b-40ef-b5f6-4465147831f4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 538548, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas B - 5", 3 },
                    { new Guid("2687f465-aa46-4765-8adc-274ac0111c32"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 675940, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Limited Edition - 2", 3 },
                    { new Guid("26c779f0-25c1-4db5-9492-822e7836e089"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 600947, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas B - 5", 3 },
                    { new Guid("277ffe7d-f186-46ac-ba75-bb37450c6ca7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 881570, new TimeSpan(0, 0, 0, 0, 0), "Model AB Limited Edition - 5", 5 },
                    { new Guid("285bf2a2-c910-45d9-b095-be07f0faa765"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 570094, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas B - 4", 5 },
                    { new Guid("28c06eb5-968e-4df7-b299-c9bcd2c1b0ba"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 641966, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas A - 1", 4 },
                    { new Guid("295acb25-88c5-4cdf-84ae-baa2ae2e0681"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 986682, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas A - 4", 3 },
                    { new Guid("2988e757-060a-4084-b986-e20ddab5d4fb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 706224, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas A - 5", 4 },
                    { new Guid("29b13700-84f5-4e9d-9868-dfaa47217f36"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 957258, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Limited Edition - 1", 3 },
                    { new Guid("2a8e4977-f4c5-447e-a4d0-198af36d38d3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 996796, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Limited Edition - 1", 3 },
                    { new Guid("2b2715de-69db-47b9-b778-5a3c0a702e23"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 737133, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Limited Edition - 5", 5 },
                    { new Guid("2b27c95e-8b89-49ca-83bf-1edad8e8d94d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 804634, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Special Edition - 5", 4 },
                    { new Guid("2b4520a0-0e0f-406e-99b2-c41dfa9bf689"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 637946, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas A - 5", 4 },
                    { new Guid("2c067fec-f087-44fb-8fa6-2a995948f0b2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 749249, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas B - 4", 5 },
                    { new Guid("2ce931a1-06f2-403b-9411-1e964ac7f697"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 811517, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas B - 2", 3 },
                    { new Guid("2d4545f1-322d-4768-8027-d2b8ab1d0c40"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 941196, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Special Edition - 1", 5 },
                    { new Guid("2da08eb0-ef1b-4e91-a923-53a30990a35f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 539147, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Special Edition - 5", 4 },
                    { new Guid("2dbe2f9a-3711-4a3e-be69-34ddce4707c5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 969049, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Special Edition - 3", 4 },
                    { new Guid("2e7a049d-5c4c-40e1-a8eb-94026ebd8bdc"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 726651, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Special Edition - 3", 3 },
                    { new Guid("2e95ddc0-b5e1-46a7-b2d7-6fe1b5920bc7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 859027, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Limited Edition - 2", 3 },
                    { new Guid("2fbda6a5-3c63-435d-9f16-de0235c36b9f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 943372, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Limited Edition - 1", 3 },
                    { new Guid("30455775-68a0-43a1-b5f6-463f6761b96d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 768565, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Special Edition - 5", 3 },
                    { new Guid("30a40bdc-36b1-43fb-b511-4c2ff2f7836a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 625398, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Limited Edition - 1", 4 },
                    { new Guid("30e29c95-bcf1-4764-b03b-1d094d5b6192"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 840031, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Special Edition - 2", 3 },
                    { new Guid("30e2ecb7-9440-4ff8-8e79-000bce202163"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 800353, new TimeSpan(0, 0, 0, 0, 0), "Super AA Limited Edition - 2", 5 },
                    { new Guid("329ffdca-b0f8-48b9-ae1f-a6f7cdd4a23b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 548715, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas A - 5", 5 },
                    { new Guid("32adf659-49a0-43b5-b6f0-1ca960e24896"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 820118, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas A - 1", 5 },
                    { new Guid("32ef30d8-491e-4e50-827f-0f8ec6e0404a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 705384, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas B - 5", 3 },
                    { new Guid("33c8ea0d-8353-4b15-a478-ccdf31f8b863"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 625342, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Limited Edition - 4", 3 },
                    { new Guid("33e1868f-ef7b-42d6-a53e-22f8d989e370"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 919793, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Limited Edition - 1", 5 },
                    { new Guid("341e2be8-86e9-4d49-9be2-d87072527abe"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 853671, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas A - 3", 5 },
                    { new Guid("34557024-cd11-4a2d-b6a2-c3382a23e373"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 567351, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas A - 5", 4 },
                    { new Guid("346473ac-15a1-4ccb-b10c-7830fad0acc3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 860120, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Limited Edition - 2", 4 },
                    { new Guid("34844c6c-6c9c-402f-bbf3-e6da51cb1961"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 613003, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas A - 4", 4 },
                    { new Guid("34ddc99b-0451-43b2-b5c1-33df900eac21"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 773441, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Limited Edition - 4", 3 },
                    { new Guid("34ede8d0-ba64-455f-8a2a-1de5736ec028"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 852008, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas A - 2", 4 },
                    { new Guid("379d85c4-f0b4-4dd9-9350-11fada5ae35a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 811301, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas B - 3", 4 },
                    { new Guid("38109807-5499-43df-8eef-c07fffe3d984"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 741750, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas A - 4", 5 },
                    { new Guid("38161bdf-1e3e-4cf3-bfcb-e9a2d11bff3f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 815728, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas A - 3", 5 },
                    { new Guid("385fa9fe-c7ea-4670-8165-7fe072d9d0bf"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 731904, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Limited Edition - 4", 3 },
                    { new Guid("38e8e80a-be3b-4e61-880c-6b27ac628ab5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 582964, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas B - 2", 3 },
                    { new Guid("39295dd1-ce05-45eb-bda5-9c2d741aa902"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 695025, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas B - 3", 3 },
                    { new Guid("3a7d5499-942a-4878-a567-50719ca4ed1c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 928842, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas A - 2", 5 },
                    { new Guid("3b3cd082-9f38-4e40-abc8-f29cec9595b0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 576373, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Limited Edition - 5", 5 },
                    { new Guid("3b3e044c-8472-489f-9625-9ea520edf42c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 993470, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Limited Edition - 5", 3 },
                    { new Guid("3b60743a-1850-4240-859c-f118ed9376dd"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 928502, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas A - 3", 4 },
                    { new Guid("3beba81e-66ac-4070-88f6-3d0e284f93d6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 718639, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas B - 5", 4 },
                    { new Guid("3bf383e1-8315-402b-9421-40b03695c23c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 915459, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Special Edition - 4", 3 },
                    { new Guid("3c0ab6f9-4a93-4b76-a4b5-f6b0f30ccad8"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 867977, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas B - 2", 3 },
                    { new Guid("3c740e8d-fd37-4abd-8f41-b3583f7609ec"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 523850, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas A - 4", 4 },
                    { new Guid("3dfe7297-f0b8-407c-b715-01f491f56a0f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 754095, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Special Edition - 3", 4 },
                    { new Guid("3e5c5efb-d81e-4f08-80ed-e5ad1e36e6b6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 935502, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Limited Edition - 5", 3 },
                    { new Guid("3ebc64a5-e04b-4cd1-8c7b-1cc74207721b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 767094, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Limited Edition - 5", 4 },
                    { new Guid("3f1ec0ec-b192-420b-b783-e5375a4ab71b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 637794, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas A - 4", 3 },
                    { new Guid("3fe48533-1808-4b5c-8101-b084e8dec022"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 814142, new TimeSpan(0, 0, 0, 0, 0), "Model AB Special Edition - 4", 3 },
                    { new Guid("4141d542-31db-4760-b759-b22ac4be9854"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 766327, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas A - 2", 3 },
                    { new Guid("41a025b9-ad8a-4ffd-9987-2562c00d3c5a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 542149, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas B - 5", 4 },
                    { new Guid("420153c8-bbd1-4725-8487-e61c40df7dfe"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 562409, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Limited Edition - 3", 4 },
                    { new Guid("423c6046-b2e7-4d0e-b1ad-469c67565616"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 631204, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Special Edition - 1", 3 },
                    { new Guid("426c68df-a8fd-4e64-856c-81fb8490c49e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 808521, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Limited Edition - 4", 5 },
                    { new Guid("432d4dd0-b9fd-4f37-8c89-c17c0ef7f3c6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 539426, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Limited Edition - 4", 3 },
                    { new Guid("4345ffb7-61d5-416c-84e1-5505c9f8de2d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 962187, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas A - 1", 4 },
                    { new Guid("4352a249-c78b-494d-b4c5-505bebcd3000"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 877555, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Special Edition - 3", 5 },
                    { new Guid("43554d57-dfff-4a89-a62d-a540b0292218"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 584307, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Limited Edition - 5", 5 },
                    { new Guid("43650081-90c6-4009-abf7-79f3b134f869"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 510067, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas A - 3", 4 },
                    { new Guid("439db417-777b-4424-b41b-b2a81019b4da"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 635696, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Special Edition - 2", 4 },
                    { new Guid("44717ab0-fdbd-4f24-bb2b-7cc28552e72a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 666995, new TimeSpan(0, 0, 0, 0, 0), "Super AA Special Edition - 1", 5 },
                    { new Guid("4474a38b-10f3-44d6-81ae-b3ad6702674d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 666101, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Limited Edition - 2", 4 },
                    { new Guid("469deb42-63ff-4f69-a74c-2d10b032dfe0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 805237, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas A - 3", 4 },
                    { new Guid("469ee4be-3377-4395-a93d-8116ffbc7ce6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 655640, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Special Edition - 2", 5 },
                    { new Guid("469f24f2-b05a-4680-b413-111fe96ccc94"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 953393, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas A - 4", 5 },
                    { new Guid("47061b90-87bb-4556-a41c-53d05d5dcdbd"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 782570, new TimeSpan(0, 0, 0, 0, 0), "Super AB Limited Edition - 3", 4 },
                    { new Guid("472041f4-15c7-46e8-94a1-5a6fb973f04c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 829759, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas A - 2", 4 },
                    { new Guid("47671357-fed7-4da9-90e3-1ad90add8ee2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 599119, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Special Edition - 3", 3 },
                    { new Guid("485a54df-1e5d-4c59-acdf-a94cb3cb6fd0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 898460, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Limited Edition - 4", 5 },
                    { new Guid("4865858b-be6e-4964-bd0b-91c35f746e0a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 736285, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Special Edition - 5", 4 },
                    { new Guid("48fb23e5-dcbc-4a7c-9260-f51020c86051"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 547075, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas A - 5", 3 },
                    { new Guid("490b0b77-3e76-4071-b62a-30322fa607de"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 980432, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Special Edition - 1", 4 },
                    { new Guid("491b5001-c72a-40ca-8f17-8f56736ed15c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 852107, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Special Edition - 5", 4 },
                    { new Guid("4aca0502-c99a-4d8a-893f-e15fed3b90ed"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 589660, new TimeSpan(0, 0, 0, 0, 0), "Model AA Limited Edition - 5", 3 },
                    { new Guid("4b23f8b8-f13c-4547-8b21-c86f601afdae"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 888113, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Special Edition - 5", 3 },
                    { new Guid("4b2c2546-28a5-4230-afd0-c6d419b22bc9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 918657, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Special Edition - 3", 4 },
                    { new Guid("4b2fd40a-f090-46f9-b16d-156923078194"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 822240, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas B - 4", 5 },
                    { new Guid("4b9d1537-ea41-4df2-acce-d0228146bda2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 924496, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Limited Edition - 4", 5 },
                    { new Guid("4cce09fd-d6e7-4130-a8fe-23b1b44bc886"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 503918, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Special Edition - 5", 4 },
                    { new Guid("4d259f53-7b8e-474a-b3de-1cd15d6fa798"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 746793, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Limited Edition - 5", 3 },
                    { new Guid("4d70b4f4-36f0-4335-b501-3263000d6a9d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 744162, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Special Edition - 4", 4 },
                    { new Guid("4dbf661d-e59f-4549-99d2-984382e3ef54"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 946333, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas A - 3", 3 },
                    { new Guid("4e5336f3-5535-4183-b480-ffb5005c6992"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 561495, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas B - 1", 3 },
                    { new Guid("4e72e26b-cb46-4758-9b5b-20fdb83e1649"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 721190, new TimeSpan(0, 0, 0, 0, 0), "Super AB Limited Edition - 1", 3 },
                    { new Guid("4e77b85c-839f-4596-8800-b40f7921821c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 806762, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas B - 5", 5 },
                    { new Guid("4ef1395d-ff7b-4c6c-88a6-84634216d764"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 792727, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas B - 3", 5 },
                    { new Guid("4f2d653f-2a93-4a01-8d4b-36fcbba227b6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 897961, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas A - 1", 4 },
                    { new Guid("4f306db1-61a7-478a-9fb0-69c91ba44ca7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 677967, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas B - 4", 5 },
                    { new Guid("4f6cec1d-9049-4d6d-a7d8-47d149a3a23c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 632125, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Limited Edition - 5", 5 },
                    { new Guid("4ffa5427-b4cd-40c1-abc5-9bf5fb1191e1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 529122, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Limited Edition - 2", 4 },
                    { new Guid("507a9826-6301-4ed2-af6a-032eefc40399"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 605503, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas B - 4", 5 },
                    { new Guid("508abaef-724c-4ce1-923e-cb733bcfe644"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 651007, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas B - 3", 4 },
                    { new Guid("5101a9d8-91d3-48af-889d-ccff56447240"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 542474, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Special Edition - 1", 4 },
                    { new Guid("510401ad-ba77-442d-b3b7-2f77a6d0e678"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 604256, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas B - 5", 5 },
                    { new Guid("5211d06a-528f-414f-aeca-1e0fd90a08f3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 624017, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Limited Edition - 2", 4 },
                    { new Guid("52701d3f-6b69-428f-880b-e47caffcfcd0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 870214, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Special Edition - 4", 4 },
                    { new Guid("53213d21-a528-4f68-a52d-53777cc1af35"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 655234, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Limited Edition - 4", 5 },
                    { new Guid("54454ea8-434a-46d3-b795-75b99415f32c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 551403, new TimeSpan(0, 0, 0, 0, 0), "Super AB Special Edition - 2", 3 },
                    { new Guid("545c3597-792a-40f9-b16c-87ddca8a85b7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 516784, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas B - 1", 5 },
                    { new Guid("5571756b-3851-4a0e-9063-25cbace18dd2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 606718, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Limited Edition - 5", 3 },
                    { new Guid("55871719-fc69-43a5-b631-9601a1396a43"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 506824, new TimeSpan(0, 0, 0, 0, 0), "Model AA Limited Edition - 2", 3 },
                    { new Guid("5792ed09-9b24-4643-9c72-b5dd3380df8e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 685431, new TimeSpan(0, 0, 0, 0, 0), "Model AB Special Edition - 3", 3 },
                    { new Guid("57fabb76-c7b6-4b46-819a-85e79500188d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 888030, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas A - 1", 5 },
                    { new Guid("580ee8db-47c4-4775-89c1-7d78b695c533"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 522389, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas B - 2", 5 },
                    { new Guid("5840c76d-4f8d-4a46-a3be-704aff9b2556"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 564957, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas A - 5", 3 },
                    { new Guid("58fcfeda-057e-4961-a7ef-0b8bc33ab097"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 728143, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Limited Edition - 2", 5 },
                    { new Guid("5a5135a5-c3e3-4dc6-afcb-7295d6b1bc11"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 506189, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Special Edition - 4", 4 },
                    { new Guid("5aa8816b-7b4e-47a6-a662-0b051d87e395"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 627800, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Special Edition - 1", 4 },
                    { new Guid("5c431acb-5c4b-4585-bfe2-a0f8f3a4549f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 727250, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas A - 2", 4 },
                    { new Guid("5ca50c26-9f91-4ac0-ac48-a3ae83344709"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 875017, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Special Edition - 5", 3 },
                    { new Guid("5ce736c2-ed40-4ecb-b8e7-7315ed497adb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 848853, new TimeSpan(0, 0, 0, 0, 0), "Super AA Limited Edition - 3", 5 },
                    { new Guid("5d5413e1-6470-4f23-b0db-2590835a66f4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 698153, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Special Edition - 3", 3 },
                    { new Guid("5d80f6a1-deac-475a-bd86-93f32ca1b5a3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 667734, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas A - 1", 3 },
                    { new Guid("5d8fe336-883a-41e0-a9ac-8913e324e3a3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 942290, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Limited Edition - 1", 3 },
                    { new Guid("5e0d07a9-95da-440f-957c-0cfe83fcb56c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 523119, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas A - 1", 4 },
                    { new Guid("5e992f0f-ad07-4a3d-bd66-386a4d083175"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 500180, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas A - 2", 4 },
                    { new Guid("5feaf5f6-5d47-4f95-8d70-938e39b98fbc"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 595415, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Special Edition - 4", 3 },
                    { new Guid("5ffe62ae-3bd0-458e-add0-a0e200c0eb3c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 667083, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas B - 2", 5 },
                    { new Guid("60a31cb9-6b93-4237-8e80-aa1e77c0dbf8"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 857037, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas A - 4", 3 },
                    { new Guid("6125b5c6-2c41-4ced-a02f-85f51c22ebaf"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 959056, new TimeSpan(0, 0, 0, 0, 0), "Super AA Special Edition - 5", 5 },
                    { new Guid("612b293c-327e-4222-91bf-7d35883348de"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 820372, new TimeSpan(0, 0, 0, 0, 0), "Super AB Limited Edition - 2", 5 },
                    { new Guid("62b9e7a6-cd87-482f-84a6-b8dc64c0beeb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 643187, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas A - 1", 5 },
                    { new Guid("631e382b-a9eb-412f-9b6d-b7b87f616369"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 979692, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas A - 4", 4 },
                    { new Guid("635182c5-308a-455c-aece-17b527543ccb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 575345, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas B - 3", 5 },
                    { new Guid("6371f3f1-157e-40a0-97c4-b2895fcaea5b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 625943, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Limited Edition - 2", 3 },
                    { new Guid("64b593b7-c739-4f87-9c63-814cd79aed84"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 569136, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas A - 4", 4 },
                    { new Guid("652480d0-94ea-4340-8619-5ff52985ab25"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 908603, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas A - 2", 4 },
                    { new Guid("659cada7-1197-4265-8557-9fea5b3b87bc"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 898841, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas B - 4", 4 },
                    { new Guid("66b8814c-ffee-4050-8d39-b68c85615d7b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 633813, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas A - 3", 4 },
                    { new Guid("6710e426-5b92-4a42-b0cc-50bb3dd3a747"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 906984, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Special Edition - 2", 4 },
                    { new Guid("67bb86f9-b625-4c05-a9dc-b99234185f81"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 896894, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Limited Edition - 1", 5 },
                    { new Guid("67bc3a3c-d040-446c-a108-29d995b7afb7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 570025, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas A - 2", 4 },
                    { new Guid("67f7b055-7095-4c11-ba18-72d7bf27bfae"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 925530, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas A - 3", 3 },
                    { new Guid("68071448-afa1-4b6d-b767-99ca76d44895"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 924444, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Limited Edition - 3", 5 },
                    { new Guid("698045d0-e6f7-48f5-bacf-43d861f5314d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 584874, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Special Edition - 3", 3 },
                    { new Guid("69a3d8a2-7fac-484b-b1a9-1e5819720016"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 908495, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Limited Edition - 3", 4 },
                    { new Guid("6a9c4f8b-0ab1-42ca-ac9a-1bf86891b985"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 862964, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Special Edition - 3", 3 },
                    { new Guid("6aaeb399-5c7d-4509-99a9-96bdffeba8f9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 632235, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas B - 3", 4 },
                    { new Guid("6abd33e5-08fd-48f7-89dc-b188e0bb08f3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 553420, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Special Edition - 2", 3 },
                    { new Guid("6af64bf1-02a5-411f-a2fe-e309e9e1fa8a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 875832, new TimeSpan(0, 0, 0, 0, 0), "Model AB Limited Edition - 1", 3 },
                    { new Guid("6af97a4f-c329-496b-8365-2dc5d2568cec"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 803451, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Special Edition - 4", 3 },
                    { new Guid("6b292316-bf41-42b0-b549-8a3e5b268309"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 931720, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Special Edition - 3", 4 },
                    { new Guid("6c245083-3e7b-4330-b1d9-dba9a6adacb3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 504484, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas B - 3", 5 },
                    { new Guid("6c92093f-1f6c-4ff5-b7dc-394ffad6725c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 682039, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas B - 1", 3 },
                    { new Guid("6cb5d7ec-d1a0-45d4-bc55-539fb596794b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 943182, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Special Edition - 5", 4 },
                    { new Guid("6d8c6ab9-1b42-4115-adca-3ed6d5cad0c6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 679484, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Special Edition - 3", 3 },
                    { new Guid("6d8fce78-9973-4e18-8d48-c48ea8ae0076"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 635591, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas B - 2", 3 },
                    { new Guid("6dd328e9-01fb-4de7-b60a-a6b27f71b796"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 750327, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas B - 1", 3 },
                    { new Guid("6e5b9901-3ef8-4020-8c9b-65cbd350c497"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 829945, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Limited Edition - 3", 4 },
                    { new Guid("6ec4b901-1f24-459e-b6c9-b830e65b163e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 993807, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas B - 5", 5 },
                    { new Guid("6eec1086-559d-4baf-b620-361d32bdd59f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 614935, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Limited Edition - 5", 3 },
                    { new Guid("6f2ff252-8e67-4387-b95b-09a3a9494c25"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 991820, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Special Edition - 1", 3 },
                    { new Guid("6fa6b813-8989-44e8-96ff-fc41a18f66b2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 961070, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas A - 5", 3 },
                    { new Guid("6fc523de-c105-41c3-a070-7bb0613ff15f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 842173, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas B - 4", 4 },
                    { new Guid("6fcb713d-1761-4e7f-9f95-ae9def3a6230"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 687076, new TimeSpan(0, 0, 0, 0, 0), "Super AB Special Edition - 1", 3 },
                    { new Guid("6fddde8e-c478-4444-96f4-2b9b15335e7f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 624742, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas B - 5", 4 },
                    { new Guid("700a9a21-2bf0-4de8-a035-ef943b44ef65"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 993899, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas A - 4", 5 },
                    { new Guid("7119893c-550e-4bd1-a90b-7c45d87f32ac"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 739850, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas A - 2", 4 },
                    { new Guid("71b32e02-2f4b-4461-9ca4-a74567ddb9aa"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 916983, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Limited Edition - 1", 5 },
                    { new Guid("71bed763-475a-4732-890c-a4af68772229"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 777298, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Limited Edition - 2", 5 },
                    { new Guid("7274b86b-4a93-468d-b51e-e66001c5b012"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 848765, new TimeSpan(0, 0, 0, 0, 0), "Super AA Special Edition - 4", 3 },
                    { new Guid("730a12c6-865c-437a-864f-c6d9a509e809"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 871782, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas B - 2", 5 },
                    { new Guid("73a969c1-dba7-4c55-8935-d43be7fe592b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 997019, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas B - 5", 5 },
                    { new Guid("742203c0-cb6d-4b8b-a4da-14e57b85e702"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 666300, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Limited Edition - 3", 5 },
                    { new Guid("745dcc09-cbae-4d1a-908c-5e525f5886d2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 816370, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas A - 5", 5 },
                    { new Guid("7469f228-ce3a-415a-864c-2413085d88ee"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 777653, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas B - 4", 5 },
                    { new Guid("74e94db3-301c-4166-9fab-43413b850633"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 823185, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas A - 2", 3 },
                    { new Guid("75f03061-774d-42a1-b4e5-f671d970205a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 909284, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas A - 1", 3 },
                    { new Guid("765c01a5-8c5a-439b-adbf-ac4098021322"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 806654, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas B - 1", 3 },
                    { new Guid("773bc000-46ff-47ff-8ae7-b905a8c6e895"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 865175, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Limited Edition - 4", 5 },
                    { new Guid("77482604-e6cb-4753-8c71-aad30189cecc"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 858201, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas A - 4", 3 },
                    { new Guid("780a08e3-1169-4dd2-8f0d-bfb5fafd8135"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 957410, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas A - 5", 5 },
                    { new Guid("783bb203-0b30-43d7-b140-f96d6c4bbdb9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 533593, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Limited Edition - 5", 4 },
                    { new Guid("7a6d4626-a349-4bbe-9bf5-be018616cfc1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 606367, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas B - 1", 5 },
                    { new Guid("7a6f8563-b296-4d86-9154-8e5b4de5e67b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 663110, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Limited Edition - 3", 4 },
                    { new Guid("7b74e95c-f0ca-4319-8d9c-5c5a7feff45f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 894318, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas A - 4", 4 },
                    { new Guid("7c16a30c-c378-456e-86a7-568871bd77be"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 765319, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas A - 4", 3 },
                    { new Guid("7e019ad3-6f2c-4d3e-a8aa-0b0e4b3357e1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 505689, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Limited Edition - 5", 5 },
                    { new Guid("7f115f92-0ac9-43a6-a3c6-f57fad2215e4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 992692, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas A - 3", 4 },
                    { new Guid("7ff5879b-eeef-46d1-9218-ab95bd22d35a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 577059, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas A - 3", 4 },
                    { new Guid("80914a49-e270-4322-b748-d4a72f6ff34b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 822873, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Limited Edition - 4", 5 },
                    { new Guid("809235f8-a16e-4a85-b547-875b63f6114f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 774766, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas B - 1", 4 },
                    { new Guid("80adc88e-5124-4036-ab18-0a8bebcd0b75"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 721392, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Special Edition - 4", 4 },
                    { new Guid("81e1e5ce-7af6-4528-b9ca-e2225b6f3643"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 905958, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas A - 2", 4 },
                    { new Guid("81ff70a0-7c64-4b69-93f6-4d54691745bf"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 829345, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas B - 1", 4 },
                    { new Guid("82440fdb-3856-4b8c-aef8-31fc1df1bae7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 847873, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas A - 1", 5 },
                    { new Guid("826dc01a-297a-4c02-b732-44c253d142d5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 989431, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Special Edition - 3", 4 },
                    { new Guid("828e5900-372d-468f-8528-077f0fbcc2f1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 925817, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas B - 4", 5 },
                    { new Guid("82bd8a1d-56a8-4783-b9e8-b3a304ea7a56"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 598370, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Special Edition - 5", 4 },
                    { new Guid("82c3ad63-99fb-4a22-b1b8-8a51a25efc0a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 838532, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas B - 3", 3 },
                    { new Guid("831b7371-458c-4087-a669-15df492b7136"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 696316, new TimeSpan(0, 0, 0, 0, 0), "Model AB Special Edition - 2", 3 },
                    { new Guid("8377432a-acf0-473e-bb3a-1eae763fcb79"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 706918, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Special Edition - 5", 3 },
                    { new Guid("83c58aab-f1ba-465d-a872-086ce7b74516"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 923718, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas B - 3", 4 },
                    { new Guid("844ace32-bd60-40cd-81c9-eae59902a443"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 893666, new TimeSpan(0, 0, 0, 0, 0), "Super AA Limited Edition - 1", 5 },
                    { new Guid("84d77b73-5e62-4625-aaa7-4caea575b3da"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 872004, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas B - 2", 4 },
                    { new Guid("8556cb41-04a2-48b6-b647-8935a79cd99a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 823407, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Limited Edition - 3", 4 },
                    { new Guid("8582e4ee-a14a-442b-b67e-3798cb33b2c3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 590815, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Limited Edition - 4", 3 },
                    { new Guid("86a791bc-4e24-4eb2-8017-a45af8f656c7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 537204, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas A - 4", 5 },
                    { new Guid("86e320d4-4be9-4939-bc30-00a3a0d04b63"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 595011, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas A - 3", 3 },
                    { new Guid("86f136d0-8da8-46df-89ed-d6349c5e38b4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 562335, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas B - 5", 3 },
                    { new Guid("8704bca2-ad91-46e2-94b2-d573e9292d0e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 600245, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas A - 3", 4 },
                    { new Guid("878655db-3907-47e7-9834-76972298766f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 869052, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Limited Edition - 3", 4 },
                    { new Guid("87c6480c-e981-4417-b7ff-560d27a966d9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 963186, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas B - 4", 5 },
                    { new Guid("88381bdb-cc0b-4cfe-bc91-1377f929c23e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 644229, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Special Edition - 3", 5 },
                    { new Guid("89eb2677-ac8e-4305-9241-344374002804"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 879338, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Limited Edition - 4", 4 },
                    { new Guid("8a299483-eab3-447e-9a4c-c878bf77b98b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 999817, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Special Edition - 3", 4 },
                    { new Guid("8a576cf4-db98-44c4-99f2-5caa7868e186"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 524907, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas B - 2", 3 },
                    { new Guid("8a793cf9-2dca-469b-b4aa-14bf2287d4c9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 967710, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Limited Edition - 2", 4 },
                    { new Guid("8b0327ef-bae9-4474-9d36-8ae1609c20a3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 852430, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas B - 5", 4 },
                    { new Guid("8b07ecdb-c6d7-4b3f-9e54-ccf2adec6d9f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 978140, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Special Edition - 4", 3 },
                    { new Guid("8b698228-a6ed-4b33-8104-039c40509d47"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 915531, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas B - 4", 3 },
                    { new Guid("8c407314-02d0-4621-b9a2-0d0e33c26a65"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 598211, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Limited Edition - 2", 3 },
                    { new Guid("8ca6e164-eccd-40f2-a102-d5f1f6aef57a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 840363, new TimeSpan(0, 0, 0, 0, 0), "Super AB Limited Edition - 4", 5 },
                    { new Guid("8ec3ccd4-740a-4dcd-9ff1-3a3cbe32cec4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 663009, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Special Edition - 2", 4 },
                    { new Guid("8ed14318-4f77-46ed-b95f-b326b4f4e173"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 506946, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Limited Edition - 3", 3 },
                    { new Guid("8fb985ca-5831-4c22-8c47-2290b8c4b578"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 776521, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas A - 3", 4 },
                    { new Guid("8feeb364-2508-491d-9452-59f5ee813225"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 568832, new TimeSpan(0, 0, 0, 0, 0), "Model AA Limited Edition - 3", 5 },
                    { new Guid("8ff6689b-d986-4d83-8f3a-04220d2136fd"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 587757, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Limited Edition - 5", 5 },
                    { new Guid("90645733-5c43-475a-aa4e-1779eac70205"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 832297, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Special Edition - 5", 5 },
                    { new Guid("90852f2d-fd97-44ed-a12f-d72f83e672fd"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 615680, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas A - 1", 5 },
                    { new Guid("9094e853-750e-48c7-bb51-bfeab174e777"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 580465, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas B - 1", 4 },
                    { new Guid("90b7a7a7-6bf7-4800-9a33-32e4e72056d9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 973840, new TimeSpan(0, 0, 0, 0, 0), "Super AA Special Edition - 2", 3 },
                    { new Guid("915023c5-aeba-4369-852c-0f1a97e0254d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 882105, new TimeSpan(0, 0, 0, 0, 0), "Super AB Limited Edition - 5", 4 },
                    { new Guid("91a9446d-b98d-429f-b140-a8e70791024b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 875887, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Limited Edition - 3", 4 },
                    { new Guid("91bb2ce9-1804-431f-9f07-5933a46a9806"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 628097, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas A - 4", 5 },
                    { new Guid("91d9a5f9-6995-491d-840b-55c715149298"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 956011, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas B - 4", 5 },
                    { new Guid("928a2c60-35e4-4906-a24b-8528d29a27c4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 507849, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas B - 2", 5 },
                    { new Guid("929e3cad-8a92-4436-b8b2-0f01e338c5e6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 796668, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas A - 2", 5 },
                    { new Guid("94c3f4e4-437c-4853-936e-9c541d6f7d80"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 894555, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas B - 3", 5 },
                    { new Guid("951d18d6-b1dc-4990-9174-40a88338a228"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 768779, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Special Edition - 2", 4 },
                    { new Guid("955dfc30-7867-4f76-8215-706538a25463"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 699941, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Special Edition - 5", 5 },
                    { new Guid("95e54257-7578-497f-bb17-3afcbeb4ad92"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 862939, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas B - 4", 3 },
                    { new Guid("971e078a-089c-4a6f-9070-7e2bfcfff93e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 796259, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas A - 5", 4 },
                    { new Guid("98e21dca-22d0-4e11-abdb-d4d99a4bc9cc"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 526494, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Limited Edition - 2", 3 },
                    { new Guid("99803be4-caba-416b-9230-4eb6436f07bc"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 735510, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Special Edition - 2", 5 },
                    { new Guid("99c3e86b-3a22-4136-81a5-46d7bc0aff86"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 673701, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas A - 1", 3 },
                    { new Guid("9a0b06eb-c5d7-4f7e-8d2b-faa8d0e7e7f2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 579245, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas B - 1", 5 },
                    { new Guid("9ab17ad4-8aeb-49d2-acea-f0cd6986c33a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 506149, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas A - 2", 3 },
                    { new Guid("9ac2f8ed-9519-4ac0-bddb-ea1bc95ab339"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 796860, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas A - 2", 3 },
                    { new Guid("9c3bcb68-7eb8-4247-9ef2-24849b12deff"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 765986, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas A - 2", 4 },
                    { new Guid("9e1b987b-ddf6-4bb9-9540-ea2c74e6671a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 977436, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas A - 2", 4 },
                    { new Guid("9ef6316b-bb3f-4b1c-9e5c-221934ad9253"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 587764, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas A - 4", 5 },
                    { new Guid("9f82e34d-7c60-4414-917c-9511aac03b44"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 650199, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Special Edition - 1", 5 },
                    { new Guid("9fc988ff-763c-4bb2-a922-8a96641f457b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 705782, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas A - 4", 3 },
                    { new Guid("9fff0669-7820-4bf2-9691-34f1083021f0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 630854, new TimeSpan(0, 0, 0, 0, 0), "Super AB Special Edition - 5", 3 },
                    { new Guid("9fff4085-d158-4c08-b1d5-d92f1998be90"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 988344, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Limited Edition - 1", 4 },
                    { new Guid("a059034b-be41-47ba-abec-9607b6152767"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 680700, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas B - 5", 5 },
                    { new Guid("a0878580-899c-4c3f-a59d-09c23a00b16e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 922616, new TimeSpan(0, 0, 0, 0, 0), "Super AB Special Edition - 3", 3 },
                    { new Guid("a097400c-866b-4385-8fc2-191efb6f0266"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 808944, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Special Edition - 2", 3 },
                    { new Guid("a0a61c31-9cdb-4fcb-b979-3b1316a285f3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 610355, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Limited Edition - 3", 5 },
                    { new Guid("a1150c08-23a0-4467-8fa6-b7892470877d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 869971, new TimeSpan(0, 0, 0, 0, 0), "Model AB Special Edition - 5", 3 },
                    { new Guid("a1176983-b252-450f-9bd3-589a481219ff"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 650473, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas B - 5", 4 },
                    { new Guid("a1aa7e84-a835-42e7-8fb3-e8f88523dbc5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 564535, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Special Edition - 4", 4 },
                    { new Guid("a1afb1ff-5dd6-46dd-a870-307a7c139884"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 933068, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas B - 4", 3 },
                    { new Guid("a3af2423-c815-48dd-8c1c-09c4fdc1543e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 735039, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas B - 2", 3 },
                    { new Guid("a3d9a56c-5a11-421c-9d74-6607cc5ea992"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 695913, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Special Edition - 3", 4 },
                    { new Guid("a4d7bb64-5dec-4872-9607-cd84846af859"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 698858, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas A - 3", 5 },
                    { new Guid("a5446f3c-53f6-4eac-b452-cd1fc81f7ee9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 616262, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Limited Edition - 3", 4 },
                    { new Guid("a609d5ea-1dc7-4627-bc23-4bd95333aee8"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 722644, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas B - 3", 4 },
                    { new Guid("a6db8292-7be4-41e1-8d28-bea7d2e19bcf"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 590467, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas A - 5", 5 },
                    { new Guid("a75751af-a8f9-487d-b6bc-39cb1b77b5b7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 647226, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas B - 3", 3 },
                    { new Guid("a760e03c-8d75-4f2d-92d4-675988c69c3f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 901556, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas A - 5", 4 },
                    { new Guid("a7ee43ae-49cc-44e8-817f-60688061577b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 874910, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas B - 4", 3 },
                    { new Guid("a80cf1dd-56db-4406-861c-bbc39249ade2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 939760, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas A - 3", 3 },
                    { new Guid("a8549cab-c753-45a4-9702-8aaed592c1d4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 839169, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Special Edition - 3", 5 },
                    { new Guid("a8d69106-6e59-4fb3-9e65-818e3fdfa0b5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 920220, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas B - 3", 5 },
                    { new Guid("a8eeddab-866d-4832-95e2-1cdf1ad7998c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 663348, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Special Edition - 1", 3 },
                    { new Guid("a9928f29-4785-4421-9329-67a90d5693eb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 811158, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Special Edition - 1", 3 },
                    { new Guid("a9b54314-e209-4ed4-9a83-262d550c50a4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 745487, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Limited Edition - 5", 4 },
                    { new Guid("ab73f000-69a2-492b-be20-b89f5a6937e2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 594803, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Special Edition - 1", 5 },
                    { new Guid("abfcd021-b52d-462d-b016-42c876d63f85"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 885255, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas B - 5", 4 },
                    { new Guid("accdce45-a4f4-434e-ba7e-1c5c7ae0d693"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 506194, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Special Edition - 4", 4 },
                    { new Guid("ad45f9a7-dbe6-4a7c-be29-1d4211135bdd"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 977123, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas B - 5", 3 },
                    { new Guid("adf181d1-ad25-44ae-a2a1-b941d899ee23"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 860399, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Limited Edition - 3", 3 },
                    { new Guid("ae1e0f0e-906c-45a8-912c-d6988af7e7da"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 971346, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas B - 2", 5 },
                    { new Guid("ae32e880-0967-4acb-936d-302eaa5ccc11"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 869453, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Limited Edition - 4", 4 },
                    { new Guid("ae91d12e-301d-44cd-9ce8-6f9a02158df1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 798871, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Limited Edition - 1", 4 },
                    { new Guid("aed8324c-9a6b-44cd-b257-e651576350b4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 679474, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas B - 3", 5 },
                    { new Guid("b016767f-e64c-4211-9531-e331ecea2ff1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 646950, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Limited Edition - 2", 5 },
                    { new Guid("b06d2b42-3034-4403-a214-d16affef847f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 887644, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Limited Edition - 3", 5 },
                    { new Guid("b1da5b65-ae8d-4f48-a5ab-d447a4f3542b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 828283, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas B - 3", 3 },
                    { new Guid("b1de3b55-cc2e-4c7c-8be2-67850a2e6cf8"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 682187, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Special Edition - 1", 4 },
                    { new Guid("b1e4df40-2d86-44c4-8a30-da09f3d2a838"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 870918, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Special Edition - 5", 3 },
                    { new Guid("b2ad3e79-e290-42bb-b7ae-784463423ac0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 591436, new TimeSpan(0, 0, 0, 0, 0), "Super AA Limited Edition - 5", 3 },
                    { new Guid("b3ada853-5101-416a-96ec-fac786a34fa7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 557036, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Limited Edition - 1", 3 },
                    { new Guid("b6137169-2e8a-46ed-b57c-f681852e7d50"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 915124, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas A - 2", 4 },
                    { new Guid("b618725d-6cde-47af-a148-39049db03be9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 785738, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas B - 3", 4 },
                    { new Guid("b6a95e93-9e61-4953-896f-da0a387c2763"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 707533, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas B - 1", 3 },
                    { new Guid("b7215e3e-50eb-4085-9a6d-df5354d435e9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 992738, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Special Edition - 5", 4 },
                    { new Guid("b7777947-4acb-494e-829e-3927ed5a3711"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 677848, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas A - 4", 3 },
                    { new Guid("b786a392-7431-4d5e-b87d-70009f7605d2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 528944, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas B - 1", 3 },
                    { new Guid("b7a330c4-336a-4df5-bc9c-08155e868a67"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 875187, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas B - 1", 3 },
                    { new Guid("b7d32cee-67df-4cb3-a153-e46dd3b914a6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 693490, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Special Edition - 4", 3 },
                    { new Guid("b7dfc4e2-7a5d-4d93-879c-b29a478fbd79"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 636359, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Limited Edition - 4", 5 },
                    { new Guid("b915bfc2-5556-4b76-8143-822e3c599e0e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 546839, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas A - 1", 3 },
                    { new Guid("bb8d5b94-a77e-43a1-888a-a660f65253d0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 768291, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas A - 5", 3 },
                    { new Guid("bc078244-adbc-4a03-b2d2-864d58c4cfb9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 981857, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Limited Edition - 5", 5 },
                    { new Guid("bd9a0aff-b9ff-4f0e-9b56-212c285bc28e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 536074, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Limited Edition - 1", 5 },
                    { new Guid("be1764f3-1e99-4eff-a7f5-59e41605c5fb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 521490, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas A - 5", 4 },
                    { new Guid("be925fa0-e1b6-454a-8399-292513fc0626"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 612913, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Limited Edition - 4", 3 },
                    { new Guid("bea29f4b-c3f9-4bbc-b78e-e82da08f0adf"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 635927, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas B - 5", 5 },
                    { new Guid("bea7fde2-9d8a-4146-8e0f-1dd1631e5a5a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 885552, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Limited Edition - 1", 4 },
                    { new Guid("bef999a5-103f-4f68-8ae9-16897e234c06"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 596479, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas B - 1", 5 },
                    { new Guid("c056bcd5-16c4-4054-b522-af17b609133d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 525081, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Limited Edition - 2", 3 },
                    { new Guid("c15058f3-5b34-4d8b-bdb4-11f29996dec0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 535290, new TimeSpan(0, 0, 0, 0, 0), "Model AB Kelas A - 5", 4 },
                    { new Guid("c19d9f41-f379-43b9-87ba-9aa0b656aeee"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 960577, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Special Edition - 4", 3 },
                    { new Guid("c27af264-e0df-4c30-8b48-fc47cb65c3dc"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 830431, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Limited Edition - 2", 3 },
                    { new Guid("c32bd3d6-88fa-4546-ac89-9f4dbe67d589"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 571720, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas B - 2", 5 },
                    { new Guid("c372fac0-b486-449d-8716-7d67ab5e3175"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 745036, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas A - 5", 5 },
                    { new Guid("c49fa8e9-8eae-436f-95a7-0ae1ba545fad"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 791793, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Limited Edition - 4", 3 },
                    { new Guid("c53ccd6a-2584-4777-b7c4-7ff68e48bee5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 892531, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Special Edition - 1", 4 },
                    { new Guid("c54d686c-6cce-41e4-b9a9-5e0c01001c65"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 574956, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Limited Edition - 2", 5 },
                    { new Guid("c6354158-2f12-4835-bdde-999aa7c4700b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 716769, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas B - 3", 4 },
                    { new Guid("c6df6f05-31da-444a-9830-d00fafa144a2"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 644554, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas A - 4", 4 },
                    { new Guid("c71cfe00-5be1-49ca-ac88-5b0c9b845fc5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 555229, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Limited Edition - 3", 5 },
                    { new Guid("c725d810-79b5-4913-b9ff-d0adfe566103"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 631034, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Limited Edition - 4", 3 },
                    { new Guid("c8788266-b81b-4e5e-9371-6bd7c24ef0be"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 557183, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Limited Edition - 4", 4 },
                    { new Guid("c8949548-1eb8-4532-8681-faaa5077083d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 973844, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas B - 4", 5 },
                    { new Guid("c8b7b3ad-0f5b-4c4c-a357-d140f1a7026d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 543620, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas A - 5", 4 },
                    { new Guid("c93b0381-0699-4fa8-a178-da2fd5425aea"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 589869, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas A - 1", 5 },
                    { new Guid("c974d660-dba3-4387-b11a-772b21e6ec39"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 625915, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Kelas A - 5", 4 },
                    { new Guid("c9ecec5a-35e8-42c0-b5e8-8bc6a2c325ba"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 829228, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas A - 3", 5 },
                    { new Guid("cabe86e3-d424-4b49-ae7c-9485dc104984"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 990623, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas A - 5", 4 },
                    { new Guid("cb068309-9b49-43e6-b213-51acd5a8f11b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 624202, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Limited Edition - 3", 4 },
                    { new Guid("cb7083fb-b6f0-459e-9eeb-deccdc2aa0c0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 676044, new TimeSpan(0, 0, 0, 0, 0), "Model AB Special Edition - 1", 4 },
                    { new Guid("cb940e8d-5526-40cb-b729-70fccf68bacb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 732099, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas A - 5", 3 },
                    { new Guid("cbe515da-e6e4-4ef3-ab1c-d1212a28ed07"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 993787, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas B - 2", 3 },
                    { new Guid("cca664d5-c65e-401f-bb88-6d92b0623f35"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 594517, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Special Edition - 1", 5 },
                    { new Guid("cdd40473-634f-44ca-addc-835a8983d566"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 865972, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Limited Edition - 2", 3 },
                    { new Guid("ce29e609-48fd-4b41-bbfd-a9950f037016"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 508616, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas B - 1", 4 },
                    { new Guid("cee3d3b2-0b52-44c7-ab57-42c6e07b1b8e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 750401, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Special Edition - 2", 5 },
                    { new Guid("ceefac59-706e-4cfc-b369-7f0415b90e6d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 941732, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Limited Edition - 1", 3 },
                    { new Guid("cff1403f-6c1a-40e0-803e-0339a7b86207"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 836196, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Special Edition - 1", 3 },
                    { new Guid("d03b43e4-5088-4ecc-ab3e-dbe3f86d811e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 781233, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Special Edition - 3", 4 },
                    { new Guid("d072db1c-de97-45f7-a908-97e0d28a5773"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 913033, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas B - 1", 5 },
                    { new Guid("d166262c-9e51-440c-b660-2a20753d8ee5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 784141, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas B - 1", 5 },
                    { new Guid("d2e3710a-b653-457e-8751-cbb2ad6d1560"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 506258, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Limited Edition - 4", 5 },
                    { new Guid("d2e92337-4475-4b65-8cb0-1e60162dee8b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 518564, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas A - 2", 3 },
                    { new Guid("d33c0216-b95b-4804-8187-9839363bbb46"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 892679, new TimeSpan(0, 0, 0, 0, 0), "Model Ultra Limited Edition - 5", 4 },
                    { new Guid("d33dc9e2-6d73-4535-b950-c66bf99b0fe1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 852678, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Limited Edition - 3", 5 },
                    { new Guid("d3e83e95-a019-4436-93a3-66d21b4dea22"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 782494, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas A - 2", 3 },
                    { new Guid("d49d3a15-970d-4fb8-b85f-8673a76e5242"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 597683, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas A - 1", 5 },
                    { new Guid("d59158b3-1cd1-49e1-a863-02de0e446a21"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 698065, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Limited Edition - 3", 5 },
                    { new Guid("d626c063-c7a6-4c61-8fd4-621c8c3aa178"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 650940, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Limited Edition - 5", 4 },
                    { new Guid("d6f5c920-9598-44ad-93d5-9e7688a38c19"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 707482, new TimeSpan(0, 0, 0, 0, 0), "Model AA Special Edition - 2", 5 },
                    { new Guid("d7b6eadf-e00a-40e0-a244-1e2f8757f78b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 785597, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas A - 4", 4 },
                    { new Guid("d7f6f1e9-0395-4fb1-b9b9-8e2edb745aaa"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 556474, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas B - 2", 5 },
                    { new Guid("d802d009-724a-4099-ae3d-1c5819a63ee0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 694326, new TimeSpan(0, 0, 0, 0, 0), "Premium Pro Kelas B - 3", 3 },
                    { new Guid("d8b13d69-75de-4379-b72e-ce28dec3c50a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 907772, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Kelas B - 2", 5 },
                    { new Guid("d8f5149f-7ba2-49af-bc20-6391fac70661"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 926457, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas B - 3", 5 },
                    { new Guid("d993c086-3274-443f-8700-3409392e795f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 944065, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Limited Edition - 1", 5 },
                    { new Guid("d99f901e-3813-4b75-a1c3-a93a36579645"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 652439, new TimeSpan(0, 0, 0, 0, 0), "Super AA Kelas B - 2", 3 },
                    { new Guid("d9dc9eef-dcf2-4831-b3a1-66a55cda2d73"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 902115, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas B - 1", 5 },
                    { new Guid("da8a3ec4-10c3-4632-81ea-d205b034731d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 805197, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Kelas B - 3", 3 },
                    { new Guid("db415ccf-95fb-4126-a5eb-df769851d33e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 825915, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas B - 5", 4 },
                    { new Guid("dbb78f0e-be04-42bf-8490-0159c83c6540"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 841717, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Limited Edition - 3", 4 },
                    { new Guid("dd64818f-ef82-4266-bc82-40ea37b5e487"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 673431, new TimeSpan(0, 0, 0, 0, 0), "Model Pro Special Edition - 4", 5 },
                    { new Guid("de085912-b408-4919-a536-589d51531a35"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 733280, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas B - 3", 3 },
                    { new Guid("de1e24fa-7c3d-4f12-ba20-06d104713491"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 575083, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas A - 3", 5 },
                    { new Guid("df051a83-0a16-4ec3-88a2-4ce62af99503"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 643091, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Limited Edition - 2", 5 },
                    { new Guid("dfbea58e-98d2-4ad3-8610-3e29612c153c"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 807277, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Kelas A - 5", 5 },
                    { new Guid("e02132e9-338a-4f1c-9b0b-c0dbcbd52f7f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 579729, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas B - 1", 3 },
                    { new Guid("e0a778ae-eff2-4247-b565-3d06b5d02f55"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 522748, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas A - 2", 3 },
                    { new Guid("e202ee9e-9fbf-42d9-b568-1558b0d2dde6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 916968, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas A - 3", 3 },
                    { new Guid("e2175fe8-f4fb-4082-8c24-0136f6d3e086"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 815334, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Special Edition - 4", 5 },
                    { new Guid("e2777df7-0900-4f1a-a357-ba3a9696e41e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 665325, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas B - 3", 5 },
                    { new Guid("e2acc49b-5139-4c2d-925e-66d057f66e66"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 826769, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Limited Edition - 1", 3 },
                    { new Guid("e2ca6116-afe6-46f3-a5a1-3d81774d343e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 507927, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Kelas B - 2", 4 },
                    { new Guid("e302aa5f-0941-48ff-931e-aaad827ec81f"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 796705, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Limited Edition - 1", 4 },
                    { new Guid("e30b0b3a-f63e-493f-a115-03c5b9b2b08d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 529087, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas A - 1", 3 },
                    { new Guid("e34513db-bc36-464c-a452-3b2cf65eccf4"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 692920, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas B - 4", 5 },
                    { new Guid("e40f06fa-f50b-4987-9301-38f164697c52"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 952649, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas A - 1", 4 },
                    { new Guid("e47760ee-866f-4017-946a-657959d40f4b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 789092, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Kelas B - 4", 5 },
                    { new Guid("e4b843dc-2966-4f76-876f-10f024d22332"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 515434, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Limited Edition - 3", 4 },
                    { new Guid("e4bfb07b-0c02-482e-9542-ca10d71fbd5d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 869254, new TimeSpan(0, 0, 0, 0, 0), "Model AA Kelas B - 5", 4 },
                    { new Guid("e68bd6b0-38f4-475c-92d1-55bdce7c3f16"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 828778, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Kelas B - 1", 3 },
                    { new Guid("e7879d95-bf6f-47cd-96a6-d9e030d3a9a8"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 986804, new TimeSpan(0, 0, 0, 0, 0), "Model AA Special Edition - 4", 4 },
                    { new Guid("e8466ba2-e294-4e12-b505-2804e8aee43d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 620050, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Special Edition - 3", 5 },
                    { new Guid("eaeec7b7-be5a-4fff-b115-8f6c5a10a438"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 832937, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Kelas B - 4", 3 },
                    { new Guid("eaef0537-79bf-498d-8c35-ce9fedabb1f6"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 514228, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Kelas A - 2", 3 },
                    { new Guid("eb60a58a-50d0-468d-87cf-1debec2caf0e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 697465, new TimeSpan(0, 0, 0, 0, 0), "Model AB Limited Edition - 3", 4 },
                    { new Guid("ec047c31-fc17-47db-8484-d9c9a9af6af1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 626108, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Special Edition - 3", 5 },
                    { new Guid("ecd118e3-5c33-4a66-8c90-34a34e5089cd"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 833678, new TimeSpan(0, 0, 0, 0, 0), "Deluxe X1 Special Edition - 1", 5 },
                    { new Guid("ed1a0bf9-c673-4e5e-bcab-f012e8dbe60b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 541887, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas A - 1", 3 },
                    { new Guid("ee0cd63b-09af-41dd-9fac-3d3869473654"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 759590, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Kelas A - 2", 4 },
                    { new Guid("ee368bcd-8b11-4be6-85c3-2b194e064f38"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 669746, new TimeSpan(0, 0, 0, 0, 0), "Model AB Limited Edition - 4", 3 },
                    { new Guid("ee97589b-6086-4cb6-9d72-63b63956d9ae"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 994771, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Ultra Kelas A - 5", 3 },
                    { new Guid("eec3d7be-62c6-4d09-9de6-41d35e7d833d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 713000, new TimeSpan(0, 0, 0, 0, 0), "Super AB Special Edition - 4", 5 },
                    { new Guid("eeeb155c-8794-4c59-b9ef-15261b6ac26a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 907840, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas B - 5", 4 },
                    { new Guid("eeedaa37-eda4-4f45-8678-ff77646d3f0a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 536681, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Special Edition - 2", 5 },
                    { new Guid("f00306d6-7567-44a6-a76b-0ec10d1c3f98"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 765942, new TimeSpan(0, 0, 0, 0, 0), "Super AA Special Edition - 3", 3 },
                    { new Guid("f1014a45-3b92-42cc-85a3-16413588fa16"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 621204, new TimeSpan(0, 0, 0, 0, 0), "Super X1 Special Edition - 5", 4 },
                    { new Guid("f16c7fc5-6556-4ad8-ae28-e36a024950ac"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 709645, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Special Edition - 2", 5 },
                    { new Guid("f1726507-49a8-4287-9a24-9d9cd0a6bbe3"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 914692, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Limited Edition - 2", 5 },
                    { new Guid("f2bdfff7-cdf8-45cb-ab1b-9e18f216ff9d"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 675290, new TimeSpan(0, 0, 0, 0, 0), "Deluxe Pro Limited Edition - 1", 5 },
                    { new Guid("f31eef0a-dc75-420a-a7e2-fbc7e01d187e"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 854336, new TimeSpan(0, 0, 0, 0, 0), "Model AA Special Edition - 5", 5 },
                    { new Guid("f4b5761e-b887-422b-a33a-5d2e7cf81b20"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 794421, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Special Edition - 1", 5 },
                    { new Guid("f4d1072b-1e70-4e6b-98b2-95965611c5b9"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 886752, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Limited Edition - 2", 4 },
                    { new Guid("f5c234f9-8e42-45c7-a5c8-6774b9b5283a"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 577714, new TimeSpan(0, 0, 0, 0, 0), "Classic AA Kelas B - 3", 3 },
                    { new Guid("f5d525ff-4ed3-4926-a0d7-a6150adee7dd"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 791391, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Kelas B - 2", 3 },
                    { new Guid("f696eec7-753c-4df2-b066-7343ba832aa7"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 766167, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas B - 4", 3 },
                    { new Guid("f7393bb2-6021-4fb3-9f73-aa6d706b0e46"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 940434, new TimeSpan(0, 0, 0, 0, 0), "Classic X1 Kelas B - 1", 5 },
                    { new Guid("f7c3dbf9-9c2b-4ac5-9714-17badddbd5d5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 557080, new TimeSpan(0, 0, 0, 0, 0), "Super Ultra Kelas A - 3", 5 },
                    { new Guid("f8299666-181a-4886-bc62-a2adc460214b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 936522, new TimeSpan(0, 0, 0, 0, 0), "Premium X1 Special Edition - 5", 4 },
                    { new Guid("f85acfcd-3a04-4761-9300-c612dec47133"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 712061, new TimeSpan(0, 0, 0, 0, 0), "Premium AA Limited Edition - 5", 5 },
                    { new Guid("f8a3c949-c14d-4f4b-8291-e14b9ddfe9d8"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 996110, new TimeSpan(0, 0, 0, 0, 0), "Classic Ultra Kelas A - 3", 5 },
                    { new Guid("f8bc6ccc-7e4c-4598-831f-29751cd248a1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 993609, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas A - 3", 5 },
                    { new Guid("f8d275c4-66ab-4892-8d3f-43564e0c7488"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 685016, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Kelas A - 4", 3 },
                    { new Guid("f96ced8d-15b8-4144-b5dc-d8b359416e25"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 587231, new TimeSpan(0, 0, 0, 0, 0), "Classic Pro Special Edition - 1", 5 },
                    { new Guid("fa9cc732-3a29-4e74-8913-b16326967deb"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 824552, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Special Edition - 2", 5 },
                    { new Guid("faf4bd0e-2c63-4a93-a67f-f780f4e77562"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 671137, new TimeSpan(0, 0, 0, 0, 0), "Classic AB Limited Edition - 1", 4 },
                    { new Guid("fbc1ac94-4da9-4da2-b43c-ea48821eb936"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 563709, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Special Edition - 5", 3 },
                    { new Guid("fc10b464-7b28-4662-bb62-2cd196a75692"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 726516, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas B - 1", 3 },
                    { new Guid("fca9254f-baa3-4a61-9614-858b3f5145f5"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 530938, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AA Limited Edition - 1", 5 },
                    { new Guid("fd196b35-b596-47ae-a484-98cb12d4edb1"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 875830, new TimeSpan(0, 0, 0, 0, 0), "Super Pro Special Edition - 5", 5 },
                    { new Guid("fd876044-1ef5-4ddf-a055-5e7ffdafcf68"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 645302, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Special Edition - 2", 5 },
                    { new Guid("fdaa3692-8c2f-4ef6-9f44-5ff51d33fd01"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 757419, new TimeSpan(0, 0, 0, 0, 0), "Deluxe AB Kelas A - 1", 3 },
                    { new Guid("fe16bcfd-f5ef-4209-b71b-116dd631b8ff"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 825230, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas A - 2", 5 },
                    { new Guid("fe18c17b-1579-400f-a5b1-11bb46af6257"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 815071, new TimeSpan(0, 0, 0, 0, 0), "Model AA Limited Edition - 1", 5 },
                    { new Guid("fe988754-8359-4fbd-a220-5df221e57a8b"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 697083, new TimeSpan(0, 0, 0, 0, 0), "Premium AB Special Edition - 4", 5 },
                    { new Guid("fee67642-b51e-472c-bb09-bc0a8bd39dec"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 993062, new TimeSpan(0, 0, 0, 0, 0), "Model X1 Kelas B - 4", 5 },
                    { new Guid("fef59779-22ee-4087-a97c-440c086eccf0"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 745498, new TimeSpan(0, 0, 0, 0, 0), "Super AB Kelas B - 5", 3 },
                    { new Guid("ffa2cd25-ee4c-4905-8ad4-cdeb74d57ebc"), new TimeSpan(0, 0, 0, 0, 0), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.", 586595, new TimeSpan(0, 0, 0, 0, 0), "Premium Ultra Kelas B - 2", 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("00780bc4-4a0f-4907-9e90-cf5af58e1881"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("008d510b-7dc4-4ff6-9a80-264b92d99318"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("00fb51d8-b575-4619-bc44-866819855d25"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("027d946e-cd8d-402a-bafc-787f27d9cf18"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("02ca5109-e2c3-4f10-b89c-6bd41021d094"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("02d42f27-5f76-4c85-bf21-93d1f1272567"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0301fbcb-1661-4ab1-aab5-a62e2eeb952a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0356e504-e113-44e8-b4db-dcbde2532517"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("03f49a87-7516-4802-a94d-a36532446d09"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("052ef5f3-f78c-4e53-b6ce-d5fceb3a4b15"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("061be14d-e6e7-47b9-97e6-665bb029853a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("07163aad-d936-4d4c-997f-5e48dbe8800d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0726065e-4eff-4088-8192-16bbb0f6a848"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("07853aa1-dd1d-49de-bb00-411b492403af"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("07bec19e-e9cc-40a2-a449-2294ec43c6a6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("07ff4e07-77e1-43b3-9d55-478f93154969"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("09951d2e-0795-4220-bb12-98180fe5695b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("09da3ac3-6408-48f7-90cc-076d92d9af55"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0a2a1a69-3272-4bb3-89d4-974200e9c3ec"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0b17a2f3-b05f-4428-9b14-e88420e7b1ac"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0b1e0217-e4e0-4f03-b669-e2fff9d7e199"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0ba4d14e-4153-444d-b55f-f144a9c790fb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0bc4f5f3-4bbf-4f31-9f60-08f590761c3a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0c1e02d0-67d4-464f-b329-ab956e7a0933"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0d0f5e02-eead-49f2-a53c-ac665e0d71a2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0d703fed-e2ca-41c3-bd97-e7b7c070e45b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0daca8c0-3079-4143-9346-9934b35c1831"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("0f113f5d-060a-435b-b16b-913850b29fc1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1079aa3a-abda-45d9-8d3d-a70b171ee930"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("11b50b54-9c19-48cd-a367-e3faa3e03b42"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("126ec095-d439-4848-85e7-995c381e2be8"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("127d973b-6c6c-44b6-b756-d582b3f5d2d9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("12be6a34-72d2-444f-87d7-c593ad62ed5a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("12d2e2b3-7fa0-4beb-b45c-436a15ea9098"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("131a693e-006c-434c-845c-c249049bdd1e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("13c5ef32-328d-45e6-b5bc-f1515c92d6a3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("14a99cb0-a22c-49fa-a4ca-0d6046a969f4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("14ff03bc-36f8-4ef1-b1a0-b043e3c9a4b3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("15a5140d-bf01-4356-a659-32169e3aecac"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("15c53a95-2c6c-481a-be97-8e208d7b452a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("15f11e70-ee00-4721-85bb-48eaf50764aa"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("164a730d-4061-4e93-9ce7-510bf1752375"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("16e4e91b-aa14-44c2-b433-122a487c893b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("179fe5d5-a80b-4dbb-b7c2-bfcd2740d079"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("18c46480-d9dc-40f8-9ba9-6e090c0cf62b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1953faea-6634-4065-b008-f8d65feb2a15"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("195920a8-a63a-450c-ac8b-032a878d615c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1959e7bb-9741-4c2d-b0cd-6eb63b819d81"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1a27004b-3bf0-4461-b9ec-1ce5a765ef3a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1a38accd-0960-433f-977f-7c2888ce9fff"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1a669db6-f13f-41f4-8940-f5a163a632ff"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1aeb689d-a1fc-415d-97ff-d6b73952cd0e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1b11b3ae-23d0-4632-8689-0b465550b63b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1b298b39-bbfe-4199-abec-17f830323dda"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1c836270-c11f-48b4-8d35-1ec09b6059f4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1d763b1a-7425-436e-91d9-f8b77a581bcf"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1dbcc411-97e8-4102-832b-3dfce1df7d1e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1e1d8710-6c90-421a-8587-6b5d3cd01046"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1e77f7f7-43d3-417f-a2be-26650c31b67b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("1edcffd1-4860-46fc-a6d4-dbc890ceb2bf"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("200ed91c-ec09-4682-979d-82370a1bb3d4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("205d08e4-2109-44af-8d30-5e04f2b5a967"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("20734cbc-209a-4519-8522-71508d74e093"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("21481e0d-4b90-4df7-92ba-67b623bd6e2e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("22e0c683-dd89-4352-9a36-488f6406d382"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2303f5bb-a8cd-4146-a530-b540bbc8fae3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("237465e4-bcea-4cb4-8605-7e77de7c55b8"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("242545cb-e074-415a-833f-b0df13c6b49e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("24b1e0a8-7f29-475a-947d-b4a1f187902a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("24e04edc-49fa-4765-a197-0d6a4111fec9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("254bced8-272c-4457-ab04-e27a52c58afd"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("25cbe285-db1b-40ef-b5f6-4465147831f4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2687f465-aa46-4765-8adc-274ac0111c32"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("26c779f0-25c1-4db5-9492-822e7836e089"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("277ffe7d-f186-46ac-ba75-bb37450c6ca7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("285bf2a2-c910-45d9-b095-be07f0faa765"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("28c06eb5-968e-4df7-b299-c9bcd2c1b0ba"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("295acb25-88c5-4cdf-84ae-baa2ae2e0681"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2988e757-060a-4084-b986-e20ddab5d4fb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("29b13700-84f5-4e9d-9868-dfaa47217f36"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2a8e4977-f4c5-447e-a4d0-198af36d38d3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2b2715de-69db-47b9-b778-5a3c0a702e23"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2b27c95e-8b89-49ca-83bf-1edad8e8d94d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2b4520a0-0e0f-406e-99b2-c41dfa9bf689"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2c067fec-f087-44fb-8fa6-2a995948f0b2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2ce931a1-06f2-403b-9411-1e964ac7f697"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2d4545f1-322d-4768-8027-d2b8ab1d0c40"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2da08eb0-ef1b-4e91-a923-53a30990a35f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2dbe2f9a-3711-4a3e-be69-34ddce4707c5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2e7a049d-5c4c-40e1-a8eb-94026ebd8bdc"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2e95ddc0-b5e1-46a7-b2d7-6fe1b5920bc7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("2fbda6a5-3c63-435d-9f16-de0235c36b9f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("30455775-68a0-43a1-b5f6-463f6761b96d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("30a40bdc-36b1-43fb-b511-4c2ff2f7836a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("30e29c95-bcf1-4764-b03b-1d094d5b6192"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("30e2ecb7-9440-4ff8-8e79-000bce202163"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("329ffdca-b0f8-48b9-ae1f-a6f7cdd4a23b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("32adf659-49a0-43b5-b6f0-1ca960e24896"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("32ef30d8-491e-4e50-827f-0f8ec6e0404a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("33c8ea0d-8353-4b15-a478-ccdf31f8b863"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("33e1868f-ef7b-42d6-a53e-22f8d989e370"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("341e2be8-86e9-4d49-9be2-d87072527abe"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("34557024-cd11-4a2d-b6a2-c3382a23e373"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("346473ac-15a1-4ccb-b10c-7830fad0acc3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("34844c6c-6c9c-402f-bbf3-e6da51cb1961"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("34ddc99b-0451-43b2-b5c1-33df900eac21"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("34ede8d0-ba64-455f-8a2a-1de5736ec028"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("379d85c4-f0b4-4dd9-9350-11fada5ae35a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("38109807-5499-43df-8eef-c07fffe3d984"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("38161bdf-1e3e-4cf3-bfcb-e9a2d11bff3f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("385fa9fe-c7ea-4670-8165-7fe072d9d0bf"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("38e8e80a-be3b-4e61-880c-6b27ac628ab5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("39295dd1-ce05-45eb-bda5-9c2d741aa902"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3a7d5499-942a-4878-a567-50719ca4ed1c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3b3cd082-9f38-4e40-abc8-f29cec9595b0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3b3e044c-8472-489f-9625-9ea520edf42c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3b60743a-1850-4240-859c-f118ed9376dd"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3beba81e-66ac-4070-88f6-3d0e284f93d6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3bf383e1-8315-402b-9421-40b03695c23c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3c0ab6f9-4a93-4b76-a4b5-f6b0f30ccad8"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3c740e8d-fd37-4abd-8f41-b3583f7609ec"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3dfe7297-f0b8-407c-b715-01f491f56a0f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3e5c5efb-d81e-4f08-80ed-e5ad1e36e6b6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3ebc64a5-e04b-4cd1-8c7b-1cc74207721b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3f1ec0ec-b192-420b-b783-e5375a4ab71b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("3fe48533-1808-4b5c-8101-b084e8dec022"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4141d542-31db-4760-b759-b22ac4be9854"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("41a025b9-ad8a-4ffd-9987-2562c00d3c5a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("420153c8-bbd1-4725-8487-e61c40df7dfe"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("423c6046-b2e7-4d0e-b1ad-469c67565616"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("426c68df-a8fd-4e64-856c-81fb8490c49e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("432d4dd0-b9fd-4f37-8c89-c17c0ef7f3c6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4345ffb7-61d5-416c-84e1-5505c9f8de2d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4352a249-c78b-494d-b4c5-505bebcd3000"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("43554d57-dfff-4a89-a62d-a540b0292218"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("43650081-90c6-4009-abf7-79f3b134f869"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("439db417-777b-4424-b41b-b2a81019b4da"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("44717ab0-fdbd-4f24-bb2b-7cc28552e72a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4474a38b-10f3-44d6-81ae-b3ad6702674d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("469deb42-63ff-4f69-a74c-2d10b032dfe0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("469ee4be-3377-4395-a93d-8116ffbc7ce6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("469f24f2-b05a-4680-b413-111fe96ccc94"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("47061b90-87bb-4556-a41c-53d05d5dcdbd"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("472041f4-15c7-46e8-94a1-5a6fb973f04c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("47671357-fed7-4da9-90e3-1ad90add8ee2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("485a54df-1e5d-4c59-acdf-a94cb3cb6fd0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4865858b-be6e-4964-bd0b-91c35f746e0a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("48fb23e5-dcbc-4a7c-9260-f51020c86051"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("490b0b77-3e76-4071-b62a-30322fa607de"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("491b5001-c72a-40ca-8f17-8f56736ed15c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4aca0502-c99a-4d8a-893f-e15fed3b90ed"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4b23f8b8-f13c-4547-8b21-c86f601afdae"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4b2c2546-28a5-4230-afd0-c6d419b22bc9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4b2fd40a-f090-46f9-b16d-156923078194"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4b9d1537-ea41-4df2-acce-d0228146bda2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4cce09fd-d6e7-4130-a8fe-23b1b44bc886"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4d259f53-7b8e-474a-b3de-1cd15d6fa798"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4d70b4f4-36f0-4335-b501-3263000d6a9d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4dbf661d-e59f-4549-99d2-984382e3ef54"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4e5336f3-5535-4183-b480-ffb5005c6992"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4e72e26b-cb46-4758-9b5b-20fdb83e1649"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4e77b85c-839f-4596-8800-b40f7921821c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4ef1395d-ff7b-4c6c-88a6-84634216d764"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4f2d653f-2a93-4a01-8d4b-36fcbba227b6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4f306db1-61a7-478a-9fb0-69c91ba44ca7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4f6cec1d-9049-4d6d-a7d8-47d149a3a23c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("4ffa5427-b4cd-40c1-abc5-9bf5fb1191e1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("507a9826-6301-4ed2-af6a-032eefc40399"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("508abaef-724c-4ce1-923e-cb733bcfe644"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5101a9d8-91d3-48af-889d-ccff56447240"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("510401ad-ba77-442d-b3b7-2f77a6d0e678"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5211d06a-528f-414f-aeca-1e0fd90a08f3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("52701d3f-6b69-428f-880b-e47caffcfcd0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("53213d21-a528-4f68-a52d-53777cc1af35"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("54454ea8-434a-46d3-b795-75b99415f32c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("545c3597-792a-40f9-b16c-87ddca8a85b7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5571756b-3851-4a0e-9063-25cbace18dd2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("55871719-fc69-43a5-b631-9601a1396a43"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5792ed09-9b24-4643-9c72-b5dd3380df8e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("57fabb76-c7b6-4b46-819a-85e79500188d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("580ee8db-47c4-4775-89c1-7d78b695c533"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5840c76d-4f8d-4a46-a3be-704aff9b2556"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("58fcfeda-057e-4961-a7ef-0b8bc33ab097"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5a5135a5-c3e3-4dc6-afcb-7295d6b1bc11"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5aa8816b-7b4e-47a6-a662-0b051d87e395"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5c431acb-5c4b-4585-bfe2-a0f8f3a4549f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5ca50c26-9f91-4ac0-ac48-a3ae83344709"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5ce736c2-ed40-4ecb-b8e7-7315ed497adb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5d5413e1-6470-4f23-b0db-2590835a66f4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5d80f6a1-deac-475a-bd86-93f32ca1b5a3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5d8fe336-883a-41e0-a9ac-8913e324e3a3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5e0d07a9-95da-440f-957c-0cfe83fcb56c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5e992f0f-ad07-4a3d-bd66-386a4d083175"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5feaf5f6-5d47-4f95-8d70-938e39b98fbc"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("5ffe62ae-3bd0-458e-add0-a0e200c0eb3c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("60a31cb9-6b93-4237-8e80-aa1e77c0dbf8"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6125b5c6-2c41-4ced-a02f-85f51c22ebaf"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("612b293c-327e-4222-91bf-7d35883348de"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("62b9e7a6-cd87-482f-84a6-b8dc64c0beeb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("631e382b-a9eb-412f-9b6d-b7b87f616369"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("635182c5-308a-455c-aece-17b527543ccb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6371f3f1-157e-40a0-97c4-b2895fcaea5b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("64b593b7-c739-4f87-9c63-814cd79aed84"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("652480d0-94ea-4340-8619-5ff52985ab25"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("659cada7-1197-4265-8557-9fea5b3b87bc"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("66b8814c-ffee-4050-8d39-b68c85615d7b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6710e426-5b92-4a42-b0cc-50bb3dd3a747"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("67bb86f9-b625-4c05-a9dc-b99234185f81"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("67bc3a3c-d040-446c-a108-29d995b7afb7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("67f7b055-7095-4c11-ba18-72d7bf27bfae"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("68071448-afa1-4b6d-b767-99ca76d44895"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("698045d0-e6f7-48f5-bacf-43d861f5314d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("69a3d8a2-7fac-484b-b1a9-1e5819720016"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6a9c4f8b-0ab1-42ca-ac9a-1bf86891b985"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6aaeb399-5c7d-4509-99a9-96bdffeba8f9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6abd33e5-08fd-48f7-89dc-b188e0bb08f3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6af64bf1-02a5-411f-a2fe-e309e9e1fa8a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6af97a4f-c329-496b-8365-2dc5d2568cec"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6b292316-bf41-42b0-b549-8a3e5b268309"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6c245083-3e7b-4330-b1d9-dba9a6adacb3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6c92093f-1f6c-4ff5-b7dc-394ffad6725c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6cb5d7ec-d1a0-45d4-bc55-539fb596794b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6d8c6ab9-1b42-4115-adca-3ed6d5cad0c6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6d8fce78-9973-4e18-8d48-c48ea8ae0076"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6dd328e9-01fb-4de7-b60a-a6b27f71b796"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6e5b9901-3ef8-4020-8c9b-65cbd350c497"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6ec4b901-1f24-459e-b6c9-b830e65b163e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6eec1086-559d-4baf-b620-361d32bdd59f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6f2ff252-8e67-4387-b95b-09a3a9494c25"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6fa6b813-8989-44e8-96ff-fc41a18f66b2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6fc523de-c105-41c3-a070-7bb0613ff15f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6fcb713d-1761-4e7f-9f95-ae9def3a6230"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("6fddde8e-c478-4444-96f4-2b9b15335e7f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("700a9a21-2bf0-4de8-a035-ef943b44ef65"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7119893c-550e-4bd1-a90b-7c45d87f32ac"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("71b32e02-2f4b-4461-9ca4-a74567ddb9aa"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("71bed763-475a-4732-890c-a4af68772229"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7274b86b-4a93-468d-b51e-e66001c5b012"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("730a12c6-865c-437a-864f-c6d9a509e809"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("73a969c1-dba7-4c55-8935-d43be7fe592b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("742203c0-cb6d-4b8b-a4da-14e57b85e702"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("745dcc09-cbae-4d1a-908c-5e525f5886d2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7469f228-ce3a-415a-864c-2413085d88ee"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("74e94db3-301c-4166-9fab-43413b850633"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("75f03061-774d-42a1-b4e5-f671d970205a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("765c01a5-8c5a-439b-adbf-ac4098021322"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("773bc000-46ff-47ff-8ae7-b905a8c6e895"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("77482604-e6cb-4753-8c71-aad30189cecc"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("780a08e3-1169-4dd2-8f0d-bfb5fafd8135"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("783bb203-0b30-43d7-b140-f96d6c4bbdb9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7a6d4626-a349-4bbe-9bf5-be018616cfc1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7a6f8563-b296-4d86-9154-8e5b4de5e67b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7b74e95c-f0ca-4319-8d9c-5c5a7feff45f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7c16a30c-c378-456e-86a7-568871bd77be"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7e019ad3-6f2c-4d3e-a8aa-0b0e4b3357e1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7f115f92-0ac9-43a6-a3c6-f57fad2215e4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("7ff5879b-eeef-46d1-9218-ab95bd22d35a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("80914a49-e270-4322-b748-d4a72f6ff34b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("809235f8-a16e-4a85-b547-875b63f6114f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("80adc88e-5124-4036-ab18-0a8bebcd0b75"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("81e1e5ce-7af6-4528-b9ca-e2225b6f3643"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("81ff70a0-7c64-4b69-93f6-4d54691745bf"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("82440fdb-3856-4b8c-aef8-31fc1df1bae7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("826dc01a-297a-4c02-b732-44c253d142d5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("828e5900-372d-468f-8528-077f0fbcc2f1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("82bd8a1d-56a8-4783-b9e8-b3a304ea7a56"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("82c3ad63-99fb-4a22-b1b8-8a51a25efc0a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("831b7371-458c-4087-a669-15df492b7136"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8377432a-acf0-473e-bb3a-1eae763fcb79"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("83c58aab-f1ba-465d-a872-086ce7b74516"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("844ace32-bd60-40cd-81c9-eae59902a443"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("84d77b73-5e62-4625-aaa7-4caea575b3da"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8556cb41-04a2-48b6-b647-8935a79cd99a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8582e4ee-a14a-442b-b67e-3798cb33b2c3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("86a791bc-4e24-4eb2-8017-a45af8f656c7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("86e320d4-4be9-4939-bc30-00a3a0d04b63"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("86f136d0-8da8-46df-89ed-d6349c5e38b4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8704bca2-ad91-46e2-94b2-d573e9292d0e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("878655db-3907-47e7-9834-76972298766f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("87c6480c-e981-4417-b7ff-560d27a966d9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("88381bdb-cc0b-4cfe-bc91-1377f929c23e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("89eb2677-ac8e-4305-9241-344374002804"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8a299483-eab3-447e-9a4c-c878bf77b98b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8a576cf4-db98-44c4-99f2-5caa7868e186"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8a793cf9-2dca-469b-b4aa-14bf2287d4c9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8b0327ef-bae9-4474-9d36-8ae1609c20a3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8b07ecdb-c6d7-4b3f-9e54-ccf2adec6d9f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8b698228-a6ed-4b33-8104-039c40509d47"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8c407314-02d0-4621-b9a2-0d0e33c26a65"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8ca6e164-eccd-40f2-a102-d5f1f6aef57a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8ec3ccd4-740a-4dcd-9ff1-3a3cbe32cec4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8ed14318-4f77-46ed-b95f-b326b4f4e173"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8fb985ca-5831-4c22-8c47-2290b8c4b578"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8feeb364-2508-491d-9452-59f5ee813225"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("8ff6689b-d986-4d83-8f3a-04220d2136fd"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("90645733-5c43-475a-aa4e-1779eac70205"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("90852f2d-fd97-44ed-a12f-d72f83e672fd"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9094e853-750e-48c7-bb51-bfeab174e777"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("90b7a7a7-6bf7-4800-9a33-32e4e72056d9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("915023c5-aeba-4369-852c-0f1a97e0254d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("91a9446d-b98d-429f-b140-a8e70791024b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("91bb2ce9-1804-431f-9f07-5933a46a9806"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("91d9a5f9-6995-491d-840b-55c715149298"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("928a2c60-35e4-4906-a24b-8528d29a27c4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("929e3cad-8a92-4436-b8b2-0f01e338c5e6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("94c3f4e4-437c-4853-936e-9c541d6f7d80"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("951d18d6-b1dc-4990-9174-40a88338a228"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("955dfc30-7867-4f76-8215-706538a25463"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("95e54257-7578-497f-bb17-3afcbeb4ad92"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("971e078a-089c-4a6f-9070-7e2bfcfff93e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("98e21dca-22d0-4e11-abdb-d4d99a4bc9cc"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("99803be4-caba-416b-9230-4eb6436f07bc"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("99c3e86b-3a22-4136-81a5-46d7bc0aff86"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9a0b06eb-c5d7-4f7e-8d2b-faa8d0e7e7f2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9ab17ad4-8aeb-49d2-acea-f0cd6986c33a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9ac2f8ed-9519-4ac0-bddb-ea1bc95ab339"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9c3bcb68-7eb8-4247-9ef2-24849b12deff"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9e1b987b-ddf6-4bb9-9540-ea2c74e6671a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9ef6316b-bb3f-4b1c-9e5c-221934ad9253"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9f82e34d-7c60-4414-917c-9511aac03b44"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9fc988ff-763c-4bb2-a922-8a96641f457b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9fff0669-7820-4bf2-9691-34f1083021f0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("9fff4085-d158-4c08-b1d5-d92f1998be90"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a059034b-be41-47ba-abec-9607b6152767"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a0878580-899c-4c3f-a59d-09c23a00b16e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a097400c-866b-4385-8fc2-191efb6f0266"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a0a61c31-9cdb-4fcb-b979-3b1316a285f3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a1150c08-23a0-4467-8fa6-b7892470877d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a1176983-b252-450f-9bd3-589a481219ff"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a1aa7e84-a835-42e7-8fb3-e8f88523dbc5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a1afb1ff-5dd6-46dd-a870-307a7c139884"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a3af2423-c815-48dd-8c1c-09c4fdc1543e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a3d9a56c-5a11-421c-9d74-6607cc5ea992"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a4d7bb64-5dec-4872-9607-cd84846af859"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a5446f3c-53f6-4eac-b452-cd1fc81f7ee9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a609d5ea-1dc7-4627-bc23-4bd95333aee8"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a6db8292-7be4-41e1-8d28-bea7d2e19bcf"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a75751af-a8f9-487d-b6bc-39cb1b77b5b7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a760e03c-8d75-4f2d-92d4-675988c69c3f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a7ee43ae-49cc-44e8-817f-60688061577b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a80cf1dd-56db-4406-861c-bbc39249ade2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a8549cab-c753-45a4-9702-8aaed592c1d4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a8d69106-6e59-4fb3-9e65-818e3fdfa0b5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a8eeddab-866d-4832-95e2-1cdf1ad7998c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a9928f29-4785-4421-9329-67a90d5693eb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("a9b54314-e209-4ed4-9a83-262d550c50a4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ab73f000-69a2-492b-be20-b89f5a6937e2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("abfcd021-b52d-462d-b016-42c876d63f85"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("accdce45-a4f4-434e-ba7e-1c5c7ae0d693"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ad45f9a7-dbe6-4a7c-be29-1d4211135bdd"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("adf181d1-ad25-44ae-a2a1-b941d899ee23"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ae1e0f0e-906c-45a8-912c-d6988af7e7da"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ae32e880-0967-4acb-936d-302eaa5ccc11"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ae91d12e-301d-44cd-9ce8-6f9a02158df1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("aed8324c-9a6b-44cd-b257-e651576350b4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b016767f-e64c-4211-9531-e331ecea2ff1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b06d2b42-3034-4403-a214-d16affef847f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b1da5b65-ae8d-4f48-a5ab-d447a4f3542b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b1de3b55-cc2e-4c7c-8be2-67850a2e6cf8"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b1e4df40-2d86-44c4-8a30-da09f3d2a838"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b2ad3e79-e290-42bb-b7ae-784463423ac0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b3ada853-5101-416a-96ec-fac786a34fa7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b6137169-2e8a-46ed-b57c-f681852e7d50"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b618725d-6cde-47af-a148-39049db03be9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b6a95e93-9e61-4953-896f-da0a387c2763"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b7215e3e-50eb-4085-9a6d-df5354d435e9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b7777947-4acb-494e-829e-3927ed5a3711"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b786a392-7431-4d5e-b87d-70009f7605d2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b7a330c4-336a-4df5-bc9c-08155e868a67"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b7d32cee-67df-4cb3-a153-e46dd3b914a6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b7dfc4e2-7a5d-4d93-879c-b29a478fbd79"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("b915bfc2-5556-4b76-8143-822e3c599e0e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("bb8d5b94-a77e-43a1-888a-a660f65253d0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("bc078244-adbc-4a03-b2d2-864d58c4cfb9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("bd9a0aff-b9ff-4f0e-9b56-212c285bc28e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("be1764f3-1e99-4eff-a7f5-59e41605c5fb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("be925fa0-e1b6-454a-8399-292513fc0626"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("bea29f4b-c3f9-4bbc-b78e-e82da08f0adf"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("bea7fde2-9d8a-4146-8e0f-1dd1631e5a5a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("bef999a5-103f-4f68-8ae9-16897e234c06"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c056bcd5-16c4-4054-b522-af17b609133d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c15058f3-5b34-4d8b-bdb4-11f29996dec0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c19d9f41-f379-43b9-87ba-9aa0b656aeee"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c27af264-e0df-4c30-8b48-fc47cb65c3dc"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c32bd3d6-88fa-4546-ac89-9f4dbe67d589"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c372fac0-b486-449d-8716-7d67ab5e3175"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c49fa8e9-8eae-436f-95a7-0ae1ba545fad"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c53ccd6a-2584-4777-b7c4-7ff68e48bee5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c54d686c-6cce-41e4-b9a9-5e0c01001c65"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c6354158-2f12-4835-bdde-999aa7c4700b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c6df6f05-31da-444a-9830-d00fafa144a2"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c71cfe00-5be1-49ca-ac88-5b0c9b845fc5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c725d810-79b5-4913-b9ff-d0adfe566103"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c8788266-b81b-4e5e-9371-6bd7c24ef0be"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c8949548-1eb8-4532-8681-faaa5077083d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c8b7b3ad-0f5b-4c4c-a357-d140f1a7026d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c93b0381-0699-4fa8-a178-da2fd5425aea"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c974d660-dba3-4387-b11a-772b21e6ec39"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("c9ecec5a-35e8-42c0-b5e8-8bc6a2c325ba"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cabe86e3-d424-4b49-ae7c-9485dc104984"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cb068309-9b49-43e6-b213-51acd5a8f11b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cb7083fb-b6f0-459e-9eeb-deccdc2aa0c0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cb940e8d-5526-40cb-b729-70fccf68bacb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cbe515da-e6e4-4ef3-ab1c-d1212a28ed07"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cca664d5-c65e-401f-bb88-6d92b0623f35"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cdd40473-634f-44ca-addc-835a8983d566"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ce29e609-48fd-4b41-bbfd-a9950f037016"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cee3d3b2-0b52-44c7-ab57-42c6e07b1b8e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ceefac59-706e-4cfc-b369-7f0415b90e6d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("cff1403f-6c1a-40e0-803e-0339a7b86207"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d03b43e4-5088-4ecc-ab3e-dbe3f86d811e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d072db1c-de97-45f7-a908-97e0d28a5773"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d166262c-9e51-440c-b660-2a20753d8ee5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d2e3710a-b653-457e-8751-cbb2ad6d1560"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d2e92337-4475-4b65-8cb0-1e60162dee8b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d33c0216-b95b-4804-8187-9839363bbb46"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d33dc9e2-6d73-4535-b950-c66bf99b0fe1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d3e83e95-a019-4436-93a3-66d21b4dea22"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d49d3a15-970d-4fb8-b85f-8673a76e5242"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d59158b3-1cd1-49e1-a863-02de0e446a21"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d626c063-c7a6-4c61-8fd4-621c8c3aa178"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d6f5c920-9598-44ad-93d5-9e7688a38c19"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d7b6eadf-e00a-40e0-a244-1e2f8757f78b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d7f6f1e9-0395-4fb1-b9b9-8e2edb745aaa"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d802d009-724a-4099-ae3d-1c5819a63ee0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d8b13d69-75de-4379-b72e-ce28dec3c50a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d8f5149f-7ba2-49af-bc20-6391fac70661"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d993c086-3274-443f-8700-3409392e795f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d99f901e-3813-4b75-a1c3-a93a36579645"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("d9dc9eef-dcf2-4831-b3a1-66a55cda2d73"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("da8a3ec4-10c3-4632-81ea-d205b034731d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("db415ccf-95fb-4126-a5eb-df769851d33e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("dbb78f0e-be04-42bf-8490-0159c83c6540"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("dd64818f-ef82-4266-bc82-40ea37b5e487"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("de085912-b408-4919-a536-589d51531a35"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("de1e24fa-7c3d-4f12-ba20-06d104713491"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("df051a83-0a16-4ec3-88a2-4ce62af99503"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("dfbea58e-98d2-4ad3-8610-3e29612c153c"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e02132e9-338a-4f1c-9b0b-c0dbcbd52f7f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e0a778ae-eff2-4247-b565-3d06b5d02f55"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e202ee9e-9fbf-42d9-b568-1558b0d2dde6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e2175fe8-f4fb-4082-8c24-0136f6d3e086"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e2777df7-0900-4f1a-a357-ba3a9696e41e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e2acc49b-5139-4c2d-925e-66d057f66e66"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e2ca6116-afe6-46f3-a5a1-3d81774d343e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e302aa5f-0941-48ff-931e-aaad827ec81f"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e30b0b3a-f63e-493f-a115-03c5b9b2b08d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e34513db-bc36-464c-a452-3b2cf65eccf4"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e40f06fa-f50b-4987-9301-38f164697c52"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e47760ee-866f-4017-946a-657959d40f4b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e4b843dc-2966-4f76-876f-10f024d22332"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e4bfb07b-0c02-482e-9542-ca10d71fbd5d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e68bd6b0-38f4-475c-92d1-55bdce7c3f16"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e7879d95-bf6f-47cd-96a6-d9e030d3a9a8"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("e8466ba2-e294-4e12-b505-2804e8aee43d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("eaeec7b7-be5a-4fff-b115-8f6c5a10a438"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("eaef0537-79bf-498d-8c35-ce9fedabb1f6"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("eb60a58a-50d0-468d-87cf-1debec2caf0e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ec047c31-fc17-47db-8484-d9c9a9af6af1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ecd118e3-5c33-4a66-8c90-34a34e5089cd"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ed1a0bf9-c673-4e5e-bcab-f012e8dbe60b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ee0cd63b-09af-41dd-9fac-3d3869473654"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ee368bcd-8b11-4be6-85c3-2b194e064f38"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ee97589b-6086-4cb6-9d72-63b63956d9ae"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("eec3d7be-62c6-4d09-9de6-41d35e7d833d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("eeeb155c-8794-4c59-b9ef-15261b6ac26a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("eeedaa37-eda4-4f45-8678-ff77646d3f0a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f00306d6-7567-44a6-a76b-0ec10d1c3f98"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f1014a45-3b92-42cc-85a3-16413588fa16"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f16c7fc5-6556-4ad8-ae28-e36a024950ac"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f1726507-49a8-4287-9a24-9d9cd0a6bbe3"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f2bdfff7-cdf8-45cb-ab1b-9e18f216ff9d"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f31eef0a-dc75-420a-a7e2-fbc7e01d187e"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f4b5761e-b887-422b-a33a-5d2e7cf81b20"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f4d1072b-1e70-4e6b-98b2-95965611c5b9"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f5c234f9-8e42-45c7-a5c8-6774b9b5283a"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f5d525ff-4ed3-4926-a0d7-a6150adee7dd"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f696eec7-753c-4df2-b066-7343ba832aa7"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f7393bb2-6021-4fb3-9f73-aa6d706b0e46"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f7c3dbf9-9c2b-4ac5-9714-17badddbd5d5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f8299666-181a-4886-bc62-a2adc460214b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f85acfcd-3a04-4761-9300-c612dec47133"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f8a3c949-c14d-4f4b-8291-e14b9ddfe9d8"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f8bc6ccc-7e4c-4598-831f-29751cd248a1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f8d275c4-66ab-4892-8d3f-43564e0c7488"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("f96ced8d-15b8-4144-b5dc-d8b359416e25"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fa9cc732-3a29-4e74-8913-b16326967deb"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("faf4bd0e-2c63-4a93-a67f-f780f4e77562"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fbc1ac94-4da9-4da2-b43c-ea48821eb936"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fc10b464-7b28-4662-bb62-2cd196a75692"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fca9254f-baa3-4a61-9614-858b3f5145f5"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fd196b35-b596-47ae-a484-98cb12d4edb1"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fd876044-1ef5-4ddf-a055-5e7ffdafcf68"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fdaa3692-8c2f-4ef6-9f44-5ff51d33fd01"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fe16bcfd-f5ef-4209-b71b-116dd631b8ff"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fe18c17b-1579-400f-a5b1-11bb46af6257"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fe988754-8359-4fbd-a220-5df221e57a8b"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fee67642-b51e-472c-bb09-bc0a8bd39dec"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("fef59779-22ee-4087-a97c-440c086eccf0"));

            migrationBuilder.DeleteData(
                table: "Produk",
                keyColumn: "Id",
                keyValue: new Guid("ffa2cd25-ee4c-4905-8ad4-cdeb74d57ebc"));
        }
    }
}

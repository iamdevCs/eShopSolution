using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is keyword of eShopSolution");

            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "2524180d-6434-4c1f-b5b9-20c684dd408b", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "d2d369f7-a917-4bd3-980a-5e0c75f8fd6f", new DateTime(2020, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "tedu.international@gmail.com", true, "Toan", "Bach", false, null, "tedu.international@gmail.com", "admin", "AQAAAAEAACcQAAAAEAbE8++B+POzBdN8DhOAVZ637tQZwFnJxhwiQU9jzkxTuVhP8oK1YMVJSVv5Vbm+Wg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SortOrder", "Status" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SeoDescription", "SeoTitle" },
                values: new object[] { "The shirt products for men", "The shirt products for men" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nữ", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang women" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Women Shirt", "women-shirt", "The shirt products for women", "The shirt products for women" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN",
                column: "Name",
                value: "Tiếng Việt");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến", "ao-so-mi-nam-trang-viet-tien", "Áo sơ mi nam trắng Việt Tiến", "Áo sơ mi nam trắng Việt Tiến" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt", "viet-tien-men-t-shirt", "Viet Tien Men T-Shirt", "Viet Tien Men T-Shirt" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 7, 18, 1, 57, 38, 58, DateTimeKind.Local).AddTicks(5750), 200000m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), new Guid("8d04dce2-969a-435d-bba4-df3f325983dc") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.UpdateData(
                table: "AppConfigs",
                keyColumn: "Key",
                keyValue: "HomeKeyword",
                column: "Value",
                value: "This is home keyword of eShopSolution");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SortOrder", "Status" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "SeoDescription", "SeoTitle" },
                values: new object[] { "The shirt product for men", "The shirt product for men" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "SeoDescription", "SeoTitle" },
                values: new object[] { "Áo nữ", "Sản phẩm áo thời trang nữ", "Sản phẩm áo thời trang nữ" });

            migrationBuilder.UpdateData(
                table: "CategoryTranslations",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "Girl Shirt", "girl-shirt", "The shirt product for girl", "The shirt product for girl" });

            migrationBuilder.UpdateData(
                table: "Languages",
                keyColumn: "Id",
                keyValue: "vi-VN",
                column: "Name",
                value: "Tiếng Việt");

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "", "Mô tả sản phẩm", "Áo nam", "ao-nam", "Sản phẩm áo thời trang nam", "Sản phẩm áo thời trang nam" });

            migrationBuilder.UpdateData(
                table: "ProductTranslations",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "Details", "Name", "SeoAlias", "SeoDescription", "SeoTitle" },
                values: new object[] { "", "Description of product", "Men Shirt", "men-shirt", "The shirt product for men", "The shirt product for men" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "Price" },
                values: new object[] { new DateTime(2021, 7, 18, 1, 49, 43, 602, DateTimeKind.Local).AddTicks(7691), 20000m });
        }
    }
}

using eShopSolution.Data.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using eShopSolution.Data.Enums;

namespace eShopSolution.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            //Data seeding
            modelBuilder.Entity<AppConfig>().HasData(
                new AppConfig() { Key = "HomeTitle", Value = "This is home page of eShopSolution" },
                new AppConfig() { Key = "HomeKeyword", Value = "This is home keyword of eShopSolution" },
                new AppConfig() { Key = "HomeDescription", Value = "This is description of eShopSolution" }
                );

            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false }
                );

            modelBuilder.Entity<Category>().HasData(
                //Category 1
                new Category()
                {
                    Id = 1,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                },
                //Category 2
                new Category()
                {
                    Id = 2,
                    IsShowOnHome = true,
                    ParentId = null,
                    SortOrder = 1,
                    Status = Status.Active,
                }
                );

            modelBuilder.Entity<CategoryTranslation>().HasData(
                    new CategoryTranslation()
                    {
                        Id = 1,
                        CategoryId = 1,
                        Name = "Áo nam",
                        LanguageId = "vi-VN",
                        SeoAlias = "ao-nam",
                        SeoDescription = "Sản phẩm áo thời trang nam",
                        SeoTitle = "Sản phẩm áo thời trang nam"
                    },
                    new CategoryTranslation()
                    {
                        Id = 2,
                        CategoryId = 1,
                        Name = "Men Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "men-shirt",
                        SeoDescription = "The shirt product for men",
                        SeoTitle = "The shirt product for men"
                    },
                    new CategoryTranslation()
                    {
                        Id = 3,
                        CategoryId = 2,
                        Name = "Áo nữ",
                        LanguageId = "vi-VN",
                        SeoAlias = "ao-nu",
                        SeoDescription = "Sản phẩm áo thời trang nữ",
                        SeoTitle = "Sản phẩm áo thời trang nữ"
                    },
                    new CategoryTranslation()
                    {
                        Id = 4,
                        CategoryId = 2,
                        Name = "Girl Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "girl-shirt",
                        SeoDescription = "The shirt product for girl",
                        SeoTitle = "The shirt product for girl"
                    }
                );

            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    DateCreated = DateTime.Now,
                    OriginalPrice = 100000,
                    Price = 20000,
                    Stock = 0,
                    ViewCount = 0,
                }
                );
            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Áo nam",
                    LanguageId = "vi-VN",
                    SeoAlias = "ao-nam",
                    SeoDescription = "Sản phẩm áo thời trang nam",
                    SeoTitle = "Sản phẩm áo thời trang nam",
                    Details = "Mô tả sản phẩm",
                    Description = ""
                },
                    new ProductTranslation()
                    {
                        Id = 2,
                        ProductId = 1,
                        Name = "Men Shirt",
                        LanguageId = "en-US",
                        SeoAlias = "men-shirt",
                        SeoDescription = "The shirt product for men",
                        SeoTitle = "The shirt product for men",
                        Details = "Description of product",
                        Description = ""
                    }
                );
            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() { ProductId = 1, CategoryId = 1 }
                );
        }
    }
}

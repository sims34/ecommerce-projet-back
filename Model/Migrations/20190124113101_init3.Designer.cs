﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

namespace Model.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20190124113101_init3")]
    partial class init3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.4-rtm-31024")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Model.Models.Account", b =>
                {
                    b.Property<Guid>("IdAccount")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("BillAddress");

                    b.Property<DateTime>("Closed");

                    b.Property<Guid>("CustomerId");

                    b.Property<bool>("IsClosed");

                    b.Property<DateTime>("Open");

                    b.HasKey("IdAccount");

                    b.HasIndex("CustomerId");

                    b.ToTable("Account");

                    b.HasData(
                        new { IdAccount = new Guid("b658db19-f5e5-40cf-a44b-84f2854786c7"), BillAddress = "5 avenue new-york, usa", Closed = new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), CustomerId = new Guid("544b8263-44ff-4450-8026-e4bdbbb6b06a"), IsClosed = true, Open = new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                        new { IdAccount = new Guid("76427a7a-5b66-4b36-9643-2c6630009535"), BillAddress = "5 avenue new-york, usa", Closed = new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), CustomerId = new Guid("b79d1b9c-4ded-42fb-964a-0fea6ea0f62e"), IsClosed = true, Open = new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) }
                    );
                });

            modelBuilder.Entity("Model.Models.Article", b =>
                {
                    b.Property<Guid>("IdArticle")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Activate");

                    b.Property<int>("DelievryTime");

                    b.Property<string>("Description");

                    b.Property<string>("Label");

                    b.Property<int>("PriceHT");

                    b.Property<int>("Tax");

                    b.HasKey("IdArticle");

                    b.ToTable("Articles");

                    b.HasData(
                        new { IdArticle = new Guid("78ace119-29bc-4903-a68f-fa10db32bcbf"), Activate = true, DelievryTime = 3, Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", Label = "Creme hydradanteXXL", PriceHT = 12, Tax = 3 },
                        new { IdArticle = new Guid("78ace119-29bc-4903-a68f-fa10db32bcaa"), Activate = true, DelievryTime = 3, Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", Label = "Creme hydradanteXXL", PriceHT = 12, Tax = 3 },
                        new { IdArticle = new Guid("78ace119-29bc-4903-a68f-fa10db32bcbb"), Activate = true, DelievryTime = 3, Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", Label = "pomade tonic", PriceHT = 12, Tax = 3 },
                        new { IdArticle = new Guid("781131c9-4329-4364-8449-91d7ef41ce76"), Activate = true, DelievryTime = 3, Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", Label = "Creme hydradanteXXL", PriceHT = 12, Tax = 3 }
                    );
                });

            modelBuilder.Entity("Model.Models.Basket", b =>
                {
                    b.Property<Guid>("BasketId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("AccountId");

                    b.HasKey("BasketId");

                    b.HasIndex("AccountId")
                        .IsUnique();

                    b.ToTable("Basket");

                    b.HasData(
                        new { BasketId = new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"), AccountId = new Guid("76427a7a-5b66-4b36-9643-2c6630009535") }
                    );
                });

            modelBuilder.Entity("Model.Models.BasketItems", b =>
                {
                    b.Property<Guid>("IdBasketItems")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("ArticleId");

                    b.Property<Guid>("BasketId");

                    b.Property<int>("Quantity");

                    b.Property<int>("UnitePrice");

                    b.HasKey("IdBasketItems");

                    b.HasIndex("ArticleId");

                    b.HasIndex("BasketId");

                    b.ToTable("BasketItems");

                    b.HasData(
                        new { IdBasketItems = new Guid("64fcf97c-532e-4fba-8631-6ff30c34737e"), ArticleId = new Guid("781131c9-4329-4364-8449-91d7ef41ce76"), BasketId = new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"), Quantity = 4, UnitePrice = 12 },
                        new { IdBasketItems = new Guid("ae391168-1b22-40fb-aa78-b90df5803458"), ArticleId = new Guid("781131c9-4329-4364-8449-91d7ef41ce76"), BasketId = new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"), Quantity = 8, UnitePrice = 190 },
                        new { IdBasketItems = new Guid("196784ef-6277-4bfe-ba27-abc92f252b54"), ArticleId = new Guid("781131c9-4329-4364-8449-91d7ef41ce76"), BasketId = new Guid("e9b16999-f9c9-49c4-956a-56f583c29ddf"), Quantity = 40, UnitePrice = 1200 }
                    );
                });

            modelBuilder.Entity("Model.Models.InventoryItem", b =>
                {
                    b.Property<Guid>("InventoryItemId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ArticleIdArticle");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Quantity");

                    b.HasKey("InventoryItemId");

                    b.HasIndex("ArticleIdArticle");

                    b.ToTable("InventoryItem");
                });

            modelBuilder.Entity("Model.Models.InventorySystem", b =>
                {
                    b.Property<Guid>("InventorySysID")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid?>("ArticleIdArticle");

                    b.Property<DateTime>("DateInventory");

                    b.Property<int>("Quantity");

                    b.HasKey("InventorySysID");

                    b.HasIndex("ArticleIdArticle");

                    b.ToTable("InventorySystem");
                });

            modelBuilder.Entity("Model.Models.Login", b =>
                {
                    b.Property<Guid>("LoginId")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("CustomerId");

                    b.Property<string>("Password");

                    b.Property<string>("Username");

                    b.HasKey("LoginId");

                    b.HasIndex("CustomerId");

                    b.ToTable("Logins");

                    b.HasData(
                        new { LoginId = new Guid("38251ab3-29b9-4694-89c0-2401cf5b947e"), CustomerId = new Guid("544b8263-44ff-4450-8026-e4bdbbb6b06a"), Password = "admin", Username = "admin" },
                        new { LoginId = new Guid("f0d26437-5a74-4f4f-bf4f-3f244c58ec92"), CustomerId = new Guid("b79d1b9c-4ded-42fb-964a-0fea6ea0f62e"), Password = "admin", Username = "admin" }
                    );
                });

            modelBuilder.Entity("Model.Models.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasDiscriminator<string>("Discriminator").HasValue("User");
                });

            modelBuilder.Entity("Model.Models.Customer", b =>
                {
                    b.HasBaseType("Model.Models.User");

                    b.Property<string>("Address");

                    b.Property<string>("Country");

                    b.Property<string>("Mail");

                    b.Property<int>("Status");

                    b.ToTable("Customer");

                    b.HasDiscriminator().HasValue("Customer");

                    b.HasData(
                        new { UserId = new Guid("544b8263-44ff-4450-8026-e4bdbbb6b06a"), FirstName = "John", LastName = "Smith", Address = "2 Avenue NEW-YORK, USA", Country = "USA", Mail = "smith@john.com", Status = 1 },
                        new { UserId = new Guid("b79d1b9c-4ded-42fb-964a-0fea6ea0f62e"), FirstName = "John", LastName = "Smith", Address = "2 Avenue NEW-YORK, USA", Country = "USA", Mail = "smith@john.com", Status = 1 }
                    );
                });

            modelBuilder.Entity("Model.Models.Account", b =>
                {
                    b.HasOne("Model.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.Models.Basket", b =>
                {
                    b.HasOne("Model.Models.Account", "Account")
                        .WithOne("Basket")
                        .HasForeignKey("Model.Models.Basket", "AccountId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.Models.BasketItems", b =>
                {
                    b.HasOne("Model.Models.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Model.Models.Basket", "Basket")
                        .WithMany("BasketItems")
                        .HasForeignKey("BasketId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Model.Models.InventoryItem", b =>
                {
                    b.HasOne("Model.Models.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleIdArticle");
                });

            modelBuilder.Entity("Model.Models.InventorySystem", b =>
                {
                    b.HasOne("Model.Models.Article", "Article")
                        .WithMany()
                        .HasForeignKey("ArticleIdArticle");
                });

            modelBuilder.Entity("Model.Models.Login", b =>
                {
                    b.HasOne("Model.Models.Customer", "Customer")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}

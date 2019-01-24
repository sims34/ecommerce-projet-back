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
    [Migration("20190124113912_init8")]
    partial class init8
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
                        new { IdAccount = new Guid("72f8f597-273b-4698-9187-21e2244b456f"), BillAddress = "5 avenue new-york, usa", Closed = new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), CustomerId = new Guid("63f1d157-f395-4349-a236-d1160839a0f0"), IsClosed = true, Open = new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) },
                        new { IdAccount = new Guid("76fb3627-a80e-47c2-8cde-08f9b1863596"), BillAddress = "5 avenue new-york, usa", Closed = new DateTime(2020, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), CustomerId = new Guid("75d13d33-003a-46e9-83a3-7ebd94326bd8"), IsClosed = true, Open = new DateTime(2019, 1, 24, 0, 0, 0, 0, DateTimeKind.Local) }
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
                        new { IdArticle = new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"), Activate = true, DelievryTime = 3, Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.", Label = "Creme hydradanteXXL", PriceHT = 12, Tax = 3 }
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
                        new { BasketId = new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"), AccountId = new Guid("76fb3627-a80e-47c2-8cde-08f9b1863596") }
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
                        new { IdBasketItems = new Guid("4f73de1f-1e0d-434f-9b7e-493ba2108274"), ArticleId = new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"), BasketId = new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"), Quantity = 4, UnitePrice = 12 },
                        new { IdBasketItems = new Guid("ccee01db-8602-41f7-b5be-29fcb05f209e"), ArticleId = new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"), BasketId = new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"), Quantity = 8, UnitePrice = 190 },
                        new { IdBasketItems = new Guid("a98a531a-d453-422c-a463-62022024f51c"), ArticleId = new Guid("ebe7773e-53f1-4ed2-9716-ba954f9e9f82"), BasketId = new Guid("a065cd6f-7d1a-4961-8e90-d86754c76cb7"), Quantity = 40, UnitePrice = 1200 }
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
                        new { LoginId = new Guid("ff39f610-d3c9-4b53-afa4-611b380daf4a"), CustomerId = new Guid("63f1d157-f395-4349-a236-d1160839a0f0"), Password = "admin", Username = "admin" },
                        new { LoginId = new Guid("51683197-df81-4f4e-bfa8-057d5cc239f0"), CustomerId = new Guid("75d13d33-003a-46e9-83a3-7ebd94326bd8"), Password = "admin", Username = "admin" }
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
                        new { UserId = new Guid("63f1d157-f395-4349-a236-d1160839a0f0"), FirstName = "John", LastName = "Smith", Address = "2 Avenue NEW-YORK, USA", Country = "USA", Mail = "smith@john.com", Status = 1 },
                        new { UserId = new Guid("75d13d33-003a-46e9-83a3-7ebd94326bd8"), FirstName = "John", LastName = "Smith", Address = "2 Avenue NEW-YORK, USA", Country = "USA", Mail = "smith@john.com", Status = 1 },
                        new { UserId = new Guid("2843e84b-9fc5-4c42-b949-a1c4d1611c65"), FirstName = "JOJO", LastName = "Smith", Address = "2 Avenue NEW-YORK, USA", Country = "USA", Mail = "smith@john.com", Status = 1 },
                        new { UserId = new Guid("bb2bbc75-2184-470c-87e6-c78947ecd35a"), FirstName = "MAMA", LastName = "Smith", Address = "2 Avenue NEW-YORK, USA", Country = "USA", Mail = "smith@john.com", Status = 1 },
                        new { UserId = new Guid("454b9371-498d-40d5-9477-b5ffcfe39e67"), FirstName = "MAMI", LastName = "Smith", Address = "2 Avenue NEW-YORK, USA", Country = "USA", Mail = "smith@john.com", Status = 1 },
                        new { UserId = new Guid("dff42d6d-855f-4e22-ade5-55caf903bbf6"), FirstName = "JAJAJ", LastName = "Smith", Address = "2 Avenue NEW-YORK, USA", Country = "USA", Mail = "smith@john.com", Status = 1 }
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
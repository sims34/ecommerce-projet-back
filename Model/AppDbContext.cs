using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;

namespace Model
{
    public class AppDbContext : DbContext
    {

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Admin> Admin { get; set; }
        public DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Basket> Basket { get; set; }
        public DbSet<BasketItems> BasketItems { get; set; }
        public DbSet<Account> Account { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        protected override void OnConfiguring(DbContextOptionsBuilder optionbuilder)
        {
            if (!optionbuilder.IsConfigured)
            {
                optionbuilder.UseMySql("server=localhost;port=3306;database=myapp;uid=root");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Article>().HasData(
                 new Article
                 {
                     IdArticle = Guid.NewGuid(),
                     Label = "POMADE hydradanteXXL-MXL",
                     Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                     PriceHT = 12,
                     Tax = 3,
                     Activate = true,
                     DelievryTime = 3
                 },
                new Article
                {
                    IdArticle = Guid.NewGuid(),
                    Label = "Creme hydradanteXXL",
                    Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                    PriceHT = 12,
                    Tax = 3,
                    Activate = true,
                    DelievryTime = 3
                },
                new Article
                {
                    IdArticle = Guid.NewGuid(),
                    Label = "pomade tonic",
                    Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                    PriceHT = 12,
                    Tax = 3,
                    Activate = true,
                    DelievryTime = 3
                });
            
        }
    }
}

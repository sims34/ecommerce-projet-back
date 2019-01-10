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
            new SeedContextArticle(modelBuilder);
            new SeedContextAccount(modelBuilder);
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Model.Models;
using System;

namespace Model
{
    public class AppDbContext : DbContext
    {
        
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        
          protected override void OnConfiguring(DbContextOptionsBuilder optionBuilder)
        {
            if (!optionBuilder.IsConfigured)
            {
                optionBuilder.UseMySql("server=localhost;port=3306;database=myApp;uid=root;password=root");
            }
        }
        
        public  DbSet<Customer> Customers { get; set; }
        public  DbSet<Seller> Sellers { get; set; }
        public  DbSet<Article> Articles { get; set; }
        public DbSet<User> Users { get; set; }
       

        
    }
}

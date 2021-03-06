﻿using Microsoft.EntityFrameworkCore;
using Model;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_commerceProject
{
    public class SeedContextBasket
{
        public SeedContextBasket(ModelBuilder modelBuilder)
        {
            var johnSmith = new Customer
            {
                UserId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Smith",
                Mail = "smith@john.com",
                Address = "2 Avenue NEW-YORK, USA",
                Country = "USA",
                Status = StatusUser.Active,

            };
            modelBuilder.Entity<Customer>().HasData(johnSmith);

            var login = new Login
            {
                LoginId = Guid.NewGuid(),
                Password = "admin",
                Username = "admin",
               // Customer = johnSmith
            };

            modelBuilder.Entity<Login>().HasData(login);
            var account = new Account
            {
                IdAccount = Guid.NewGuid(),
                BillAddress = "5 avenue new-york, usa",
                IsClosed = true,
                Open = DateTime.Today,
                Closed = new DateTime(2020, 12, 31),
                Customer = johnSmith,
            };

            modelBuilder.Entity<Account>().HasData(account);

            var basket = new Basket
            {
                BasketId = Guid.NewGuid(),
                AccountId =account.IdAccount,
            };

       

            var toto = new Article
            {
                IdArticle = Guid.NewGuid(),
                PriceHT = 12,
                Tax = 3,
                Activate = true,
                Label = "Creme hydradanteXXL",
                Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                DelievryTime = 3
            };

            modelBuilder.Entity<Article>().HasData(toto);


            var basketItems = new BasketItem[]
            {
                 new BasketItem
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 12,
                     Quantity = 4,
                     ArticleId   = toto.IdArticle,
                      BasketId =  basket.BasketId,
                 },
                 new BasketItem
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 190,
                     Quantity = 8,
                        ArticleId   = toto.IdArticle,
                    BasketId =  basket.BasketId,
                },
                 new BasketItem
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 1200,
                     Quantity = 40,
                         ArticleId   = toto.IdArticle,
                     BasketId =  basket.BasketId,

                }
            };

            modelBuilder.Entity<BasketItem>().HasData(basketItems);

            modelBuilder.Entity<Basket>().HasData(basket);


        }
    }
}

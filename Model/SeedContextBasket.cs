using Microsoft.EntityFrameworkCore;
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

            var johnSmith = new Customer("John", "Smith", "smith@john.com", "2 Avenue NEW-YORK, USA", "USA", StatusUser.Active);

            var account = new Account
            {
                IdAccount = Guid.NewGuid(),
                BillAddress = "5 Avenue NEW-YORK, USA",
                IsClosed = true,
                Open = DateTime.Today,
                Closed = new DateTime(2020, 12, 31),
                UserId = johnSmith.UserId
            };
            var toto = new Article
            {
                IdArticle = new Guid("78ace119-29bc-4903-a68f-fa10db32bcbf"),
                PriceHT = 12,
                Tax = 3,
                Activate = true,
                Label = "Creme hydradanteXXL",
                Description = "Poterit ut Antiochensi dispelleret Antiochensi ut obsecranti principibus victu adesset.",
                DelievryTime = 3
            };


            modelBuilder.Entity<Account>().HasData(account);

            var basket = new Basket
            {
                BasketId = Guid.NewGuid(),
                AccountId = account.IdAccount,
            };
            modelBuilder.Entity<Basket>().HasData(basket);


            var basketItems = new BasketItems[]
            {
                 new BasketItems
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 12,
                     Quantity = 4,
                     ArticleId   = toto.IdArticle,
                     BasketId =  basket.BasketId,
                 },
                 new BasketItems
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 190,
                     Quantity = 8,
                     ArticleId   = toto.IdArticle,
                     BasketId = basket.BasketId,

                },
                 new BasketItems
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 1200,
                     Quantity = 40,
                     ArticleId   = toto.IdArticle,
                     BasketId =  basket.BasketId,

                }
            };
            modelBuilder.Entity<BasketItems>().HasData(basketItems);

        }
    }
}

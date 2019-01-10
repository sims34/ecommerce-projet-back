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
            var basketId = Guid.NewGuid();
            var jojo = new User
            {
                UserId = Guid.NewGuid(),
                FirstName = "John",
                LastName = "Smith",
                Mail = "smith@john.com",
                Address = "2 Avenue NEW-YORK, USA",
                Country = "USA"
            };
            var account = new Account
            {
               IdAccount = Guid.NewGuid(),
                BillAddress = "5 Avenue NEW-YORK, USA",
                IsClosed = true,
                Open = DateTime.Today,
                Closed = new DateTime(2020, 12, 31),
                UserId = jojo.UserId
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
            List<BasketItems> basketItems = new List<BasketItems>
            {
                 new BasketItems
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 12,
                     Quantity = 4,
                     ArticleId   = toto.IdArticle,
                     BasketId = basketId,
                   
                },
                 new BasketItems
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 190,
                     Quantity = 8,
                     ArticleId   = toto.IdArticle,
                     BasketId = basketId,

                },
                 new BasketItems
                 {
                     IdBasketItems = Guid.NewGuid(),
                     UnitePrice= 1200,
                     Quantity = 40,
                     ArticleId   = toto.IdArticle,
                     BasketId = basketId,

                }
            };
            var basket = new Basket
            {
                BasketId = basketId,
                Account = account,
                BasketItems = basketItems
            };

            modelBuilder.Entity<Basket>().HasData(basket);

        }
}
}

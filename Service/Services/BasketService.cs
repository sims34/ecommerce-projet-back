using Model.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Service.Services
{


    public class BasketService : ServiceBase<Basket>, IBasketService
    {

        private readonly IBasketRepository _basketRepository;

        public BasketService(IBasketRepository repo) : base(repo)
        {
            _basketRepository = repo;
        }

        public bool AddItemsToBasket(Guid basketId, BasketItems basketItem)
        {
            var basket = _basketRepository.Find(basketId);
            
            if (basket == null || IsExistingItem(basket,basketItem)) return false;
            
             _basketRepository.AddItems(basketId, basketItem);
            return true;
        }

        public int GetBasketItemsCount(Guid basketId)
        {
            throw new NotImplementedException();
        }

        public int GetQuantityTotal(Guid basketId)
        {
            var basket = _basketRepository.Find(basketId);
            int qtiteTotalItems = basket.BasketItems.Sum(i => i.Quantity);
            return qtiteTotalItems;
        }

        public int GetTotalPriceBasket(Guid basketId)
        {
            var basket = _basketRepository.Find(basketId);
            int totalPrice = basket.BasketItems.Sum(i => i.UnitePrice * i.Quantity);
            return totalPrice;
        }

        public bool IsExistingItem(Basket basket, BasketItems basketItem)
        {
            var existingItem = basket.BasketItems.FirstOrDefault(i => 
            i.Article.IdArticle == basketItem.Article.IdArticle);

            if (existingItem == null) return false;

            existingItem.Quantity += basketItem.Quantity;
            return true;
        }

    }
}

    
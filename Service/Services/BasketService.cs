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

        public bool AddItemsToBasket(int basketId, BasketItems basketItems)
        {
            var basket = _basketRepository.FindById(basketId);
            if (basket == null)
            {
                return false;
            }
            _basketRepository.AddItems(basketId, basketItems);
            return true;
        }

        public int GetBasketItemsCount(int basketId)
        {
            throw new NotImplementedException();
        }

        public int GetQuantityTotal(int basketId)
        {
            var basket = _basketRepository.FindById(basketId);
            int qtiteTotalItems = basket.BasketItems.Sum(i => i.Quantity);
            return qtiteTotalItems;
        }

        public int GetTotalPriceBasket(int basketId)
        {
            var basket = _basketRepository.FindById(basketId);
            int totalPrice = basket.BasketItems.Sum(i => i.UnitePrice * i.Quantity);
            return totalPrice;
        }
    }
}

    
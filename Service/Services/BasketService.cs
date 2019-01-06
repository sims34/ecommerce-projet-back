using Model.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BasketService : ServiceBase<Basket>, IBasketService
    {
        
        private readonly IBasketRepository _basketRepository;

        public BasketService(  IBasketRepository repo) :base(repo)
        {
            _basketRepository = repo;
        }

        public bool AddItemsToBasket(int basketId, BasketItems basketItems)
        {
            var basket = _basketRepository.FindById(basketId);
            if( basket == null)
            {
                return false;
            }
            _basketRepository.AddItems(basketItems);
            return true;
        }

        public int GetBasketItemsCount(int basketId)
        {
            return 0;
        }
    }
}
    
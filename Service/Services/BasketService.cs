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
        
        private readonly IBasketRepository _repo;
        private readonly IBasketItemsRepository _basketItemsRepository;
        private readonly IArticleRepository _articleRepository;

        public BasketService(IArticleRepository articleRepository, IBasketItemsRepository basketItemsRepository, IBasketRepository repo)
            :base(repo)
        { 
            _repo = repo;
            _basketItemsRepository = basketItemsRepository;
            _articleRepository = articleRepository;
        }
        public bool AddItemsToBasket(int basketId, BasketItems basketItems)
        {
           
            return false;
        }

        public int GetBasketItemsCount()
        {
            throw new NotImplementedException();
        }
    }
}

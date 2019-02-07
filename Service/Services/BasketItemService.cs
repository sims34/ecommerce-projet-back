using Model.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class BasketItemService : ServiceBase<BasketItem>, IBasketItemService
    {
        private readonly IBasketItemRepository _basketItemRepository;

        public BasketItemService(IBasketItemRepository repo) : base(repo)
        {
            _basketItemRepository = repo;
        }

        public void AddArticleOrCreate(Article article, BasketItem basketItem)
        {
            _basketItemRepository.AddArticleToBasketItem(article, basketItem);
        }
    }
}

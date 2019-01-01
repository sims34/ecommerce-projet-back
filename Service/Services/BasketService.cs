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
        private readonly IBasketItemsRepository _basketItemsRepository;
        private readonly IArticleRepository _articleRepository;

        
    }
}

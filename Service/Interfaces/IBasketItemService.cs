using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IBasketItemService : IServiceBase<BasketItem>
    {
        void AddArticleOrCreate(Article article, BasketItem basketItem);
    }
}

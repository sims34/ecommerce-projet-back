using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IBasketService : IServiceBase<Basket>
    {
        int GetBasketItemsCount(Guid basketId);
        bool AddItemsToBasket(Guid basketId, BasketItems basketItems);
        int GetTotalPriceBasket(Guid basketId);
        int GetQuantityTotal(Guid basketId);
        bool IsExistingItem(Basket basket, BasketItems basketItem);
    }
}

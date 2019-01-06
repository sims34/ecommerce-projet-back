using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IBasketService : IServiceBase<Basket>
    {
        int GetBasketItemsCount(int basketId);
        bool AddItemsToBasket(int basketId, BasketItems basketItems);
        //setQuantity

    }
}

using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IBasketRepository : IRepositoryBase<Basket>
    {
        void AddItems(Guid basketId,BasketItem basketItems); //into list type : BasketItems

        List<BasketItem> GetBasketItems(Guid basketId);
       
    }
}

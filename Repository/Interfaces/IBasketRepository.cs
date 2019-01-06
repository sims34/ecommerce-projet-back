using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IBasketRepository : IRepositoryBase<Basket>
    {
        void AddItems(BasketItems basketItems); //into list type : BasketItems

        List<BasketItems> GetBasketItems(int basketId);
    }
}

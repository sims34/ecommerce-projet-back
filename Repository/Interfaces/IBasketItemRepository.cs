﻿using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IBasketItemRepository : IRepositoryBase<BasketItem>
    {
        void AddArticleToBasketItem(Article article, BasketItem basketItem);
    }
}

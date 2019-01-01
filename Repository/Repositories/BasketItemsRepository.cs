using Model;
using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class BasketItemsRepository : RepositoryBase<BasketItems>, IBasketItemsRepository
    {
        public BasketItemsRepository(AppDbContext context) : base(context)
        {
        }
    }
}

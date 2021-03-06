﻿using Microsoft.EntityFrameworkCore;
using Model;
using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class BasketRepository : RepositoryBase<Basket>, IBasketRepository
    {
      
        public BasketRepository(AppDbContext context) : base(context)
        {

        }
        public override Basket Find (Guid id)
        {
            // return _context.Basket.Find(id);
            return base._context.Basket
                .Include(x => x.BasketItems)
                .Include("BasketItems.Article")
                .FirstOrDefault(b => b.BasketId == id);
        }

        public virtual void AddItems(Guid basketId, BasketItem basketItem)
        {
            var basket = _context.Basket.First(x => x.BasketId == basketId);
            basketItem.Basket = basket;
            _context.Add(basketItem);
            _context.SaveChanges();

        }

       

        public virtual List<BasketItem> GetBasketItems(Guid basketId)
        {
            return this.Find(basketId).BasketItems;
        }
    }
}

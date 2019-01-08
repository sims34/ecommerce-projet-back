using Microsoft.EntityFrameworkCore;
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
        public override Basket FindById(int id)
        {
            // return _context.Basket.Find(id);
            return base._context.Basket
                .Include(x => x.BasketItems)
                .Include("BasketItems.Article")
                .FirstOrDefault(b => b.BasketId == id);
        }

        public virtual void AddItems(int basketId, BasketItems basketItem)
        {
            var basket = _context.Basket.First(x => x.BasketId == basketId);
            basketItem.Basket = basket;
            _context.Add(basketItem);
            _context.SaveChanges();

            /* check service
            _items = GetBasketItems(basketId);

            Items = _items.AsReadOnly();

            if (!Items.Any(i => i.IdBasketItems == basketItems.IdBasketItems))
            {
                _items.Add(basketItems);
                return;
            }
            var existingItem = _items.FirstOrDefault(i => i.IdBasketItems == basketItems.IdBasketItems);
            existingItem.Quantity += basketItems.Quantity;*/
        }

       

        public virtual List<BasketItems> GetBasketItems(int basketId)
        {
            return this.FindById(basketId).BasketItems;
        }
    }
}

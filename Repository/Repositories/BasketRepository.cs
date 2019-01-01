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
        public List<BasketItems> _items = new List<BasketItems>();
        public IReadOnlyCollection<BasketItems> Items => _items.AsReadOnly();
        
        public BasketRepository(AppDbContext context) : base(context)
        {

        }

        public virtual void AddItems(BasketItems basketItems)
        {
            if (!Items.Any(i => i.IdBasketItems == basketItems.IdBasketItems))
            {
                _items.Add(basketItems);
                return;
            }
            var existingItem = Items.FirstOrDefault(i => i.IdBasketItems == basketItems.IdBasketItems);
            existingItem.Quantity += basketItems.Quantity;
        }
    }
}

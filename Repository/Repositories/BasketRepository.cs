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
        private List<BasketItems> _items;
        private IReadOnlyCollection<BasketItems> Items;


        public BasketRepository(AppDbContext context) : base(context)
        {

        }
        public override Basket FindById(int id)
        {
            return base._context.Basket.FirstOrDefault(b => b.BasketId == id);
        }

        public virtual void AddItems(int basketId, BasketItems basketItems)
        {
            _items = GetBasketItems(basketId);

            Items = _items.AsReadOnly();

            if (!Items.Any(i => i.IdBasketItems == basketItems.IdBasketItems))
            {
                _items.Add(basketItems);
                return;
            }
            var existingItem = _items.FirstOrDefault(i => i.IdBasketItems == basketItems.IdBasketItems);
            existingItem.Quantity += basketItems.Quantity;
        }

       

        public virtual List<BasketItems> GetBasketItems(int basketId)
        {
            var basket = this.FindById(basketId);


            var basketItems = basket.BasketItems;

            return basketItems;
        }
    }
}

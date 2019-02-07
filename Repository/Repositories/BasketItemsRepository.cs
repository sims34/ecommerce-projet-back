using Microsoft.EntityFrameworkCore;
using Model;
using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Repositories
{
    public class BasketItemsRepository : RepositoryBase<BasketItem>, IBasketItemRepository
    {
        public BasketItemsRepository(AppDbContext context) : base(context)
        {
        }

        public void AddArticleToBasketItem(Article article, BasketItem basketItem)
        {
            var bi = _context.BasketItems.Find(basketItem.IdBasketItems);
            if(bi != null)
            {
                if(bi.ArticleId == article.IdArticle)
                {
                    bi.Quantity = basketItem.Quantity;
                    base.SaveChanges();
                }
               
            }
            basketItem.Article = article;
            base.Add(basketItem);
            base.SaveChanges();
        }
    }
}

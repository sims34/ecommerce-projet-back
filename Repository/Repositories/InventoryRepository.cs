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
    public class InventoryRepository : RepositoryBase<InventorySystem>, IInventoryRepository
    {
        public InventoryRepository(AppDbContext context) : base(context)
        {
        }

        

        //public void AddArticle(Article article, int quantityToAdd)
        //{
        //    while (quantityToAdd > 0)
        //    {
        //        var articleExist = _context.Articles.FirstOrDefault(x => x.IdArticle == article.IdArticle);
        //        if (articleExist == null)
        //        {
        //            var obj = new InventoryItem(article, quantityToAdd);
        //            _context.Add(obj);
        //            _context.SaveChanges();
        //        }
        //        else
        //        {
        //           var inventoryItem = _context.InventoryItem;
        //        }
        //    }

        //}
        
    }
}

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
    public class InventoryRepository : RepositoryBase<InventoryItem>, IInventoryRepository
    {
        public InventoryRepository(AppDbContext context) : base(context)
        {
        }


        public override void Add(InventoryItem entity)
        {
            while (entity.Quantity > 0)
            {
                var articleExist = _context.InventoryItem.Include("Article").FirstOrDefault(x => x.Article.IdArticle == entity.Article.IdArticle);
                if (articleExist == null)
                {
                    var newArticle = entity;
                    _context.Add(entity);
                    _context.SaveChanges();

                }
                articleExist.Quantity += entity.Quantity;
                articleExist.Date = entity.Date;
            }

        }
        public override InventoryItem Find(Guid id)
        {
            var ArticleItem = _context.Articles.Find(id);
            var Inventory = _context.InventoryItem.Include("Article").FirstOrDefault(x => x.Article.IdArticle == ArticleItem.IdArticle);
            return Inventory;
        }
    }
    }


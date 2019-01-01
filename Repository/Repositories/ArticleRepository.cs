using Model;
using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository.Repositories
{
    public class ArticleRepository : RepositoryBase<Article>, IArticleRepository
    {
        
        public ArticleRepository(AppDbContext context) : base(context)
        {
        }

       
        public virtual Article GetById(Guid id)
        {
            
            return _context.Articles.FirstOrDefault(x => x.IdArticle == id);
        }

        public override bool Remove(Article entity)
        {
            var RemoveEntity = base.Find(entity.IdArticle);
            if(RemoveEntity != null)
            {
                base.Remove(RemoveEntity);

                base.SaveChanges();
                return true;

            }
            return false;
        }

        public bool RemoveById(Guid id)
        {
            var obj = base.Find(id);
            if(obj != null)
            {
                base.Remove(obj);
                base.SaveChanges();
                return true;
            }
            return false;
        }

        public override bool Update(Guid id,Article entity)
        {
            var UpdateEntity = base.Find(id);
            if (UpdateEntity != null)
            {
                UpdateEntity.Label = entity.Label;
                UpdateEntity.PriceHT = entity.PriceHT;
                UpdateEntity.Tax = entity.Tax;
                UpdateEntity.Activate = entity.Activate;
                UpdateEntity.DelievryTime = entity.DelievryTime;
                UpdateEntity.Description = entity.Description;
                base.Update(id,UpdateEntity);
                base.SaveChanges();
                return true;
            }
            return false;
        }
    }
}

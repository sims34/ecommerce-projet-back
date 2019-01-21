using Model.Models;
using Repository.Interfaces;
using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Services
{
    public class ArticleService :  ServiceBase<Article>, IArticleService
    {
        private readonly IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository repo) : base(repo)
        {
            _articleRepository = repo;
        }

        public IArticleRepository Object => throw new NotImplementedException();

        public override void Add(Article entity)
        {
            base.Add(entity);
            //var AddEntity = base.Find(entity.IdArticle);
            //if(AddEntity == null)
            //{
            //}
        }
        //public  virtual Article GetArticle(Guid id)
        //{
        //    return _articleRepository.Find(id);
        //}

        public virtual bool RemoveById(Guid id)
        {
            _articleRepository.RemoveById(id);
            return true;
        }
    }
}

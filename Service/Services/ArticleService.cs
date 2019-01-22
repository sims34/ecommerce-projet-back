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

        public  bool RemoveById(Guid id)
        {
            _articleRepository.RemoveById(id);
            return true;
        }
    }
}

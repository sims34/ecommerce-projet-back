using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.Interfaces
{
    public interface IArticleRepository : IRepositoryBase<Article>
    {
        bool RemoveById(Guid id);
        List<Article> SetArticleFirst(Article article);
    }
}

using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IArticleService : IServiceBase<Article>
    {
        bool RemoveById(Guid id);
        Article GetArticle(Guid id);
    }
}

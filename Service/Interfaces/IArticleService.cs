using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IArticleService : IServiceBase<Article>
    {
        IArticleRepository Object { get; }

        bool RemoveById(Guid id);
        //Article GetArticle(Guid id);
    }
}

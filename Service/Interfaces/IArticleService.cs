﻿using Model.Models;
using Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Service.Interfaces
{
    public interface IArticleService : IServiceBase<Article>
    {
        bool RemoveById(Guid id);
    }
}

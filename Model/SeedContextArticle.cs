using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model.Factories;
using Model.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class SeedContextArticle
    {
        public SeedContextArticle(ModelBuilder entityBuilder)
        {
            entityBuilder.Entity<Article>().HasData(ArticleFactory.DefaultArticles);
        }
    }
}

using E_commerceProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Models;
using Moq;
using Repository.Interfaces;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository.Test
{
    [TestClass]
    public class ArticleServiceTest
    {

        private readonly Mock<IArticleRepository> _articleRepository;
        private readonly IArticleService  articleService;
        public ArticleServiceTest()
        {
            _articleRepository = new Mock<IArticleRepository>();
            articleService = new ArticleService(_articleRepository.Object); 
             //_articleController = new ArticleController(_articleService);
        }
        [TestMethod]
        public void GivenArticleObject_WhenFindArticleById_ThenArticle()
        {
            var ArticleId = Guid.NewGuid();
            var article = new Article();
            List<Article> articles = new List<Article>
                {
                    new Article {IdArticle = ArticleId },
                    new Article { IdArticle = ArticleId},
                    new Article { IdArticle = ArticleId }
                };

            _articleRepository.Setup(mr => mr.Find(ArticleId)).Returns(article);
           
            var dataToTest = articleService.Find(ArticleId);
            Assert.IsNotNull(dataToTest);
        }
        [TestMethod]
        public void GivenArticleList_WhenGetAll_ThenArticle()
        {
            var ArticleId = Guid.NewGuid();
            List<Article> articles = new List<Article>
                {
                    new Article {IdArticle = ArticleId },
                    new Article { IdArticle = ArticleId},
                    new Article { IdArticle = ArticleId }
                };

            _articleRepository.Setup(mr => mr.GetAll()).Returns(articles);

            var dataToTest = articleService.GetAll();
            Assert.IsNotNull(dataToTest);
        }

        [TestMethod]
        public void GivenArticleList_WhenUpdateById_ThenArticle()
        {
            var ArticleId = Guid.NewGuid();
            var article = new Article();
            List<Article> articles = new List<Article>
                {
                    new Article {IdArticle = ArticleId },
                    new Article { IdArticle = ArticleId},
                    new Article { IdArticle = ArticleId }
                };
            // Find a product by id
            _articleRepository.Setup(mr => mr.Find(It.IsAny<Guid>())).Returns((article));


            article = articleService.Find(ArticleId);
            // Change one of its properties
            article.Label = "C# 3.5 Unleashed";

            // Save our changes.
            articleService.SaveChanges();
            // Verify the change
            Assert.AreEqual("C# 3.5 Unleashed", articleService.Find(article.IdArticle).Label);
        }
    }
    }


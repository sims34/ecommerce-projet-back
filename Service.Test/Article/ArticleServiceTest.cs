using E_commerceProject.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Models;
using Moq;
using Repository.Interfaces;
using Service.Interfaces;
using Service.Services;
using System;

namespace Repository.Test
{
    [TestClass]
    public class ArticleServiceTest
    {

        private readonly Mock<IArticleRepository> _articleRepository;
        private readonly Mock<IArticleService>  _articleService;
        private readonly ArticleController _articleController;
        public ArticleServiceTest()
        {
            _articleRepository = new Mock<IArticleRepository>();
            _articleService = new Mock<IArticleService>();
             _articleController = new ArticleController(_articleService.Object);
        }
        [TestMethod]
        public void GivenArticleObject_WhenAddingNewArticle_ThenArticle()
        {
            var ArticleId = Guid.NewGuid();
            var ArticleTest = new Article()
            {
                IdArticle = ArticleId
            };
            var res = _articleController.Post(ArticleTest);

           
            Assert.Equals(res, ArticleTest.IdArticle);
        }
    }
    }


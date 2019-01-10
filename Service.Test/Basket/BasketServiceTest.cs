using Microsoft.VisualStudio.TestTools.UnitTesting;
using Model.Models;
using Moq;
using Repository.Interfaces;
using Repository.Repositories;
using Service.Interfaces;
using Service.Services;
using System;
using System.Collections.Generic;

namespace Service.Test
{
    [TestClass]
    public class BasketServiceTest
    {
        private IBasketService _basketService;
        private Mock<IBasketRepository> _basketRepository;

        public BasketServiceTest()
        {
            _basketRepository = new Mock<IBasketRepository>();
            _basketService = new BasketService(_basketRepository.Object);
        }

        [TestMethod]
        public void GivenAddNewItem_WhenItemExiting_ThenReturnfalse()
        {
            var articleGuid = Guid.NewGuid();
            var basket = new Basket();
            var bi = new BasketItems()
            {
                Article = new Article() { IdArticle = articleGuid }
            };
            basket.BasketItems = new List<BasketItems>();
            basket.BasketItems.Add(bi);

            _basketRepository.Setup(x => x.Find(articleGuid)).Returns(basket);
            var res = _basketService.AddItemsToBasket(articleGuid, bi);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void GivenAddNewItem_WhenNotItemExiting_ThenReturnTrue()
        {
            var articleGuid = Guid.NewGuid();
            var basket = new Basket();
            var bi = new BasketItems()
            {
                Article = new Article() { IdArticle = Guid.NewGuid() }
            };
            basket.BasketItems = new List<BasketItems>();
            basket.BasketItems.Add(bi);

            _basketRepository.Setup(x => x.Find(articleGuid)).Returns(basket);

            var res = _basketService.AddItemsToBasket(articleGuid, 
                new BasketItems()
                { Article = new Article() { IdArticle = Guid.NewGuid() } });
            Assert.IsTrue(res);
        }
    }
}


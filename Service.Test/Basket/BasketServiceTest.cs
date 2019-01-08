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
            //var mock = new Mock<IBasketService>();

            //mock.Setup(p => p.AddItemsToBasket(It.IsAny<>))
            var articleGuid = Guid.NewGuid();
            var basket = new Basket();
            var bi = new BasketItems()
            {
                Article = new Article() { IdArticle = articleGuid }
            };
            basket.BasketItems = new List<BasketItems>();
            basket.BasketItems.Add(bi);

            _basketRepository.Setup(x => x.FindById(1)).Returns(basket);
            var res = _basketService.AddItemsToBasket(1, bi);
            Assert.IsFalse(res);
        }

        [TestMethod]
        public void GivenAddNewItem_WhenNotItemExiting_ThenReturnfalse()
        {
            var articleGuid = Guid.NewGuid();
            var basket = new Basket();
            var bi = new BasketItems()
            {
                Article = new Article() { IdArticle = Guid.NewGuid() }
            };
            basket.BasketItems = new List<BasketItems>();
            basket.BasketItems.Add(bi);

            _basketRepository.Setup(x => x.FindById(1)).Returns(basket);
            var res = _basketService.AddItemsToBasket(1, 
                new BasketItems() { Article = new Article() { IdArticle = Guid.NewGuid() } });
            Assert.IsTrue(res);
        }
    }
}


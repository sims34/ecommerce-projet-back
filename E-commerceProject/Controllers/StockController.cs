using Microsoft.AspNetCore.Mvc;
using Service.Interfaces;
using System;

namespace E_commerceProject.Controllers
{
    [Route("api/[controller]")]
    public class StockController
    {
        private readonly IInventoryService _inventoryService;

       
        public StockController(IInventoryService inventoryService)
        {
            _inventoryService = inventoryService;
        }
        [HttpGet("{id}")]
        public int GetStock(Guid articleId)
        {
            var stock = _inventoryService.Find(articleId);
            return stock.Quantity;
            
        }
    }
}

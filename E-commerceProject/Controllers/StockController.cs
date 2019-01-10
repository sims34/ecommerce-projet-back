using Microsoft.AspNetCore.Mvc;
using System;

namespace E_commerceProject.Controllers
{
    [Route("api/[controller]")]
    public class StockController
    {
        [HttpGet("{id}")]
        public int GetStock(Guid articleId)
        {
            // call service -> inventory + movements 
            // return stock 
            throw new NotImplementedException();
        }
    }
}

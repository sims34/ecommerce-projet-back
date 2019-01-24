using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Service.Interfaces;

namespace E_commerceProject.Controllers
{
    [Produces("application/json")]
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }
        // GET: api/Basket
        [HttpGet]
        public ActionResult<List<Basket>> Get()
        {
            return _basketService.GetAll();
        }

        // GET: api/Basket/5
        [HttpGet("{id}")]
        public ActionResult<Basket> Get(Guid id)
        {
            return _basketService.Find(id);
        }

        // POST: api/Basket
        [HttpPost]
        public IActionResult Post([FromBody] Basket value)
        {
            _basketService.Add(value);
            return Created("", "Basket Created !");
        }

        // PUT: api/Basket/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

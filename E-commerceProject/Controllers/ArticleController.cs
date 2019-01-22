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
    public class ArticleController : ControllerBase
    {
        private readonly IArticleService _articleService;
        //private readonly IInventoryService _inventoryService;

        public ArticleController(IArticleService articleService)
        {
            this._articleService = articleService;
           
        }
        [HttpGet]
        public ActionResult<List<Article>> Get()
        {
            return _articleService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Article> Get(Guid id)
        {
            return _articleService.Find(id);
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Article article)
        {
            _articleService.Add(article);
            return Created("", "Article Created !");

        }
        // PUT api/values/5
        [HttpPut("{id}")]
        public IActionResult Put(Guid id, [FromBody] Article article)
        {
            _articleService.Update(id, article);
            return Ok(article); 
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            _articleService.RemoveById(id);
            return Ok("ok remove ...");
        }

    }
}
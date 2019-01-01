using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Service.Interfaces;

namespace E_commerceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private readonly ICustomerService _customerService;

        public CustomerController (ICustomerService customerService)
        {
            this._customerService = customerService;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
            
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer) 
        {
            //var customer = new Customer
            //{
            //    Id = "40e1c7fb-000d-432a-9ef1-ec8fe6decf0f",
            //    FirstName = "Simon",
            //    LastName = "Bens"
            //};
            this._customerService.Add(customer);
            
            
            return Created("", "Customer Created !");

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

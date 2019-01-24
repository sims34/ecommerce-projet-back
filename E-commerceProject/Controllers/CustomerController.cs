using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Model.Models;
using Service.Interfaces;

namespace E_commerceProject.Controllers
{
    [Produces("application/json")]
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
        public ActionResult<List<Customer>> Get()
        {
            return _customerService.GetAll();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(Guid id)
        {
            return _customerService.Find(id);
            
        }

        // POST api/values
        [HttpPost]
        public IActionResult Post([FromBody] Customer customer) 
        {
            
            this._customerService.Add(customer);
            
            
            return Created("", "Customer Created !");

        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(Guid id, [FromBody] Customer customer)
        {
            _customerService.Update(id, customer);
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(Customer customer)
        {
            _customerService.Remove(customer);
        }
    }
}

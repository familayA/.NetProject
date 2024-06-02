using Microsoft.AspNetCore.Mvc;
using mySolid.Core.Moduls;
using mySolid.Core.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mySolid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICostomerRepository _customerRepository;
        // GET: api/<CustomerController>
        [HttpGet]
        public List<Customer> Get()
        {
            return _customerRepository.GetCustomerList();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public Customer Get(int id)
        {
           return _customerRepository.GetById(id);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult Post([FromBody] Customer customer)
        {
           return  Ok( _customerRepository.PostCustomer(customer));
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put( [FromBody] Customer customer, int id)
        {
           return Ok( _customerRepository.PutCustomer(customer, id));
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           return Ok(_customerRepository.DeleteCustomer(id));
        }
    }
}

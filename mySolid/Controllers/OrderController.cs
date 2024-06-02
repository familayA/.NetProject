using Microsoft.AspNetCore.Mvc;
using mySolid.Core.Moduls;
using mySolid.Core.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mySolid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRepository;
        // GET: api/<OrderController>
        [HttpGet]
        public List<Order> Get()
        {
            return _orderRepository.GetOrderList();
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public Order Get(int id)
        {
            return _orderRepository.GetByIdOrder(id);
        }

        // POST api/<OrderController>
        [HttpPost]
        public ActionResult Post([FromBody] Order order)
        {
           return Ok( _orderRepository.PostOrder(order));
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public ActionResult Put( [FromBody] Order order, int id)
        {
            return Ok(_orderRepository.PutOrder(order, id));
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_orderRepository.DeleteOrder(id));
        }
    }
}

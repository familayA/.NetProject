using Microsoft.AspNetCore.Mvc;
using mySolid.Core.Moduls;
using mySolid.Core.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace mySolid.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductRepository _productRepository;
        // GET: api/<ProductController>
        [HttpGet]
        public List<Product> Get()
        {
            return _productRepository.GetProductList();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _productRepository.GetByIdProduct(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public ActionResult Post([FromBody] Product product)
        {
            return Ok(_productRepository.PostProduct(product));
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public ActionResult Put( [FromBody] Product product, int id)
        {
            return Ok(_productRepository.PutProduct(product, id));
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            return Ok(_productRepository.DeleteProduct(id));
        }
    }
}

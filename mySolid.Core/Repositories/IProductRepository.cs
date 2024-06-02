using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Repositories
{
    public interface IProductRepository
    {
        List<Product> GetProductList();
      
        public Product GetByIdProduct(int id);
        public /*ActionResult*/Product PostProduct(Product product);
        public /*ActionResult*/Product DeleteProduct(int id);
        public /*ActionResult*/Product PutProduct(Product product, int id);
    }
}

using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using mySolid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Data.DataRepositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly DataContext _dataContext;
        public ProductRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Product> GetProductList()
        {
            return _dataContext.ProductsList.Include(u=>u.Customer).ToList();
        }
        public Product GetByIdProduct(int id)
        {
            return _dataContext.ProductsList.First(i => i.Id == id);
        }
        public /*ActionResult*/Product PostProduct(Product product)
        {
            _dataContext.ProductsList.Add(product);
            _dataContext.SaveChanges();

            return product;
        }
        public /*ActionResult*/Product DeleteProduct(int id)
        {
           Product product = _dataContext.ProductsList.First(i => i.Id == id);
            _dataContext.ProductsList.Remove(product);
            _dataContext.SaveChanges();
            return product;
        }
        public /*ActionResult*/Product PutProduct(Product product, int id)
        {
            var existProduct = GetByIdProduct(id);

            existProduct.Name = product.Name;
           

            _dataContext.SaveChanges();
            return existProduct;
        }
    }
}

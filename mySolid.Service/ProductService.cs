using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using mySolid.Core.Repositories;
using mySolid.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Service
{
    public class ProductService: IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Product> GetAllProduct(string?text="")
        {
            return _productRepository.GetProductList().ToList().Where(u => u.Name == text).ToList();
        }
    }
}

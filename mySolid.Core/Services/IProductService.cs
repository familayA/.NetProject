using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Services
{
    public interface IProductService
    {
       List<Product> GetAllProduct(string? text = "");

    }
}

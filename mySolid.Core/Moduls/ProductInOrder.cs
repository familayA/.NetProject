using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Moduls
{
    public class ProductInOrder
    {
        public Product productId { get; set; }
        public Order OrderId { get; set; }
        public int Count { get; set; }
    }
}

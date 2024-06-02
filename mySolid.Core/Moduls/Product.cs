using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Moduls
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int CustomerId { get; set; }
        public List<Order> Orders { get; set; }
        public Customer Customer { get; set; }
    }
}

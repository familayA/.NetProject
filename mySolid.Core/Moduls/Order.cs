using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Moduls
{
    public class Order
    {
        public int Id { get; set; }
        public int CountProduct { get; set; }
        
        public DateTime DateOrder { get; set; }
        public ProductInOrder Product { get; set; }
        public Customer Customer { get; set; }
    }
}

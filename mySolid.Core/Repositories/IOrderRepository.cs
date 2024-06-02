using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace mySolid.Core.Repositories
{
    public interface IOrderRepository
    {
        List<Order> GetOrderList();
        public Order GetByIdOrder(int id);
        public /*ActionResult*/Order PostOrder(Order order);
        public /*ActionResult*/Order DeleteOrder(int id);
        public /*ActionResult*/Order PutOrder(Order order, int id);

    }
}

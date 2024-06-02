using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Services
{
    public interface IOrderService
    {
        List<Order> GetAllOrder();
        Order GetOrderById(int? id);
    }
}

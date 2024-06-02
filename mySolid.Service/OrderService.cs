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
    public class OrderService:IOrderService
    {
        private readonly IOrderRepository _orderRepository;
        public OrderService(IOrderRepository orderRepository)
        {
            _orderRepository = orderRepository;
        }

        public List<Order> GetAllOrder()
        {
          return  _orderRepository.GetOrderList();
        }

        public Order GetOrderById(int? id)
        {
            return _orderRepository.GetOrderList().Find(u => u.Id == id);
        }
    }
}

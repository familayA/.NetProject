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
    public class OrderRepository : IOrderRepository
    {
        private readonly DataContext _dataContext;
        public OrderRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public List<Order> GetOrderList()
        {
            return _dataContext.OrdersList.Include(u=>u.).ToList();
        }
        public Order GetByIdOrder(int id)
        {
            return _dataContext.OrdersList.First(i => i.Id == id);
        }
        public /*ActionResult*/Order PostOrder(Order order)
        {
            _dataContext.OrdersList.Add(order);
            _dataContext.SaveChanges();

            return order;
        }
        public /*ActionResult*/Order DeleteOrder(int id)
        {
            Order order = _dataContext.OrdersList.First(i => i.Id == id);
            _dataContext.OrdersList.Remove(order);
            _dataContext.SaveChanges();
            return order;
        }
        public /*ActionResult*/Order PutOrder(Order order, int id)
        {

            var existOrder= GetByIdOrder(id);

            existOrder.DateOrder = order.DateOrder;
            existOrder.CountProduct = order.CountProduct;
            existOrder.Product= order.Product;
         
         _dataContext.SaveChanges();
            return existOrder;

        }
    }
}

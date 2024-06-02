using Microsoft.AspNetCore.Mvc;
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
    public class CustomerRepository : ICostomerRepository
    {
        private readonly DataContext _dataContext;
        public CustomerRepository(DataContext context)
        {
            _dataContext = context;
        }
        public List<Customer> GetCustomerList()
        {
            return _dataContext.CustomersList.Include(u=>u.Order).ToList();
        }
        public Customer GetById(int id)
        {
            return _dataContext.CustomersList.First(i => i.Id == id);
        }
        public /*ActionResult*/ Customer PostCustomer(Customer customer)
        {

            _dataContext.CustomersList.Add(customer);
            _dataContext.SaveChanges();

            return customer;
        }
        public /*ActionResult*/Customer DeleteCustomer(int id)
        {
            Customer temp = _dataContext.CustomersList.First(i => i.Id == id);
            _dataContext.CustomersList.Remove(temp);
            _dataContext.SaveChanges();
            return temp;
        }
        public /*ActionResult*/ Customer PutCustomer(Customer customeer,int id)
        {
           
                var existCustomer = GetById(id);

            existCustomer.Name = customeer.Name;
                _dataContext.SaveChanges();
                return existCustomer;
            

        }
    }
}

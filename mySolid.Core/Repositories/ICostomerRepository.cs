using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Repositories
{
    public interface ICostomerRepository
    {
        List<Customer> GetCustomerList();
        public Customer GetById(int id);
        public /*ActionResult*/Customer PostCustomer(Customer customer);
        public /*ActionResult*/Customer DeleteCustomer(int id);
        public /*ActionResult*/Customer PutCustomer(Customer customer,int id);
    }
}

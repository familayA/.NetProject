using Microsoft.AspNetCore.Mvc;
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
    public class CustomerService : ICustomerService
    {
        private readonly ICostomerRepository _customerRepository;
        public CustomerService(ICostomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }
        public List<Customer> GetAllCustomer(string? text="")
        {
            return _customerRepository.GetCustomerList().Where(u=>u.Name.Contains(text)).ToList();
        }
        


    }
}

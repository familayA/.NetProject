using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mySolid.Core.Moduls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Services
{
    public interface ICustomerService
    {
        public List<Customer> GetAllCustomer(string? text = "");
       
    }
}

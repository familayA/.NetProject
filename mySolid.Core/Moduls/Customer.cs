﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mySolid.Core.Moduls
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int MyProperty { get; set; }
        List<Order> orders { get; set; }
    }
}

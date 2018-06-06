using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.MockData
{
    public static class MockCustomers
    {
        public static List<Customer> CustomerData = new List<Customer>
        {
            new Customer {Id = 1, Name = "Jason Alexander"},
            new Customer {Id = 2, Name = "George Bennet"},
        };
    }
}
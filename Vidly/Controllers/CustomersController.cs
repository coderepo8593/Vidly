using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.ViewModels;
using Vidly.MockData;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {        
        // GET: Customers
        public ViewResult Index()
        {
            var viewModel = new CustomersViewModel
            {
                Customers = MockCustomers.CustomerData
            };

            return View(viewModel);
        }

        [Route("customers/detail/{id:regex(^\\d{1}$):range(1, 2)}")]
        public ViewResult Detail(int id)
        {
            var customer = MockCustomers.CustomerData[id - 1];

            return View(customer);
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GETForms.Web.DAL;
using GETForms.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace GETForms.Web.Controllers
{
    public class CustomersController : Controller
    {
        private ICustomerDAO dao;

        public CustomersController(ICustomerDAO d)
        {
            dao = d;
        }

        public IActionResult Index()
        {
            return SearchResult("Search", "first_name");
        }

        public IActionResult SearchResult(string search, string sortBy)
        {
            CustomerSearchModel csm = new CustomerSearchModel();
            if(search == null)
            {
                search = " ";
            }
            csm.Customers = dao.SearchForCustomers(search, sortBy);

            return View("Index", csm);
        }

    }
}
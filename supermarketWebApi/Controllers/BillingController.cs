using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BankingSystemWebApi.Controllers
{
    public class BillingController : Controller
    {
        // GET: Billing
        public string Get()
        {
            return "Hello";
        }

        //[HttpGet]
        public string Get(string prodid, string prodname)
        {
            return "dont care";

        }

        public string Get(string parameter)
        {
            return "FuckYou";
        }
    }
}
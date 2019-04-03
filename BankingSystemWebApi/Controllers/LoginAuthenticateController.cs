using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BankingSystemWebApi.Controllers
{
    public class LoginAuthenticateController : ApiController
    {
       
        public string Get()
        {
            return "Hello";
        }

        //[HttpGet]
        public string Get(string username,string password)
        {
            if (username == "akhil" && password == "password")
                return "success";

            return "failure";
        }

        public string Get(string parameter)
        {
            return "FuckYou";
        }
    }
}

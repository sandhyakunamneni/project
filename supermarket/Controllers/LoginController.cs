using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;


namespace BankingSystem.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult LoginPage()
        {
            return View();
        }

        public ActionResult DashBoard()
        {
            return View();
        }
        public ActionResult billing()
        {
            return View();
        }
        public ActionResult add()
        {
            return View();
        }
        public ActionResult remove()
        {
            return View();
        }
        public ActionResult showitemdetails()
        {
            return View();
        }

        public async System.Threading.Tasks.Task<ActionResult> ButtonAction(string userid, string userpass, string button)
        {
            //if (userid.Length == 0 || userpass.Length == 0)
            //    return View("LoginPage");

            //else

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:59037/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.GetAsync("api/LoginAuthenticate?username=" + userid + "&password=" + userpass);
                if (message.IsSuccessStatusCode)
                {
                    string temp = message.Content.ReadAsStringAsync().Result;
                    if (temp.Contains("success"))
                        return View("DashBoard");

                }

                Response.Redirect("https://www.google.com");




                return View();
            }
            //return Content("UserId: " + userid + "\n"+ "password: " + userpass);
        }
        public async System.Threading.Tasks.Task<ActionResult> BillingAsync(string prodid, string prodname)
        {
            //if (userid.Length == 0 || userpass.Length == 0)
            //    return View("LoginPage");

            //else

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:59037/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.GetAsync("api/LoginAuthenticate?username=" + prodid + "&password=" + prodname);
                if (message.IsSuccessStatusCode)
                {
                    string temp = message.Content.ReadAsStringAsync().Result;
                    if (temp.Contains("success"))
                        return View("DashBoard");

                }

                Response.Redirect("https://www.google.com");


            }

            return View();
        }
        //return Content("UserId: " + userid + "\n"+ "password: " + userpass);
        public async System.Threading.Tasks.Task<ActionResult> removeAsync(string prodid, string quantity)
        {
            //if (userid.Length == 0 || userpass.Length == 0)
            //    return View("LoginPage");

            //else

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:59037/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpResponseMessage message = await client.GetAsync("api/LoginAuthenticate?username=" + prodid + "&password=" + quantity);
                if (message.IsSuccessStatusCode)
                {
                    string temp = message.Content.ReadAsStringAsync().Result;
                    if (temp.Contains("success"))
                        return View("DashBoard");

                }

                // Response.Redirect("https://www.google.com");


            }

            return View();
        }




    }
}
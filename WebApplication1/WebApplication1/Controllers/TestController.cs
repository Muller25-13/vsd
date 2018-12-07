using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
       public string GetString()
        {
            return "hhh";
        }

        public Cust getCust()
        {
            Cust ct = new Cust();
            ct.CustomerName = "fzh";
            ct.Add = "gl";
            return ct;
        }
    }
}
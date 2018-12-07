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

        public ActionResult GetView()
        {
            string greeting;
            DateTime dt = DateTime.Now;
            int h = dt.Hour;
            if (h < 11)
            {
                greeting = "早上好";
            }
            else if(h>11&&h<13)
            {
                greeting = "中午好";
            }
            else
            {
                greeting = "下午好";
            }
            ViewData["greeting"] = greeting;

            Employe emp = new Employe();
            emp.Name = "李四";
            emp.Salary = 20002;
           
            ViewData["EmpKey"] = emp;
            return View("MyView");

          
            



        }
    }
}
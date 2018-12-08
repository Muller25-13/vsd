﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class CustController : Controller
    {
        // GET: Cust
        public ActionResult GetView()
        {
            string greeting;
            DateTime dt = DateTime.Now;
            int h = dt.Hour;
            if (h < 11)
            {
                greeting = "早上好";
            }
            else if (h > 11 && h < 13)
            {
                greeting = "中午好";
            }
            else
            {
                greeting = "下午好";
            }
            //ViewData["greeting"] = greeting;
            ViewBag.Greeting = greeting;

            Cust ct = new Cust();
            Employe emp = new Employe();
        
            ViewData["Customer"] = ct;
            ViewData["EmpKey"] = emp;

            emp.Name = "吉吉国王";
            emp.Salary = 1000;
            ct.CustomerName = "本田思域";
            ct.Add = "日本";

            //ViewData["EmpKey"] = emp;
            
            return View("GetView");
           

        }
    }
}
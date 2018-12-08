using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using WebApplication1.ViewModels;

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

            //EmployeeViewModel vmEMP = new EmployeeViewModel();
            //CustomerViewModel vmCUS = new CustomerViewModel();
            All aVM = new All();

            Employe emp = new Employe();
            emp.Name = "李相赫";
            emp.Salary = 20002;

            Cust ct = new Cust();
            ct.CustomerName = "宋义进";
            ct.Add = "韩国";

            aVM.EmployeeNmae = emp.Name;
            aVM.Salary = emp.Salary.ToString("c");

            aVM.CustomerName = ct.CustomerName;
            aVM.CusAdd = ct.Add;

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
            //ViewData["greeting"] = greeting;
            aVM.Greeting = greeting;

           
            if (emp.Salary > 10000)
            {
                aVM.SalaryGrade = "土豪";
            }
            else
            {
                aVM.SalaryGrade = "平民";
            }
            aVM.UserName = "超级管理员";

            //ViewData["EmpKey"] = emp;

            return View("MyView",aVM);

        }

        public ActionResult ViewModel()
        {
            Employe emp = new Employe();
            emp.Name = "李相赫";
            emp.Salary = 20002;

            Cust ct = new Cust();
            ct.CustomerName = "宋义进";
            ct.Add = "韩国";

            AllViewModel aVM = new AllViewModel();
            aVM.EmployeeInfo = emp;
            aVM.CustomerInfo = ct;

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
            aVM.Greeting = greeting;


            if (emp.Salary > 10000)
            {
                aVM.SalaryGrade = "土豪";
            }
            else
            {
                aVM.SalaryGrade = "平民";
            }
            aVM.UserName = "超级管理员";



            return View("ViewModel", aVM);
        }

    }
}
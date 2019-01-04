using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.ViewModels;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class EmployeController : Controller
    {
        // GET: Employe
        public ActionResult Index()
        {
            EmployeListViewModel empListModel = new EmployeListViewModel();

            empListModel.EmployeViewList = getEmpVmList();


            empListModel.Greeting = getGreeting();
          


            empListModel.UserName = getUserName();

            return View(empListModel);
        }

        public ActionResult AddNew()
        {
            return View("CreateEmployee");
        }

        [NonAction]
        List<EmployeeViewModel>getEmpVmList()
        {
            //实例化员工信息业务层
            EmployeeBusinessLayer empBL = new EmployeeBusinessLayer();
            //员工原始数据列表，获取来自业务层类的数据
            var listEmp = empBL.GetEmpLoyeeList();
            //员工原始数据加工后的师徒数据列表，当前状态是空的
            var listEmpVm = new List<EmployeeViewModel>();

            //通过循环遍历员工原始数据数组，将数据一个一个的转换，并加入listEmpVm
            foreach (var item in listEmp)
            {
                EmployeeViewModel empVmObj = new EmployeeViewModel();
                empVmObj.EmployeeNmae = item.Name;
                empVmObj.Salary = item.Salary.ToString("C");
                if (item.Salary > 10000)
                {
                    empVmObj.SalaryGrade = "土豪";
                }
                else
                {
                    empVmObj.SalaryGrade = "平民";
                }
                listEmpVm.Add(empVmObj);
            }
            return listEmpVm;

        }
        
        [NonAction]
        string getGreeting()
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
            return greeting;
            
        }

        [NonAction]
        string getUserName()
        {
            return "Admin";
        }

    }
}
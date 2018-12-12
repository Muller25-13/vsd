using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class EmployeeBusinessLayer
    {
        public List<Employe> GetEmpLoyeeList()
        {
            var list = new List<Employe>();

            Employe emp = new Employe();
            emp.Name = "张三";
            emp.Salary = 15000;
            list.Add(emp);

            emp = new Employe();
            emp.Name = "李四";
            emp.Salary = 30000;
            list.Add(emp);

            emp = new Employe();
            emp.Name = "王五";
            emp.Salary = 8000;
            list.Add(emp);

            return list;
        }
    }
}
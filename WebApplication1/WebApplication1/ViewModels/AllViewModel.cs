using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class AllViewModel
    {
        public Cust CustomerInfo { get; set; }
        public Employe EmployeeInfo { get; set; }

        public string SalaryGrade { get; set; }
        public string UserName { get; set; }
        public string Greeting { get; set; }

    }
}
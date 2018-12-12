using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            Student st = new Student();
            st.Name = "张三";
            st.Age = 20;
            studentList.Add(st);

            st = new Student();
            st.Name = "李四";
            st.Age = 18;
            studentList.Add(st);

            foreach(var item in studentList)
            {
                Console.WriteLine("姓名:{0},年龄:{1}",item.Name,item.Age);
            }

            Console.ReadKey();
        }
    }
}

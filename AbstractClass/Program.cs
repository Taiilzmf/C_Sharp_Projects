using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uses Employee object to create sample student
            Employee employee = new Employee();
            employee.FirstName = "Sample";
            employee.LastName = "Student";
            employee.Quit(employee);
            //calls Satname
            employee.SayName();

          

            Console.ReadLine();
        }
    }
}

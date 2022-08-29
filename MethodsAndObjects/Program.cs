using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            //uses Employees class
            Employees employee = new Employees() { FirstName = "Sample", LastName = "Student"};
            

            //calls super class SayName
            employee.SayName();

            Console.ReadLine();
        }
    }
}

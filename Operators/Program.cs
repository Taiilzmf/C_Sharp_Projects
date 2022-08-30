using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciates
            Employee employee1 = new Employee();
            Employee employee2 = new Employee();

            //gives emplyees 2 different ids
            employee1.Id = "27";
            employee2.Id = "15";

            //prints false
            Console.WriteLine(employee1 == employee2);
            Console.ReadLine();
        }
    }
}

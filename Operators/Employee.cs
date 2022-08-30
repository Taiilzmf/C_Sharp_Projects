using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Id { get; set; }

        //overload operator
        public static bool operator == (Employee employee1, Employee employee2)
        {
            //compares Id to make sure both employees are the same
            return employee1.Id == employee2.Id;
        }
        //creates pair for == with not equal to
        public static bool operator !=(Employee employee1, Employee employee2)
        {
            //compares not equal 2
            return employee1.Id != employee2.Id;
        }
    }
}

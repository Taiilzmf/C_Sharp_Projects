using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    //Employee class created and inherits Person class
    public class Employee: Person
    {
        //instanciates SayName method 
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
        }
    }
}

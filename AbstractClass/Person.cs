using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    public abstract class Person
    {
        //creates an abstract class and adds 2 properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //Creates an abstract method
        public abstract void SayName();
    }
}

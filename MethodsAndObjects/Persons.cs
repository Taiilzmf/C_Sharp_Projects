using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Persons
    {
        //creates 2 properties
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //creates method to show name
        public void SayName()
        {
            Console.WriteLine("Name: " + FirstName + " "+ LastName);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls class
            Numbers number = new Numbers();

            //creates vars 
            int i = 7;
            int j = 22;

            //Passes in 2 numbers to method Add and then calls by name
            Numbers.Add(7, 22);
            Numbers.Add(i:7, j:22);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uses first num method 
            Numbers number = new Numbers();
            int randomNum = number.Num(10);
            Console.WriteLine("10 + 20 = " + randomNum);

            //Uses decimal number overload method
            int ranNum = number.Num(12.1568m);
            Console.WriteLine("12.1568 * 10 = " + ranNum);

            //Uses string for overload method
            int ranDumbNum = number.Num("25");
            Console.WriteLine("25 - 2 = " + ranDumbNum);

            









            Console.ReadLine();

        }
    }
}

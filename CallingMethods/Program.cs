using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            //Asks user to put in a number
            Console.WriteLine("Type your favorite number:");
            int favNum = Convert.ToInt32(Console.ReadLine());

            //creates var
            Numbers number = new Numbers();
            
            //uses addition method to add to users favorite number
            int total = number.Add(favNum);
            Console.WriteLine("20 plus " + favNum + " = " + total);

            //uses division method to add to users favorite number
            total = number.Divide(favNum);
            Console.WriteLine( favNum + " divided by 2 " + " = " + total);

            //uses multiplication method to add to users favorite number
            total = number.Multiply(favNum);
            Console.WriteLine("4 times " + favNum + " = " + total);


            Console.ReadLine();
        }
    }
}

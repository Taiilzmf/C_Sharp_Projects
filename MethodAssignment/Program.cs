using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uses class Numbers to create number object
            Numbers number = new Numbers();

            //asks user for first number
            Console.WriteLine("Input a number:");
            int i = Convert.ToInt32(Console.ReadLine());

            //Asks user if they would like to insert a second number
            Console.WriteLine("If you'd like to put in a second number type your number otherwise hit enter:");
            string answer = Console.ReadLine();

            if (answer != "")
            {
                int j = Convert.ToInt32(answer);
                int k = number.Add(i, j);
                Console.WriteLine(k);
                Console.ReadLine();
            }

            else
            {
                int k = number.Add(i);
                Console.WriteLine(k);
                Console.ReadLine();

            }

            
            


            Console.ReadLine();



            
        }
    }
}

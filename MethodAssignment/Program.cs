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
            int l = Convert.ToInt32(Console.ReadLine());

            //Asks user for second number and creates var m
            int m;
            Console.WriteLine("Input a second number: (Optional)");
            //int m = Convert.ToInt32(Console.ReadLine());

            //creates variable total to output
            int total;
            
            if (int.TryParse(Console.ReadLine(), out m))
                total = number.Add(m);

            Console.WriteLine(number.Add(l, m));
            Console.ReadLine();



            
        }
    }
}

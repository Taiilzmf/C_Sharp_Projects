using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //instanciates datetime
            DateTime today = DateTime.Now;
            //writes current date and time
            Console.WriteLine(today);

            //Gets users numbers for count forward
            Console.WriteLine("Enter a number:");
            int future = Convert.ToInt32(Console.ReadLine());
            DateTime soon = today.AddHours(future);
            Console.WriteLine("It will be: " + soon);

            Console.ReadLine();
        }
    }
}

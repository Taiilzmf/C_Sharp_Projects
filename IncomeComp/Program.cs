using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncomeComp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");

            Console.WriteLine("Person 1");

            // gets hourly rate from p1 and converts to a decimal
            Console.WriteLine("Hourly Rate:");
            string p1Hourly = Console.ReadLine();
            decimal person1Hourly = Convert.ToDecimal(p1Hourly);
            Console.WriteLine("Your hourly is: " + person1Hourly);

            // gets weekly rate from p1 and converts to decimal
            Console.WriteLine("Hours worked per week:");
            string p1Weekly = Console.ReadLine();
            int person1Weekly = Convert.ToInt32(p1Weekly);
            Console.WriteLine("Your weekly is: " + person1Weekly);

            Console.WriteLine("Annual salary of Person 1:");
            //calculates persons 1 weekly times hourly and multiples by 52 weeks
            decimal p1Salary = person1Weekly * person1Hourly * 52;
            Console.WriteLine(p1Salary);



            Console.WriteLine("Person 2");
            // gets hourly rate from p2 and converts to a decimal
            Console.WriteLine("Hourly Rate:");
            string p2Hourly = Console.ReadLine();
            decimal person2Hourly = Convert.ToDecimal(p2Hourly);
            Console.WriteLine("Your hourly is: " + person2Hourly);

            // gets weekly rate from p2 and converts to decimal
            Console.WriteLine("Hours worked per week:");
            string p2Weekly = Console.ReadLine();
            int person2Weekly = Convert.ToInt32(p2Weekly);
            Console.WriteLine("Your weekly is: " + person2Weekly);

            Console.WriteLine("Annual salary of Person 2:");
            //calculates persons 2 weekly times hourly and multiples by 52 weeks
            decimal p2Salary = person2Weekly * person2Hourly * 52;
            Console.WriteLine(p2Salary);

            //compares persons 1 and person 2 salary to give T or F statement on who makes more
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            bool versus = Convert.ToBoolean(p1Salary > p2Salary);
            Console.WriteLine(versus);






            // gives time to read console
            Console.ReadLine();
        }
    }
}

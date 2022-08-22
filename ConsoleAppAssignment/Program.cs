using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] cars = { "Ferrari", "Rolls Royce", "Bugatti", "Lamborghini" };

            Console.WriteLine("Add a car brand to the list:");

            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = Console.ReadLine();

                for (int j = 0; j < cars.Length; j++)
                {
                    Console.WriteLine(cars[j]);
                }
            }





            Console.ReadLine();
        }






        
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. /n Please follow the instructions below.");

            //asks for weight and converts to an int
            Console.WriteLine("What is the package weight?");
            string packageWeight = Console.ReadLine();
            int weightofPackage = Convert.ToInt32(packageWeight);

            // creates var of package not being to big
            int notToBig = 50;

            // if weight of package is bigger then not to big var displays error message
            if (weightofPackage > notToBig)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }
            // otherwise continues program asking for diminsions
            else if (weightofPackage < notToBig)
            {
                Console.WriteLine("What is the package width?");
                string packageWidth = Console.ReadLine();
                decimal widthOfPackage = Convert.ToDecimal(packageWidth);


                Console.WriteLine("What is the package height?");
                string packageHeight = Console.ReadLine();
                decimal heightOfPackage = Convert.ToDecimal(packageHeight);


                Console.WriteLine("What is the package length?");
                string packageLength = Console.ReadLine();
                decimal lengthOfPackage = Convert.ToDecimal(packageLength);

                //creates var for max diminsions
                decimal dimensions = 50;

                //shows error if diminsions are to big
                if (widthOfPackage + heightOfPackage + lengthOfPackage > dimensions)
                {
                    Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                    Console.ReadLine();
                    return;
                }
                // otherwise adds diminsions together and divides by 100 showing quotes
                else if (widthOfPackage + heightOfPackage + lengthOfPackage < dimensions)
                {
                    decimal quote = widthOfPackage * heightOfPackage * lengthOfPackage / 100;
                    Console.WriteLine("Your estimated total for shipping this package is: $" + quote + ". Thank you.");
                }
            }









            Console.ReadLine();
        }
    }
}

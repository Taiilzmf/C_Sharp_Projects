using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trycatch
{
    class Program
    {
        static void Main(string[] args)
        {
            //creates list
            List<int> numbers = new List<int>();
            numbers.Add(32);
            numbers.Add(63);
            numbers.Add(24);
            numbers.Add(55);

            //creates try statement
            try
            {
                //asks user for a number and converts number then states it's dividing
                Console.WriteLine("Please provide a number to divide each number by:");
                int numberOne = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Dividing");
                //creates foreach loop to run each number and divide + prints divided number
                foreach (int number in numbers)
                {
                    int numberTwo = number / numberOne;
                    Console.WriteLine(numberTwo);
                    Console.ReadLine();
                }
            }
            //shows user error message if the user uses incorrect format
            catch (FormatException f1)
            {
                Console.WriteLine(f1.Message);
                return;
            }
            //shows user error message if the user divides by 0
            catch (DivideByZeroException d1)
            {
                Console.WriteLine(d1.Message);
            }
            //shows user error message for general errors
            catch (Exception e1)
            {
                Console.WriteLine(e1.Message);
            }
            //runs no matter what and allows user to read line
            finally
            {
                Console.ReadLine();
            }
        }
    }
}

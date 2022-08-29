using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls class 
            Numbers number = new Numbers();

            //asks for number then creates var
            Console.WriteLine("Enter your favortie number here  to divide it by 2:");
            int favNum = Convert.ToInt32(Console.ReadLine());

            //uses method to divide users fav number by 2 and shows results
            number.Divide(favNum);

            //overload without parameters
            Console.WriteLine("Heres my favorite number divided by 2:");
            int myFavNum = Numbers.Divide();
            Console.WriteLine(myFavNum);

            Console.ReadLine();
        }
    }
}

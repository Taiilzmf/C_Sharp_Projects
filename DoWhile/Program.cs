using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite color:");
            string colorGuessed = Console.ReadLine();
            bool favColor = colorGuessed == "green";


            do
            {
                switch (colorGuessed)
                {
                    case "red":
                        Console.WriteLine("You guessed red. Try again.");
                        Console.WriteLine("Guess my favorite color:");
                        colorGuessed = Console.ReadLine();
                        break;

                    case "blue":
                        Console.WriteLine("You guessed Blue. Try again, sorry.");
                        Console.WriteLine("Guess my favorite color:");
                        colorGuessed = Console.ReadLine();
                        break;

                    case "pink":
                        Console.WriteLine("You guessed Pink. Try again.");
                        Console.WriteLine("Guess my favorite color:");
                        colorGuessed = Console.ReadLine();
                        break;

                    case "green":
                        Console.WriteLine("You guessed green! That's correct!");
                        favColor = true;
                        break;

                    default:
                        Console.WriteLine("Nope. Try again.");
                        Console.WriteLine("Guess my favorite color:");
                        colorGuessed = Console.ReadLine();
                        break;
                }
            }
            while (!favColor);

            Console.Read();
        }
    }
}

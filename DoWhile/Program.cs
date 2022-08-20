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
            //asks to guess favorite color and assigns my favorite color green
            Console.WriteLine("Guess my favorite color:");
            string colorGuessed = Console.ReadLine();
            bool favColor = colorGuessed == "green";


            do //stops infinite loops created by while loop
            {
                switch (colorGuessed) //switch statement that stops repeat branching statements
                {
                    //tells users red, blue and pink are the wrong colors
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

                    //lets user know green is correct color
                    case "green":
                        Console.WriteLine("You guessed green! That's correct!");
                        favColor = true;
                        break;

                    //lets user know any guesses outside of red blue pink and green are wrong
                    default:
                        Console.WriteLine("Nope. Try again.");
                        Console.WriteLine("Guess my favorite color:");
                        colorGuessed = Console.ReadLine();
                        break;
                }
            }
            while (!favColor);

            Console.WriteLine("Guess a number between 1-10:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool guessedNumber = number == 3;

            while(!guessedNumber)
            {
                switch (number)
                {
                    case 1:
                        Console.WriteLine("1 is wrong sorry try again.");
                        Console.WriteLine("Guess a number between 1-10:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("5 is wrong sorry try again.");
                        Console.WriteLine("Guess a number between 1-10:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("3 is correct!");
                        guessedNumber = true;
                        break;
                    default:
                        Console.WriteLine("Nope. Try again.");
                        Console.WriteLine("Guess a number between 1-10:");
                        int number = Convert.ToInt32(Console.ReadLine());
                        break;
                }
            }




            Console.Read();
        }
    }
}

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
            //creates string of cars
            string[] cars = { "Ferrari", "Rolls Royce", "Bugatti", "Lamborghini" };

            Console.WriteLine("Add a car brand to the list:");

            string s = Console.ReadLine();
            //adds user entry to the last part of each line
            for (int i = 0; i < cars.Length; i++)
            {
                cars[i] = cars[i] + s;
                
            }
            //prints cars + user entry 
            for (int j = 0; j < cars.Length; j++)
            {
                Console.WriteLine(cars[j]);
            }
            //asks for users favorite game then creates a while loop that originally was infinite 
            Console.WriteLine("What's your favorite game?");
            string favGame = Console.ReadLine();
           
            //added break; to stop infinte loop
            while(true)
            {
                Console.WriteLine(favGame + " is the greatest game ever!");
                break;
            }

            //iteration through a < and a <= loop 
            int[] rating = { 75, 99, 35, 47, 50, 100, 10, 62, 81 };

            for (int r= 0; r < rating.Length; r++)
            {
                if (rating[r]< 70)
                {
                    Console.WriteLine("Failing juggling scores: " + rating[r]);
                }
                if (80 <= rating[r])
                {
                    Console.WriteLine("Passing juggling scores: " + rating[r]);
                }
            }
            for (int i = 0; i <= 3; i++)
            {
                Console.WriteLine(i);
            }

            //unique string list to search
            List<string> colors = new List<string>();
            colors.Add("pink");
            colors.Add("green");
            colors.Add("red");
            colors.Add("yellow");
            colors.Add("blue");

            Console.WriteLine(" Type a color:");
            string colorPicked = Console.ReadLine();

            for (int i = 0; i < colors.Count; i++)
            {
                if (colorPicked == colors[i] )
                {
                    Console.WriteLine("Yes, " + colorPicked + " is on the list at index " + i);
                    break;
                }
            }

            if (!colors.Contains(colorPicked))
            {
                Console.WriteLine("That color is not on the list.");
            }

            // 2 identical strings and asks the user to select text from in the list
            List<string> names = new List<string>();
            names.Add("Olivia");
            names.Add("Elliot");
            names.Add("Munch");
            names.Add("Fin");
            names.Add("Munch");

            Console.WriteLine("Please search for a law and order svu character name:");
            string namePicked = Console.ReadLine();

            for (int i = 0; i < names.Count; i++)
            {
                if (namePicked == names[i])
                {
                    Console.WriteLine("Yes, " + namePicked + " is on the list at index " + i);
                }
            }

            if (!names.Contains(namePicked))
            {
                Console.WriteLine("That name is not on the list.");
            }

            //prints list and which names are duplicate

            List<string> duplicates = new List<string>();

            foreach (string name in names)
            {
                if (duplicates.Contains(name))
                {
                    Console.WriteLine(name + " is a duplicate name");
                }
                else
                {
                    Console.WriteLine(name + " is a unique name");
                    duplicates.Add(name);
                }
                
            }





            Console.ReadLine();
        }






        
    }
}

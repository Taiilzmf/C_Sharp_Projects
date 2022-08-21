using System;
using System.Collections.Generic;


namespace ArraysAndLists
{
    class Program
    {
        static void Main()
        {
            //creates a string of cars allowing user to select a car at random
            String[] cars = { "Ferrari", "Kia", "Hyundia", "Rolls Royce", "Nissan", "Bugatti", "Lamborghini" };
            Console.WriteLine("Pick a number 0-6:" );
            int index = int.Parse(Console.ReadLine());
            //creates a variable thats used to display error message if user chooses above specified number
            int i = 6;
            //creates inital if else statement so if user chooses to high number it gives an error code
            //otherwise allows user to select next option
            if (index > i)
            {
                Console.WriteLine("That is not an option.");
            }
            else
            {
                Console.WriteLine("You chose a " + cars[index]);

                int[] kids = { 5, 1, 2, 6, 10, 7, 0 };
                Console.WriteLine("Pick a number 0-6:");
                int index1 = int.Parse(Console.ReadLine());
                if (index1 > i)
                {
                    Console.WriteLine("That is not an option.");
                }
                else
                {
                    Console.WriteLine("You chose to have " + kids[index1] + " kids");

                    //creates a string list of places user selects randomly 
                    List<string> placesList = new List<string>();
                    placesList.Add("Las Vegas");
                    placesList.Add("Miami");
                    placesList.Add("Los Angeles");
                    placesList.Add("Denver");
                    placesList.Add("Houston");
                    placesList.Add("New York");
                    placesList.Add("New Orleans");

                    Console.WriteLine("Pick a number 0-6:");
                    int place = int.Parse(Console.ReadLine());
                    if (place > i)
                    {
                        Console.WriteLine("That is not an option.");
                    }
                    else
                    {
                        Console.WriteLine("You chose to live in " + placesList[place] );
                    }

                }
            }
           

            Console.ReadLine();
        }
    }
}

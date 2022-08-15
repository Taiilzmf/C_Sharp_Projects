using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_report
{
    class Program
    {
        static void Main(string[] args)
        {
            //writes the tech academy and asks for name
            Console.WriteLine("The Tech Academy. \n Student Daily Report. ");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            

            Console.WriteLine("What course are you on?");
            string yourCourse = Console.ReadLine();
            Console.WriteLine("Your course is: " + yourCourse);

            // asks for page number and converts to an integer
            Console.WriteLine("What page number are you on?");
            string yourPage = Console.ReadLine();
            int pageNum = Convert.ToInt32(yourPage);
            Console.WriteLine("Your page number is: " + pageNum);

            //asks for true false answer and converts to boolean
            Console.WriteLine("Do you need help with anything? Please answer “true” or “false.”");
            string needHelp = Console.ReadLine();
            bool helpNeeded = Convert.ToBoolean(needHelp);
            Console.WriteLine("Your answer is: " + helpNeeded);

            // asks for positive experiences
            Console.WriteLine("Were there any positive experiences you’d like to share? Please give specifics.");
            string positiveAnswer = Console.ReadLine();
            Console.WriteLine("Your answer is: " + positiveAnswer);


            Console.WriteLine("Is there any other feedback you’d like to provide? Please be specific.");
            string feedbackAnswer = Console.ReadLine();
            Console.WriteLine("Your answer is: " + feedbackAnswer);

            //asks for hours studied and converts to byte
            Console.WriteLine("How many hours did you study today?");
            string studyHours = Console.ReadLine();
            byte hoursStudied = Convert.ToByte(studyHours);
            Console.WriteLine("Your answer is: " + studyHours);

            //ends program
            Console.WriteLine("Thank you for your answers. /n An Instructor will respond to this shortly. Have a great day!");

            // gives time to read console
            Console.ReadLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorSub
{
    class Program
    {
        static void Main(string[] args)
        {
            //sets constant string
            const string multiName = "Taiilzmf";

            //const string sets var using chained constructor
            var multi = new Multiverse(multiName);

            //Write Taiilzmf has 27 wins.
            Console.WriteLine("{0} has {1} wins.", multi.Username, multi.Wins);


            Console.ReadLine();
        }
    }
}

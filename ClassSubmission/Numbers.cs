using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSubmission
{
    public class Numbers
    {
        //creates method for division
        public void Divide(int i)
        {
            int j = i / 2;
            Console.WriteLine(j);
            Console.ReadLine();
        }

        //creates overload as static
        public static int Divide()
        {
            int k = 25 / 5;
            return k;
        }

        int m= 5;



        public static void Add(out int m)
        {
            m = 12;
            int n = m + 2;
            Console.WriteLine("Hey over here!" + n);
            Console.ReadLine();
        }
    }
}

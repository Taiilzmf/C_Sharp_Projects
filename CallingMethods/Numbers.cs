using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Numbers
    {
        //creates public method for addition
        public int Add(int i)
        {
            int total = i + 20;
            return total;
        }

        //creates public method for division
        public int Divide(int j)
        {
            int total = j / 2;
            return total;
        }

        //creates public method for multiplication
        public int Multiply(int k)
        {
            int total = k * 4;
            return total;

        }
    }
}

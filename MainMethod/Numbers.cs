using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    public class Numbers
    {
        //creates addition method
        public int Num(int i)
        {
            int j = i + 20;
            return j;
        }

        //creates decimal method for method overloading
        public int Num(decimal i)
        {
            int j = Convert.ToInt32(i) * 10;
            return j;
        }
        //creates string method for method overloading
        public int Num(string i)
        {
            int j = Convert.ToInt32(i) - 2;
            return j;
        }
    }
}

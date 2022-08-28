using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices; //added to use optional feature c-sharpcorner.com

namespace MethodAssignment
{
    public class Numbers
    {
        //creates method for 2 integers to be added 1 being option (j)
        public int Add(int i, [Optional] int j)
        {
            int k = i + j;
            return k;
        }

    }
}

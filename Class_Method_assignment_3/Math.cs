using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_assignment_3
{
    class Math
    {
        public int MathMethod(int y)
        {
            return 80 / y;
        }

        public double MathMethod(double y)
        {
            return 80 * y;
        }

        public int MathMethod(string y)
        {
            int z = Convert.ToInt32(y);            
            return 80 + z;
        }
    }
}

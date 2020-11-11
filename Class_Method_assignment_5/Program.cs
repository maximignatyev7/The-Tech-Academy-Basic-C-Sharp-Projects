using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Math2 mathObj = new Math2();

            int firstNum = 10;
            int secondNum = 20;

            mathObj.Operation(x: 5, y: 15);

            //mathObj.Operation(firstNum, secondNum);

            Console.ReadLine();
        }
    }
}

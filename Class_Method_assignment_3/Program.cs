using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Math divisionObj = new Math();
            

            Console.WriteLine("80 divided by 2 is " + divisionObj.Division(2));
            Console.WriteLine("80 multiply by 20.25 is " + divisionObj.Multiplication(20.25));



            Console.WriteLine("80 plus 40 is " + divisionObj.Addition(40));

            Console.ReadLine();
        }
    }
}


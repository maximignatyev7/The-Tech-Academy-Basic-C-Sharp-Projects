using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Method_assignment_4
{
    class Program
    {
        static void Main(string[] args)
        {
            MathAgain mathObj = new MathAgain();
            Console.Write("Enter first number: ");
            int firstNum = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter second number:");
            int secondNum = Convert.ToInt32(Console.ReadLine());

            //int sumNumber = mathObj.Addition(firstNum, secondNum);
            //Console.WriteLine(sumNumber);
            Console.WriteLine(mathObj.Addition(firstNum, secondNum));

            Console.Write("Also, It is gonna work without second number!\n");

            Console.WriteLine(mathObj.Addition(firstNum));

            Console.ReadLine();
        }
    }
}

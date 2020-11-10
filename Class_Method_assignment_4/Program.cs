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

            
            Console.Write("Enter second number (optional): ");
            var secondNumAsString = Console.ReadLine();
            if (int.TryParse(secondNumAsString, out int secondNum))
            {
                Console.WriteLine(mathObj.Addition(firstNum, secondNum));
            }
            else
            {
                Console.WriteLine(mathObj.Addition(firstNum));
            }
            

            Console.ReadLine();
        }
    }
}

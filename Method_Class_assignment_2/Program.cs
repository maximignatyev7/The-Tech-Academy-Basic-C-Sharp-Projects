using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Class_assignment_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            MyClass superNum = new MyClass();
            
            Console.Write("Please enter whole number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("100 plus " + userNum + " is " + superNum.Addition(userNum));

            Console.WriteLine("100 minus " + userNum + " is " + superNum.Subtraction(userNum));

            Console.WriteLine("100 multiply by " + userNum + " is " + superNum.Multiplication(userNum));

            Console.ReadLine();
        }
    }
}

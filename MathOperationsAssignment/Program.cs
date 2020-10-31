using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathOperationsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any whole number:");
            string multiplyNumString = Console.ReadLine();
            int multiplyNum = Convert.ToInt32(multiplyNumString);
            int multiplyTotal = multiplyNum * 50;
            Console.WriteLine(multiplyNum + " multiply by 50 = " + multiplyTotal + ".\n");
            Console.ReadLine();

            Console.WriteLine("Please enter any integer:");
            string addNumString = Console.ReadLine();
            int addNum = Convert.ToInt32(addNumString);
            int addTotal = addNum + 25;
            Console.WriteLine(addNum + " plus 25 = " + addTotal + ".\n");
            Console.ReadLine();

            Console.WriteLine("Please enter any number:");
            string divisionNumString = Console.ReadLine();
            double divideNum = Convert.ToDouble(divisionNumString);
            double divideTotal = divideNum / 12.5;
            Console.WriteLine(divideNum + " divide by 12.5 = " + divideTotal + ".\n");
            Console.ReadLine();

            Console.WriteLine("Please enter any number:");
            string greatThanNumString = Console.ReadLine();
            int greatThanNum = Convert.ToInt32(greatThanNumString);
            bool greatThanCompare = greatThanNum > 50;
            Console.WriteLine(greatThanCompare.ToString());
            Console.ReadLine();

            Console.WriteLine("Please enter whole number:");
            string remainderNumString = Console.ReadLine();
            int reminderNum = Convert.ToInt32(remainderNumString);
            int remainterTotal = reminderNum % 7;
            Console.WriteLine("Remainder is " + remainterTotal + " if you divide " + reminderNum + " by 7.\n");
            Console.ReadLine();
        }
    }
}

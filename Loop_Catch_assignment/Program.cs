using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_Catch_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 25, 40, 65, 70 };
            Console.Write("Please enter whole number up to 10: ");
            

            try
            {                
                int userNum = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("We have list of numbers: 10, 25, 40, 65, 70");
                Console.WriteLine("Divide by " + userNum + ", you will get such results:\n");

                foreach (int number in numbers)
                {

                    Console.WriteLine(number / userNum);
                }
            }

            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Please do not divide by zero");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}

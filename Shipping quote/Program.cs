using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shipping_quote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n");
            Console.WriteLine("Please enter the package weight:");
            int packageWeight = Convert.ToInt32(Console.ReadLine());

            if (packageWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Please enter the package width:");
            }

            int packageWidth = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Please enter the package height:");
            int packageHeight = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter the package length:");
            int packageLength = Convert.ToInt32(Console.ReadLine());

            //if (packageWidth > 50 || packageHeight > 50 || packageLength > 50)
            if ((packageWidth + packageHeight + packageLength) > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                decimal quote = packageWidth * packageHeight * packageLength * packageWeight / 100m;
                Console.WriteLine("Your estimated total for shipping this package is: $" + quote + "\nThank you!");
            }
            
            Console.ReadLine();
        }
    }
}

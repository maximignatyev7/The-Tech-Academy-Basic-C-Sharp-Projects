using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_and_Lists_assignment
{
    class Program
    {
        static void Main()
        {
            string[] bookArray = new string[3];
            bookArray[0] = "American tragedy";
            bookArray[1] = "The Arch of Triumph";
            bookArray[2] = "Financist";

            Console.WriteLine("Please, choose one number from this row: 0, 1, 2.");
            int userNum = Convert.ToInt32(Console.ReadLine());

            if (userNum == 0 || userNum == 1 || userNum == 2)
            {
                Console.WriteLine(bookArray[userNum]);
            }
            else
            {
                Console.WriteLine("Ops... something wrong! Number should be: 0, 1, or 2");
            }

            
            int[] numArray = { 7, 9, 21, 47, 6, 88, 108 };
            Console.WriteLine("\nPlease, choose one number from 0 up to 6:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            
            if (userNumber == 0 || userNumber == 1 || userNumber == 2 || userNumber == 3 || userNumber == 4 || userNumber == 5 || userNumber == 6)
            {
                Console.WriteLine(numArray[userNumber]);
            }
            else
            {
                Console.WriteLine("Ops... something wrong! Number should be from 0 up to 6.");
            }


            List<string> phoneList = new List<string>();
            phoneList.Add("Apple");
            phoneList.Add("Samsung");
            phoneList.Add("Nokia");
            phoneList.Add("LG");
            
            Console.WriteLine("\nPlease, choose one number from 0 up to 3:");
            int userNumberPhoneList = Convert.ToInt32(Console.ReadLine());

            if (userNumberPhoneList == 0 || userNumberPhoneList == 1 || userNumberPhoneList == 2 || userNumberPhoneList == 3)
            {
                Console.WriteLine(phoneList[userNumberPhoneList]);
            }
            else
            {
                Console.WriteLine("Ops... something wrong! Number should be from 0 up to 3.");
            }

            Console.ReadLine();
        }
    }
}

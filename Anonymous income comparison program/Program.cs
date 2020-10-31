using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anonymous_income_comparison_program
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");
            string person1 = "Person 1";
            Console.WriteLine(person1);
            Console.WriteLine("Hourly rate?");
            int hourRate1 = Convert.ToInt32(Console.ReadLine());
            //int addNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek1 = Convert.ToInt32(Console.ReadLine());
            int salaryPerWeek1 = hourRate1 * hoursPerWeek1;

            string person2 = "Person 2";
            Console.WriteLine(person2);
            Console.WriteLine("Hourly rate?");
            int hourRate2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hours worked per week?");
            int hoursPerWeek2 = Convert.ToInt32(Console.ReadLine());
            int salaryPerWeek2 = hourRate2 * hoursPerWeek2;

            int weeksPerYear = 48;

            int annualSalaryPerson1 = salaryPerWeek1 * weeksPerYear;
            Console.WriteLine("\nAnnual salary of Person 1:\n" + annualSalaryPerson1);

            int annualSalaryPerson2 = salaryPerWeek2 * weeksPerYear;
            Console.WriteLine("\nAnnual salary of Person 2:\n" + annualSalaryPerson2);


            bool compareP1AndP2 = annualSalaryPerson1 > annualSalaryPerson2;
            Console.WriteLine("Does Person 1 make more money than Person 2?\n" + compareP1AndP2);

            Console.ReadLine();
        }
    }
}

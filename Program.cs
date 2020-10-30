using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daily_Report
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("The Tech Academy\nSudent Daily Report\n\n");
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Welcome to the Daily Report Page, " + yourName + "!\n");
            
            Console.WriteLine("What course are you on?");
            string courseName = Console.ReadLine();
            Console.WriteLine("Your course is " + courseName + ". Whoa!!! That is cool!\n");
            
            Console.WriteLine("What page number?");
            string pageNumberString = Console.ReadLine();
            int pageNum = Convert.ToInt32(pageNumberString);            
            Console.WriteLine(pageNum + "...mmm...I got it!\n");

            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            //string needHelpString = Console.ReadLine();
            bool needHelpString = bool.Parse(Console.ReadLine());
            Console.WriteLine(needHelpString + " Ok...Just let you know...We are always here to help you!\n");

            //bool dntneedHelpString = bool.Parse(Console.ReadLine());
            //Console.WriteLine(dntneedHelpString + " Ok...Just let you know...We are always here to help you!\n");


            //bool needHelp = bool.Parse(needHelpString);
            ////string needHelpbool = bool.TrueString;

            //Console.WriteLine(needHelp + " Ok...How can We help you?");           

            ////if (needHelp)
            ////{
            ////    Console.WriteLine(needHelpString + " Ok...How can We help you?");
            ////}

            //bool dntneedHelp = bool.Parse(needHelpString);
            ////string dntneedHelpString = bool.FalseString;

            //Console.WriteLine(dntneedHelp + " Ok...Just let you know...We are always here to help you!\n");

            ////if (dntneedHelp)
            ////{
            ////    Console.WriteLine(needHelpString + " Ok...Just let you know...We are always here to help you!");
            ////}
            Console.WriteLine("Were there any positive experience you would like to share? Please give specifics");
            string posExp = Console.ReadLine();
            Console.WriteLine(posExp + " ...Thank you for your sharing\n");

            Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
            string feedback = Console.ReadLine();
            Console.WriteLine(feedback + " We will consider your feedback. Thank you!\n");

            Console.WriteLine("How many ours did you study today?");
            string studyHourString = Console.ReadLine();
            byte studyHour = Convert.ToByte(studyHourString);
            Console.WriteLine(studyHour + " You always need to keep couting of study hours. It helps to improve your discipline!\n");

            Console.WriteLine("Thank you for your answers, " + yourName + "! An Instructor will respond to this shortly.\nHave a great day!");

            Console.ReadLine();          
        }
    }
}

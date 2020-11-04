using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sally";
            name = name.ToUpper();
            Console.WriteLine("Hello, " + name + "!\nHere we are trying coding in C#!\n");

            StringBuilder sb = new StringBuilder(60);
            sb.Append("Hello ");
            sb.AppendLine("World!");
            sb.AppendLine("Hello C#!");
            sb.AppendLine("The name C# was inspired by the musical notation.");
            Console.WriteLine(sb);


            Console.ReadLine();
        }
    }
}

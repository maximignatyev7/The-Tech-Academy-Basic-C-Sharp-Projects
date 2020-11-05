using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iteration_assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] fillings = { "I like ", "I am selling ", "I have ", "I will buy ", "I prefer " };
            //Console.WriteLine("Please type name of your favorite car:");
            //string carName = Console.ReadLine();
            //for (int i = 0; i < fillings.Length; i++)
            //{
            //    Console.WriteLine(fillings[i] + carName);
            //}

            //for (int i = 0; i < fillings.Length; i++)
            //{
            //    Console.WriteLine(fillings[i]);
            //}

            //for (int i = 0; i < fillings.Length;)
            //{
            //    Console.WriteLine(fillings[i]);
            //}

            //for (int i = 0; i < fillings.Length; i++)
            //{
            //    Console.WriteLine(fillings[i]);
            //}

            //string carName = Console.ReadLine();
            //for (int i = 2; i <= fillings.Length - 2; i++)
            //{
            //    Console.WriteLine(fillings[i] + carName);
            //}




            //List<string> planets = new List<string>() { "Mercury", "Vinus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune"};
            //Console.WriteLine("Please name the smallest planet of our solar system:");
            //string userPlanet = Console.ReadLine();            


            //if (userPlanet == "Mercury")
            //{
            //    foreach (string planet in planets)
            //    {
            //        //Console.WriteLine(planet);
            //        if (planet == "Mercury")
            //        {
            //            Console.WriteLine(planets.IndexOf("Mercury"));
            //        }

            //    }
            //}
            //else if (userPlanet != "Mercury")
            //{
            //    Console.WriteLine("It is not the smallest planet in our solar system!");
            //}


            //List<string> names = new List<string>() { "Bob", "Mike", "John", "Bob", "Joe"};
            //List<string> countName = new List<string>();
            //Console.WriteLine("Please type name Bob below:");
            //string userName = Console.ReadLine();

            //if (userName == "Bob")
            //{
            //    foreach (string name in names)
            //    {
            //        if (name == "Bob")
            //        {
            //            countName.Add(name);                        
            //        }
            //    }
            //    Console.WriteLine(countName.Count);
            //}
            
            //else if (userName != "Bob")
            //{
            //    Console.WriteLine("Sorry, You did not type correct name!");
            //}


            List<string> names = new List<string>() { "Bob", "Mike", "John", "Bob", "Joe" };
            List<string> repeatCheck = new List<string>();

            foreach (string name in names)
            {
                //Console.WriteLine(name);
                //if (repeatCheck.Contains(name)) 
                if (name.Contains("Bob"))
                {
                    repeatCheck.Add(name);
                }
            }

            Console.WriteLine(repeatCheck);

            Console.ReadLine();
        }
    }
}

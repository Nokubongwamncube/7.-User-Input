using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.User_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            Console.WriteLine("Hi " + name);

            string age = Console.ReadLine();
            Console.WriteLine(" You are " + age + "years old");




        }
    }
}

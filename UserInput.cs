using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpBasics
{
    class UserInput
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine(); 
            Console.WriteLine("Hello " + name +"!");

            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine()); //type conversion since ReadLine reads String
            Console.WriteLine("Age " + age);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//By Matt Braden
namespace cSharpProject
{
    class HelloWorldDemo
    {
        //needs to be public to use it in the main class, the satic is to use it in a public static void main(String[] args) function, and the void is to not require an input.
        public static void DemoTester()
        {
            Console.WriteLine("Hello world!");
            //without anything stopping it, the console will instantly dissapear. To combat this, I'm going to use a simple "press any key to continue" setup
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine("\nWhat is your name?");
            //ReadLine() simply reads a line and outputs it, just like Scanner
            String name = Console.ReadLine();
            //If you put a '$' in front of a string, you can access variables by surrounding them with braces
            Console.WriteLine($"\nHello, {name}.");
            //code to stop when desired
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            //This part shows how to deal with integer inputs
            Console.WriteLine("\nEnter a number:");
            //Convert.ToInt32 will convert objects to 32 bit signed integers
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter another number:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            //apparently, you need the parentheses around integers to do the math, or else it will just combine them as strings
            Console.WriteLine($"{num1} + {num2} = "+(num1+num2));
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
            Console.WriteLine();
            //This is what a for loop looks like
            for(int i = 0; i < 10; i++)
            {
                Console.Write(i+" ");
            }
            Console.WriteLine();
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey(true);
        }
    }
}

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
        static void Main(string[] args)
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
            Console.WriteLine("Press any key to stop...");
            Console.ReadKey(true);
        }
    }
}

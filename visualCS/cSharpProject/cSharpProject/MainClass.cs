using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpProject
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            Boolean keepRunning = true;
            while (keepRunning)
            {
                Console.WriteLine("Press 1 to run \"HelloWorldDemo\"\nPress 0 to exit");
                String keyPressed = Console.ReadLine();
                if(keyPressed == "1")
                {
                    HelloWorldDemo.DemoTester();
                    keepRunning = false;
                }else if(keyPressed == "0")
                {
                    keepRunning = false;
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//By Matt Braden
namespace cSharpProject
{
    class MainClass
    {
        public static void Main(String[] args)
        {
            Boolean keepRunning = true;
            //This while loop will allow any incorect input to be ignored
            while (keepRunning)
            {
                Console.WriteLine("Press 1 to run \"HelloWorldDemo\"\nPress 0 to exit");
                //keyPressed will read whatever you type
                String keyPressed = Console.ReadLine();
                if(keyPressed == "1")
                {
                    //runs the HelloWorldDemo class
                    HelloWorldDemo.DemoTester();
                    keepRunning = false;
                }else if(keyPressed == "0")
                {
                    //just stops the console
                    keepRunning = false;
                }
            }
        }
    }
}

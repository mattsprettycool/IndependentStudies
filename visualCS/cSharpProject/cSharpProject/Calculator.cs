using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharpProject
{
    class Calculator
    {
        public static void Calc(String [] args)
        {
            Boolean run = true;
            while (run)
            {
                Console.WriteLine("Press 1 to calculate\nPress 2 to exit the program.");
                String input = Console.ReadLine();
                if(input == "1") { CalcOp(); }
                else { run = false; }
            }
        }
        public static double CalcOp()
        {
            double res = 0;
            Console.WriteLine("Enter any number: ");
            double n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Pick an operator:\n+, -, *, / ");
            String op = Console.ReadLine();
            Console.WriteLine("Enter another number: ");
            double n2 = Convert.ToInt32(Console.ReadLine());
            if (op.Equals("+")) { res = n1 + n2; }
            else if (op.Equals("-")) { res = n1 - n2; }
            else if (op.Equals("*")) { res = n1 * n2; }
            else { res = n1 / n2; }
            return res;
        }
    }
}

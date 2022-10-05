using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorProj
{
    internal class Calculator
    {
        

        public static double Add()
        {
            Console.WriteLine("Please enter a first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 + num2;
        }

        public static double Subtract()
        {
            Console.WriteLine("Please enter a first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 - num2;
        }
        public static double Divide()
        {
            Console.WriteLine("Please enter a first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 / num2;
        }
        public static double Multiply()
        {
            Console.WriteLine("Please enter a first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 * num2;
        }
        public static double Percentage()
        {
            Console.WriteLine("Please enter a first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter a second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            return num1 / num2 * 100;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWK10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first number: ");
            double number1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double number2 = double.Parse(Console.ReadLine());
            Console.Write("Enter third: ");
            double number3 = double.Parse(Console.ReadLine());

            double result = Maximum(number1, number2, number3);

            Console.WriteLine("Maximum is: " + result);
        }
        static double Maximum(double x, double y, double z)
        {
            double maximumValue = x;

            if (y > maximumValue)
            {
                maximumValue = y;
            }
            if (z > maximumValue)
            {
                maximumValue = z;
            }

            return maximumValue;



        }
    }
}

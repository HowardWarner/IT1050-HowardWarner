using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWeek10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter first number: ");
            double operand1 = double.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            double operand2 = double.Parse(Console.ReadLine());
           

            double result = Maximum(operand1, operand2);

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

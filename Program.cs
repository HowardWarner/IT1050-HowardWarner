using System;

namespace InclassLabW6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            int speedLimit;
            int speed;
            speedLimit = 35;
            speed = 32;
            if (speed > speedLimit)
            {
                Console.WriteLine("SLOW DOWN");
            }
            */
            /*int i;
            i = 30;
            while (i >= 10)
            
            {
                Console.WriteLine(i);
                i = i - 2;
            }*/
            int numValue;
            int exponentValue;
            int resultValue;
            int i;
            Console.WriteLine("enter the number value:");
            numValue = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the number value:");
            exponentValue = int.Parse(Console.ReadLine());


            i = 1;
            resultValue = numValue;
            while (i < exponentValue)
            {
                resultValue = resultValue * numValue;
                i = i + 1;
            }
            {
                Console.WriteLine("The result is = {0}", resultValue);
            }


        }
    }
}

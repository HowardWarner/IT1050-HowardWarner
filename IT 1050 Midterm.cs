using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT1050_Midterm
{
    class Program
    {
        static void Main(string[] args)
        /*{
            int i = 12;
            Boolean keepLooping = true;
            while (keepLooping)

            {
                if (i <= 11)
                    keepLooping = false;
                i++;
                Console.WriteLine(i);
            }*/
        /* {
             int loop = 2;
             while (loop <=128)
             {
                 Console.WriteLine("[" + loop + "]");
                 loop = loop + 2;
             }
         }*/
       /* {
            int i = 1;
            while (i <= 21)
            {
                if ((i % 2) == 0)
                {
                    Console.WriteLine(" ");
                }

                else if ((i % 2) != 0)
                {
                    Console.WriteLine(i);
                }
                i++;
            }*/
        
        /*{
            for (int i = 49; i > 0; i--)
            {
                Console.WriteLine(i +  ",");
                if (i !=1)
                
            }
        }*/
        /* {
             int n = 8;
             int i = 10; // initialize
             do
             {
                 Console.Write("*");
                 i++; // update!
             } while (i < n); // test condition
 // A do loop outputs a single "*" and a While loop outputs none.
         }*/
        /* {
             bool icyRain = false, tornadowarning = false;
             if (icyRain == false && tornadowarning == false)
             {
                 Console.WriteLine("Lets go outside");
             }
         }*/
        {
            int numberoflayer = 5, Space, Number;
            Console.WriteLine("Print paramid");
            for (int i = 1; i <= numberoflayer; i++)  
            {
                for (Space = 1; Space <= (numberoflayer - i); Space++)   
                    Console.Write(" ");
                for (Number = 1; Number <= i; Number++)   
                    Console.Write(Number);
                for (Number = (i - 1); Number >= 1; Number--)   
                    Console.Write(Number);
                Console.WriteLine();
            }
        }
            
        
    }
}

using System;

namespace LabWK11
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] students = { "Al Dente", "Anna Graham", "Earle Bird", "Ginger Rayle", "Iona Ford" };
            Console.WriteLine(students[1]);
            Console.WriteLine(students[4]);
            // Console.WriteLine(students[students.Length - 1]);

            string[] months = new string[12];
            months[0] = "January";
            months[1] = "February";
            months[2] = "March";
            months[3] = "April";
            months[4] = "May";
            months[5] = "June";
            months[6] = "July";
            months[7] = "August";
            months[8] = "September";
            months[9] = "October";
            months[10] = "November";
            months[11] = "December";
            for (int i = 0; i < 12; i++)
            {
                Console.WriteLine((i + 1) + " " + months[i]);
            }

            string[] Seasons = { "Spring", "Summer", "Fall", "Winter" };
            foreach (string Season in Seasons)
            {
                Console.WriteLine(Season);
            }
            int[] randomNumber = new int[1000];
            Random random = new Random();
            for (int i = 0; i < randomNumber.Length; i++)
            {
                randomNumber[i] = random.Next(0, 1000);
            }
            foreach (int i in randomNumber)
            {
                Console.WriteLine(i.ToString());
            }



        }
    }
}

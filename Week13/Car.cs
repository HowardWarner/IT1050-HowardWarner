using System;
using System.Collections.Generic;
using System.Text;

namespace Week13
{
    class Car
    {
        private string Make;
        private string Model;
        private int Year;
        private int Speed;


        public Car(string pMake, string pModel)
        {
            this.Make = pMake;
            this.Model = pModel;
        }
        public Car(string pMake, string pModel, int pYear, int pSpeed)
        {
            this.Make = pMake;
            this.Model = pModel;
            this.Year = pYear;
            this.Speed = pSpeed;
        }
        public Car(string pMake, string pModel, int pYear)
        {
            this.Make = pMake;
            this.Year = pYear;
        }
        public void Display()
        {
            Console.WriteLine(Year + " " + Make + " " + Model + " is going " + Speed + " MPH.");
        }

        public int SpeedUp()
        {
            this.Speed++;
            return this.Speed;
        }
        public int SlowDown()
        {
            if (Speed >= 0)
            {
                Speed--;
            }
            return this.Speed;
        }
    }

}
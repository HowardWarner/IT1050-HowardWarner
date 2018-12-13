using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProject
{
    class Hero
    {
        private string Alterego;
        private string Weakness;
        private bool Antihero;
        private string Gender;
        private string Race;

        public string Power;
        public int PowerLevel;
        public double Health;
        public string Weapons;
        public int Age;
        public string Name;
        public string nemesis;

        public Hero()
        {
        }
        public void setName(string pName)
        {
            this.Name = pName;
        }

        public string getName()
        {
            return this.Name;
        }

        public Hero(string name, string nemesis, string race, string power)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
        }

        public Hero(string name, string nemesis, string race, string power, bool antihero)
        {
            this.Name = name;
            this.nemesis = nemesis;
            this.Race = race;
            this.Power = power;
            this.Antihero = antihero;
        }
        //#1
        public Hero(string name, string power, string Weapons, int PowerLevel, int Health)
        {
            this.Name = name;
            this.Power = power;
            this.Weapons = Weapons;
            this.PowerLevel = PowerLevel;
            this.Health = Health;
        }
        // TODO: Problem 1 - add a constructor method with a different number and/or types of parameters
        public Hero(string name,int PowerLevel)
        {
            this.Name = name;
            this.PowerLevel = PowerLevel;
            
        }
        public void FightCrime(string address)
        {
            // TODO: Problem 2 - Output "Successfully fought crime at address" if PowerLevel > 49
            if (this.PowerLevel > 49) 
            {
                Console.WriteLine("Successfully fought crime at address");
            }

        }

        public bool Investigate()
        {
            // TODO: Problem 3 - output "Investigated Crime" and return true
            bool returnValue = true;
            Console.WriteLine("Investigated Crime");
            return returnValue;           

        }
        public void Fly()
        {
            // TODO: Problem 4 - if Power contains Fly, then output "Name is Flying!" else output "Name can't fly!"
            if (this.Power.Contains("Fly"))
            {
                Console.WriteLine("Batman is Flying!");               

            }
            else
            {
                Console.WriteLine("Batman can't Fly");
            }
        }

        public void Craft(string material, int numMaterials)
        {
            Console.WriteLine("Crafting with " + material);
        }

        public void Climb(int height)
        {
            Console.WriteLine(this.Name + " is climbing");
        }

        public int ChargePower()
        {
            // TODO: Problem 5 - increase this.PowerLevel by 1
            PowerLevel++;
            return PowerLevel;
            
        }

        // TODO: Problem 6 - Add an overloaded method ChargePower that has a parameter for increaseAmount.  Add increaseAmount to this.PowerLevel and return the new value for this.PowerLevel (try to use a loop calling the other ChargePower)
        public int ChargePower(int increaseAmount)
        { 
            return PowerLevel;
          
        }
    }
}

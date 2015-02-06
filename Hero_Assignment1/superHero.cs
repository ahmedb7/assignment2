/*
 * Student Name: Benzir Ahmed
 * Student ID: 300727117
 * Assignment 2: SuperHero Class
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Assignment1
{
    //sub class of hero class
    class superHero : Hero
    {        
        //Private properties
        private string[] superPowers;
        //Public properties
        string superPower1, superPower2, superPower3;
        public string name1;
        public superHero(string name1)
        {
            this.name1 = name1;
            this.showPowers();
        }

        //Constructor
        public superHero(string name1,int strength,int speed,int health) : 
            base(name1 , strength , speed , health)
        {
            this.generateRandomPowers();
        }


        // Private methods Generates random superpowers
        private void generateRandomPowers()
        {
            //Array Initilization
            string[] superPowers = { "Super Speed", "Super Strength", "Body Armour", "Flight", 
                                     "Fire Generation", "Weather Control"};
            
            string[] randomPowers = new string[3];
            
            Random rnd = new Random();
            int rndPower;

            //Assign cells from an array to another 
            int index = 0;
            while (index < 3)
            {
                rndPower = generateRandomPower(rnd);
                if (superPowers[rndPower] != "unbelievable")
                {
                    randomPowers[index] = superPowers[rndPower];
                    superPowers[rndPower] = "unbelievable";
                    index++;
                }
            }

           
            superPower1 = randomPowers[0];
            superPower2 = randomPowers[1];
            superPower3 = randomPowers[2];
        }

        //Generate random number for super power.
        private static int generateRandomPower(Random rnd)
        {
            int randomPower;
            randomPower = rnd.Next(6);
            Console.WriteLine("Random super power number is {0}", randomPower);// Debugging line
            return randomPower;
        }
        

        //PUBLIC METHODS,output random super power.
        public void showPowers()
        {
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("The hero's super powers are:");
            Console.WriteLine("1) {0}", superPower1);
            Console.WriteLine("2) {0}", superPower2);
            Console.WriteLine("3) {0}", superPower3);
            Console.WriteLine("++++++++++++++++++++++++++++++++++++++");
        }
        
    }
}

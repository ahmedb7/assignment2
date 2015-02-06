/*
 * Student Name: Benzir Ahmed
 * Student ID: 300727117
 * Assignment 1: Hero Class
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Assignment1
{
    class Hero
    {

        //Random number generator 
        Random ran = new Random();

        //Private Properties
        private int strength;
        private int speed;
        private int health;

        //Public Properties
        public string name;

        //Assigning hero name
        public Hero(string name)
        {
            this.name = name;
            this.generateAbilities();
        }

        //Method to assign values to the abilities of Hero
        private void generateAbilities()
        {
            //Random number generator for Hero's abilities
            this.strength = ran.Next(1, 100) + 1;
            this.speed = ran.Next(1, 100) + 1;
            this.health = ran.Next(1, 100) + 1;
        }

        //Method to display the damage 
        public void fight()
        {
            //Damage caused to target
            int damage;
            //Method call, to check hit or miss
            if (hitAttempt())
            {
                damage = hitDamage(); //Method call hitDamage 
                Console.WriteLine("Congratulations!!! \n You  have successfully Hit the target!");
                Console.WriteLine("Damage caused to the target: {0}", damage);
            }
            else
            {
                Console.WriteLine("Miss!!! \nYour attack was unsuccessful!");
                Console.WriteLine("No damage caused to the target");
            }
        }

        //Method to return hit the target
        private bool hitAttempt()
        {
            int hitTime = ran.Next(1, 100) + 1;
            //Checking if hitTime is less than or equal to 20 (less than 20: success, grater than 20: miss)
            if (hitTime <= 20)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Method to calculate damage caused to the target
        private int hitDamage()
        {
            int damage = this.strength * ran.Next(1, 6) + 1;
            return damage;
        }

        //Method to assign the strength of hero 
        public void heroStrength()
        {
            if (this.strength < 40)
            {
                Console.WriteLine("Your hero is waek!!");
            }
            else if (this.strength < 60)
            {
                Console.WriteLine("Your hero is strong!!");
            }
            else
            {
                Console.WriteLine("Your hero's strength is legendary!!");
            }
        }

        //Method to assign the speed of hero 
        public void heroSpeed()
        {
            if (this.speed < 40)
            {
                Console.WriteLine("Your hero is so slow!!");
            }
            else if (this.speed < 60)
            {
                Console.WriteLine("Your hero is fast!!");
            }
            else
            {
                Console.WriteLine("Your hero is fast as light!!!");
            }
        }

        //Method to determine health of hero
        public void heroHealth()
        {
            if (this.health < 40)
            {
                Console.WriteLine("Your hero isn't healthy!");
            }
            else if (this.health < 60)
            {
                Console.WriteLine("Hero is healthy!");
            }
            else
            {
                Console.WriteLine("Hero is very healthy!!!");
            }

        }

        //Method to display
        public void show()
        {

            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("{0} the hero of legengds!!\n", this.name);
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++\n");
            Console.WriteLine("{0} has following abilities:\n", this.name);
            Console.Write("  Strength: {0} ", this.strength);
            heroStrength();
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++\n");
            Console.Write("  Speed: {0} ", this.speed);
            heroSpeed();
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++\n");
            Console.Write("  Health: {0} ", this.health);
            heroHealth();
            Console.WriteLine("\n++++++++++++++++++++++++++++++++++++++\n");
        }
    }
}

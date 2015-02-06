using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero_Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            //github please work
            Console.Write("Enter a name for your hero: ");
            String name = Console.ReadLine(); 

            //Instantiating an object for Hero class
            Hero myHero = new Hero(name);

            //Calling show() and fight() methods 
            myHero.show();
            myHero.fight();
            //Calling showPowers()
            Console.WriteLine("+++++++++++++++++++++++++++++");
            superHero mySuperHero = new superHero("lalluin");
            mySuperHero.showPowers();
            mySuperHero.fight();

            Console.WriteLine("\nPress any key to exit");
            Console.ReadKey();
        
        }
    }
}

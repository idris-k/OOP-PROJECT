using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace swarmgame2
{
    class Player
    {
        int health = 100;
        int name;
        string role;
        string Fighter;
        string Tank;
        string Support;

        static void Main(string[] args)
        {
            //select role
            Console.WriteLine("Enter your name : ");
            string name = Console.ReadLine();

            Console.WriteLine("Choose your role (Fighter, Tank, Support) : ");
            string role = Console.ReadLine();

            if (role == "Fighter" || role == "fighter") 
            {
                Console.WriteLine("Your name is " + name);
                Console.WriteLine("You are a FIGHTER!!!");
                Console.WriteLine(" HP = 100 DMG = 100 MANA = 0");
            }
            else if (role == "Tank" || role == "tank")
            {
                Console.WriteLine("Your name is " + name);
                Console.WriteLine("You are a TANK!!!");
                Console.WriteLine("HP = 200 DMG = 70 MANA = 0");
            }
            else if (role == "Support" || role == "support")
            {
                Console.WriteLine("Your name is " + name);
                Console.WriteLine("You are a SUPPORT!!!");
                Console.WriteLine("HP = 70 DMG = 50 MANA = 100");
            }
            else
            {
                Console.WriteLine("Invalid role!");



            }
        }
    }
}

    
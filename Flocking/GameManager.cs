using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace swarmgame2

{
    public class GameManager
    {
        public static void StartGame()
        {

            Console.WriteLine("WELCOME TO MONSTER RUSH");
            Console.WriteLine("Press Enter to continue or press Q to quit...");

            while (true)
            {
                var key = Console.ReadKey(true); // Read key without displaying the pressed key
                if (key.Key == ConsoleKey.Enter)
                {
                    Console.WriteLine("Continuing...");
                    // Add the logic that should happen when Enter is pressed.
                }
                else if (key.Key == ConsoleKey.Q)
                {
                    Console.WriteLine("Exiting program...");
                    break; // Exit the while loop, ending the program.
                }
                else
                {
                    Console.WriteLine("Invalid input. Please press Enter to continue or Q to quit.");
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    namespace final
    {


        internal class Gamemenu
        {


            int health = 100;
            int maxhealth = 100;
            int consoleWidth = Console.WindowWidth;
            public static string CenterText(string text, int consoleWidth)
            {
                if (text.Length >= consoleWidth)
                    return text; // If the text is too long, just return it without centering.

                int spaces = (consoleWidth - text.Length) / 2;
                return new string(' ', spaces) + text;
            }









            public void sentence1()
            {

                Console.WriteLine(" The year is 2135. Decades after a global nuclear war, Earth is a wasteland filled with radiation zones, crumbling cities, and mutated creatures. Humanity is scattered, surviving in underground bunkers or small surface communities, clinging to remnants of a once-thriving world.\r\n\r\nYou play as Kai, a scavenger searching for a mythical device known as \"The Genesis Core\", said to have the power to restore Earth's ecosystem. It’s hidden somewhere in the ruins of The Spire, an advanced research facility located in the heart of a forbidden radiation zone.");

                Console.ReadKey();

                Console.Clear();
            }





            public void healthbar()
            {
                int barlength = 20;
                int filled = (health * barlength) / maxhealth;
                string healthbar = new string('■', filled) + new string('-', barlength - filled);

                int consoleWidth = Console.WindowWidth;
                string locHealthbar = healthbar.PadLeft(consoleWidth - barlength);

                string text = "HEALTH";
                string loctext = text.PadLeft(consoleWidth - barlength - 14);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(loctext);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(locHealthbar);
                Console.ForegroundColor = ConsoleColor.White;

            }





        }
    }



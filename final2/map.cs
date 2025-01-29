using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    namespace final
    {
        public class begin
        {
            private string characterName;
            private string characterAge;



            int consoleWidth = Console.WindowWidth;
            public static string CenterText(string text, int consoleWidth)
            {
                if (text.Length >= consoleWidth)
                    return text; // If the text is too long, just return it without centering.

                int spaces = (consoleWidth - text.Length) / 2;
                return new string(' ', spaces) + text;
            }
            public void start()

            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("", consoleWidth));
                Console.WriteLine(CenterText("╔═════════════════════════════╗", consoleWidth));
                Console.WriteLine(CenterText("║  Welcome to 'Age of ashes'  ║", consoleWidth));
                Console.WriteLine(CenterText("╚═════════════════════════════╝", consoleWidth));
                Console.WriteLine(CenterText("╔═══════════════════════╗", consoleWidth));
                Console.WriteLine(CenterText("║ Press Enter to Start  ║", consoleWidth));
                Console.WriteLine(CenterText("╚═══════════════════════╝", consoleWidth));
                Console.WriteLine(CenterText("╔═══════════════════════╗", consoleWidth));
                Console.WriteLine(CenterText("║ Press C to see credits║", consoleWidth));
                Console.WriteLine(CenterText("╚═══════════════════════╝", consoleWidth));
                Console.ForegroundColor = ConsoleColor.White;
                var key = Console.ReadKey(true).Key;

                // Handle the key press
                if (key == ConsoleKey.Enter)
                {
                    Sentence1();
                }
                else if (key == ConsoleKey.C)
                {
                    ShowCredits();
                }
                else
                {
                    Console.WriteLine(CenterText("Invalid input. Please restart the program.", consoleWidth));
                }

            }

            private void Sentence1()
            {
                Console.Clear();
                Console.WriteLine(CenterText("The story begins...", consoleWidth));

            }
            private void ShowCredits()
            {
                Console.Clear();
                Console.WriteLine(CenterText("Credits:", consoleWidth));
                Console.WriteLine(CenterText("Game Developer: Umut Ohri", consoleWidth));
                Console.WriteLine(CenterText("Special Thanks:ChatGpt", consoleWidth));
                Console.WriteLine(CenterText("\nPress Enter to return to the menu.", consoleWidth));
                Console.ReadLine();
                Console.Clear();
            }



        }


    }
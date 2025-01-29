namespace final
{
    public class Program
    {
        public static void Main()
        {
            Gamemenu gamemenu = new Gamemenu();
            begin begin = new begin();

            Map map = new Map();
            begin.start();
            gamemenu.sentence1();

            Console.WriteLine("\nGame is starting... Explore the map!");
            Console.WriteLine("Use W (up), A (left), S (down), D (right) to move.");
            Console.WriteLine("Type 'exit' to quit the game.");

            while (true)
            {


                map.DisplayMap();
                map.healthbar();
                Console.Write("\nYour move (W/A/S/D): ");
                string input = Console.ReadLine()?.ToLower();
                if (input == "exit")
                    break;
                map.MovePlayer(input);
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            Console.WriteLine("Game Over. Thanks for playing!");
        }
    }
}
namespace final
{
    using final;

    using System;
    using System;
    using System.Collections.Generic;
    using System.Threading;
    using final;




    public class Map
    {

        Inventory playerInventory = new Inventory();
        begin begin = new begin();



        int health = 100;
        int maxhealth = 100;
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
        public class Inventory
        {
            private List<string> items = new List<string>();

            public void AddItem(string item)
            {
                items.Add(item);
                Console.WriteLine($"{item} has been added to your inventory.");
            }

            public void ShowInventory()
            {
                if (items.Count == 0)
                {
                    Console.WriteLine("Your inventory is empty.");
                }
                else
                {
                    Console.WriteLine("Your inventory contains:");
                    foreach (var item in items)
                    {
                        Console.WriteLine("- " + item);
                    }
                }
            }

            public bool HasItem(string item)
            {
                return items.Contains(item);
            }
        }

        private string[,] map = new string[5, 5]
        {
            { "Start", ".", ".", ".", "Cave" },
            { ".", ".", "Tower", ".", "." },
            { ".", ".", ".", ".", "." },
            { ".", "House", ".", ".", "." },
            { "Base", ".", ".", ".", "Exit" }
        };

        private void CheckLocation()
        {
            string currentLocation = map[playerY, playerX];

            switch (currentLocation)
            {
                case "Tower":
                    TowerDialogue();
                    break;
                case "Cave":
                    CaveDialogue();
                    break;
                case "House":
                    HouseDialogue();
                    break;
                case "Base":
                    BaseDialogue();
                    break;
                case "Exit":
                    ExitDialogue();
                    break;
            }
        }


        private void TowerDialogue()
        {
            Console.WriteLine("\n=== TOWER ===");
            Console.WriteLine("===============+=++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\r\n=====================++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\r\n=========================+=++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\r\n===============================++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\r\n======================================+++++++++++++++++++++++++++++++++++++++++++++++++++++++\r\n============================================+++++++++++++++++++++++++++++++++++++++++++++++++\r\n--================================================+++++++++++++++++++++++++++++++++++++++++++\r\n-----=================================================+++++++++++++++++++++++++++++++++++++++\r\n------===================================================+=++++++++++++++++++++++++++++++++++\r\n---------===================================================+=+++++++++++++++++++++++++++++++\r\n------------====================================================+++++++++++++++++++++++++++++\r\n----------------====================================================+++++++++++++++++++++++++\r\n-------------------==================================================++++++++++++++++++++++++\r\n-------------------------=============#######%%##%%%%%##+===============+++++++++++++++++++++\r\n-----------------------------------===########%%###%####*================+=++++++++++++++++++\r\n------------------------------------=##%#%@%##@@%#%@%#%##*===================++++++++++++++++\r\n:-----------------------------------+####*#*##############========================+++++++++++\r\n::::--------------------------------*###****##@@#**###*###===============================+++=\r\n::::::-----------------------------+#%%#****##%%##**##*####+=================================\r\n::::::::---------------------------#####**######%###**###%##=================================\r\n::::::::::------------------------*#####@##*##%%%%*%*@%#####=================================\r\n:::::::::::::---------------------###%####*#%#*####**%%##**#*--==============================\r\n:::::::::::::::::----------------+#*##*##******#*####*#*#%**#=--=============================\r\n:::::::::::::::::::::::----:-----***##*#******####**#****#**#*----===========================\r\n::::::::::::::::::::::::::::::::=#*######*##****#*#*******#**#=-----=========================\r\n::::::::::::::::::::::::::::::::######***+**##@@#******#**%###*------========================\r\n.::::::::::::::::::::::::::::::=*#*##*******##@@#***%#****#***#--------======================\r\n...::::::::::::::::::::::::::::*#**#*********#@@%**++******####*---------====================\r\n......::::::::::::::::::::::::-*#**#********##@@%**###***#*#*###-----------==================\r\n........::::::::::::::::::::::*###%********###########**+*#%#####=-----------================\r\n...........:::::::::::::::::*#######*********#******#**##**##**###%=------------=============\r\n..............:::::::::::::=****###**************+*#*******########+--------------=-=========\r\n..................:::::::::*#####%*##****+++****##**%******###*##*##---------------------====\r\n......................::::-#*#**#%####**++******#******#***#####**##+------------------------\r\n........................::**##**####********########***###*#*####*###------------------------\r\n.........................-#****#%##**##****#**##**#%*********##***###+-----------------------\r\n.........................******#%*###*****#*#%@@@#**%##******###**#*##-----------------------\r\n:-......................-*#+***##**#****++++#%##%%********#####*****##+::::------------------\r\n-::-=-::................******##**#*****#***##+*##*******+**####****###:::::::---------------\r\n-:--=::--::............-##****###*#******+**#*++##****++*+*****##****##+:::::::::------------\r\n-.-=+-:=--::...........+******#%#**##*******##**##+**###****+*###*#*#***-::::::::::----------\r\n=-===--:---===-:......:#***#*#%####******+***######*+***++**##*##**#**##+==+++---####*-::----\r\n---#====+-#####**###*####*#*+#####*********++****+++++++********#*******###%%%########+::::::\r\n-*++-==*:*****######*#**#****%#********#**+=+*+++++++******##**#######*#*#%%%#%%#######+:::::\r\n==-::=++%%%%%##############*###***#*#******++++++++*****+++*****##****#**#%%#######%%**##::::\r\n===-+--+***%#***#*#######***#####******+***+**####*+**+**+*+++*###****++####%#####*#%#*##*-=:\r\n+=+#--+#**%#**##%@%###***++*####**********#**++*++**##*+*********#***++**##%##@%#%###%#**##=:\r\n=+*+==*###%*##*#%%##**##*+=*##****++++*#*+++*##%%#*+++*##*++++**##****+**####%%%%#####%***#**\r\n+*-==*#*#%*****#%#*##*****+#%#******##+++*#%@@@%@@@%#***+##+******#++*++***####%%#######**##%\r\n*++-+#####****#%%*****++++*###*#####*+**#%@%@@%%@@@@@@#*+++##+*********+++***%%%%%%#%##%#***#\r\n*---****%###*#%%####*#*+++#%#****##***#%@@@@@@@%@@@@@@@%#***##****#****+++*##%%%%@%%#***%####\r\n==*****%########%##**#+++*##***+*#+**#%@@@@@@@@%@@@@@@@@@#**+*#+***#*+*#*+*###%%##%#####%@%%%\r\n*###*%@%#*****#**##**##***#%*####++*#@@@@@@@@@@%@@@@@@@@@@#*++*#**+*#+=+++++**#######***#%%%%\r\n##**#@@##***********##****##***#*++*%@@@@@@@@@%%@@@@%@@@@@@***##******+++***#*#%%%%%##***#%%%\r\n##**#%%###***##*##***=+**###**##+++#@@@@@%@@%%==:-#%%@@@@@@%*+**#+++*+*********%%%%%%%%#%##%%\r\n**#%%%#########%###**+*+*#%*#*#****%%@@%%%%*--:=*=--+#%%%%%@**********++++*+*#**%%##%#%%##%%%\r\n#*%%@%###**%@%##++*++*+=*%#*****+**%@@@%%%:::.-*=:..::+@@@@%**#*+***##*++++++***#%%%%@%#%%#%%\r\n#%@%%###*#@#*+#**+**++++##*********%@@%%%-..:..:::..:::*@@@@*+++=+***#*+*++*#****##++*%%**%##\r\n*@%%#####%*+++*+++*===++*###***+++*@@%%%+:.::..:-::::-==#%%%#+++**++**++++=++**++#*+++*%#####\r\n#%%%%###%%+++++++**++++*###*****#*#@@@%%+:..:::-+---::=+#%%%%********#**+++*+=****%*++*#%#*##\r\n%%%%####%*+++*****++***###****++**%@@@%%-::::-=++=++++++*%%%%********#%*#*+*+=+***##*++*%####\r\n%%####%%%+++++++++++*+*#%##*******%@@@@%::-==+*+++++==++*%%%%*++*+++**#**+++=++****%**+*#@###\r\n%##*++*%*+++**+++++++*#%%#%#####**%@@@@%==+++++*+=+==++++%%%%*+*#*#####**+=+=+=+#**#***+*%%##\r\n%****#%%******+*++++++#%##******#*@@@@@%+=**+-=##***+*+*+@@@%#+**+++***#*****+++++**######%%#\r\n##**####%###+++====+**##***+++****@@@@@%+***+*+##**+*+***%@@@%++***+*****+++====+**+%%%%%%%%%\r\n%#******++*++++=++++*###*+++++#**#@@@@@%+**###*+++**#****#@@@@**##********+++====****##%#**##\r\n***+*+++*********++**#####**+++**%@@@@@%***##%#+++*#%%#++#@@@@*++******###**+++***######%%###\r\n******+*******##***###%###*******@@@@@@@%@@@%@@%####%%@#+%@@@%#**#**##*##############*#####%#\r\n##*####**#*******+++*#%**********@@@@@@@####%%#%%%%%%@%%%%@@%@%***++++******+*++++*#######%%%\r\n%##%#########*****#*%%%#####*****@@@@@@@**++************#@@@@@%**#******###*##*****####%%%%%%\r\n########%%@#########%%@%##%#%%#%#@@@%%%%%%%%%%%%%%%%%%%%%%%%%@%##%##%%%#%#%%%#####*#%%%%%%%%%\r\n@@@@@@@@%%%##%######@@%###########%%%#########%%%%%%######**##*##%%%%%%%%%%%%######%%%##%@%%%\r\n%%%%%%%#%@%########%%%@@@@@@@@@@%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%@%%%%%%%%%%###*****#%%#%%@@@\r\n%%%%##%%##%%#%%%%%%%%%######%##%%%%#%%%%%#%%%#%%%%####%###%%%%%%%%%%%%%%%%%%%%%#######@@@@%%%\r\n%####%%##%%#%%%%%%%%%%#%####%##%%%########################%%######%%%####%%%%%%%%%%%%%%%%%%%%\r\n%%%%#%%%%%%%%%%%%%%%%#%#%#%%##############%#%#####%%#############%####%%##%%%#%%#%%%%%%%###%%");
            Console.WriteLine("You discovered the the dark tower , years ago bombs that burn and drown radiation all of the world are launched form here." +
                "The area is very radiactive , if you dont have radiation gadget the air could be fatal for you.");
            Console.WriteLine("1.Enter the tower.");
            Console.WriteLine("2. Leave the area.");


            string choice = Console.ReadLine();
            switch (choice)

            {

                case "1":



                    if (playerInventory.HasItem("Key"))
                    {
                        Console.WriteLine("\nYou use the  Key to unlock the door. The lock clicks, and you push the door open, stepping inside the tower.");
                        if (playerInventory.HasItem("Mask"))
                        {
                            Console.WriteLine("After countless trials, you stand before the glowing monolith. The Ancient Book in your hands trembles, its energy resonating with the symbols etched into the stone. As you place your hand on the core, a blinding light engulfs you.\r\n\r\nVisions of creation, destruction, and the secrets of existence flood your mind. The Kai Core Genesis hums, its purpose clear: ultimate power or salvation—both now in your hands. The fate of the world rests on your choice.");
                            playerInventory.AddItem("Finish");
                        }
                        else
                        {
                            health -= 50;
                            Console.WriteLine("The radiation levels are to high. Your skin started to burn.");
                            Console.WriteLine("Leave the area immediately.");
                            Console.WriteLine("Without radiation mask , you cant go further.");

                        }

                    }
                    else
                    {
                        Console.WriteLine("\nThe door is locked. You need the  Key to enter.");
                        Console.WriteLine("You can't enter the tower without it.");
                    }
                    break;
                case "2":
                    Console.WriteLine("\nYou left the tower.");
                    break;


            }
        }


        private void CaveDialogue()
        {

            Console.WriteLine("\n=== CAVE ===");
            Console.WriteLine("                                            ...:++=++++=...     ......                       \r\n                                           ...=======++++++..                                \r\n                               ..      ....:==========+++++++.                               \r\n                             ....::::-====+++=======++++*++++:                               \r\n                           ..=+=========+++===========++*+++**+:......                       \r\n                         ..-+=======*+++++==============+++++++++++**-.....                  \r\n                         .=++===+++*####+===============+++++++++++++*++=..                  \r\n                      ..=======++++*++==================+++++++++++++++++==..                \r\n                      .-+===+++++========================+++++++++++++++++==-.               \r\n                  ..:+============================++=====+++++++++++++++++++=:..             \r\n                 .:++=====+++====================+++======+*++++++++++*+++++=-..             \r\n             ..:++=====+====+++==+====+++=======++++++===++*+++*+**+=+**+++===..             \r\n            ..-+==============++++++===++==+==+++++++++++++++++++====+++++*+=-..             \r\n            ..+++=====================+**++++*+#%%%%*+*++**+++=====+++++++++++=....          \r\n            .+++======================+*++++%%%%%%%%%%%%%%%%*++===+**+++++++++++++:..        \r\n          .=++++++=+==+==++++=======+++*+++#%%%%%%%%%%%%%%%%%%*+++++++++++++++++++*+.        \r\n          .++===========++++*+**++++*++**%%%%%%%%%%%%%%%%%%%%%%*++=+*+++++++++++++++.        \r\n       ...:++=========**++***+**+*****#%%%#%%%%#%%#%%%#%%#%%%%%#***+*+**+++++++++++=.        \r\n       ...+==++++====+++=++=+*+*+**+*+#%%%%%#%#%%%%%%#%%%%%%%##%%#*+**=++++++++++++=.        \r\n       ..:++++++=====+=+*++=+*+*++*+**#%%#%##%#%%%###%#%%#%%#%#%##*=*+*++++++++++++++-....   \r\n       ..:++++*+==++*++++====+++++****%%%%%%%%%%%%%%%%%%%%%%%%%%%#==++++++++++++++++++++-..  \r\n       ...*+++++====+++++++++===+*++*%%%%%%%%%%%%%%%%%%%%%%%%%%%%+=++++++++**+++++++++++++.. \r\n       .++++++==========++++++==++++#%%%%%%%%%%%%%%%%%%%%%%%%%%%%=+===++==========++++++++=. \r\n       :+++===============++++++=+++*%%%%%%%%%%%%%%%%%%%%%%%%%%%%*==++==========++**++++++=. \r\n     ..=====================+++++++++#%%%%%%%%%%%%%%%%%%%%%%%%%%%%%++========+**++++++++++=:.\r\n    ..=====+++================++++++*+#%%%%%%%%%%%%%%%%%%%%%%%%%%%+==========+***+++++++++++-\r\n  ...===++++++===+=============+*++++++=..  ................  ....-*++==========+*+++**+++++=\r\n  ...+++*+*#++==+++++==========++*+*+++=:.                    ...=##*---==+++=====+++++=++++-\r\n  ..:-=##*#+++++++++++=++++==++++==:....---.                  ..=#=------==#*##+=====-=====-.\r\n..-----=*####**+++++++++++++++++++=.........                  ....-------===**+:..-==........\r\n----===---==*##**+===++++++++**+++.-===...                      ..-------====.... ........   \r\n.....:------===-.====++++++++++*=-------=-.                      .. .......-----=.           \r\n   ..------===:...:----==*+=-:.:-------===-.                                                 \r\n     ...........--:..............:----==-...                                                 \r\n            ..-----=.     ....   .....                                                       \r\n            .-----==...  :-===:  .:...                                                       \r\n                         ....   .... ...  ....       ............                            \r\n                           ..::::::.:::::::::::::::..:::::::.:-:.                            ");
            Console.WriteLine("You stand before the ominous entrance of a cave. A faint whisper echoes from within, as if the shadows themselves are calling to you.");
            Console.WriteLine("1. Venture into the cave");
            Console.WriteLine("2. Step back and leave");

            string choice = Console.ReadLine();
            if (choice == "1")
            {

                Console.WriteLine("\nYou stumble upon an eerie altar at the heart of the cave, where a strange book rests under a beam of flickering light.");
                Console.WriteLine("1. Approach the altar and examine the book");
                Console.WriteLine("2. Retreat, feeling a chill run down your spine");

                string bookChoice = Console.ReadLine();
                if (bookChoice == "1")
                {
                    playerInventory.AddItem("Ancient Book");
                    Console.WriteLine("\nThe moment you take the book, the cave begins to tremble.The drawings of the Genesis core took your interest, if these drawings showing the truth the key of the tower could be in same radiation base");

                }
                Console.WriteLine("\nYour current inventory:");
                playerInventory.ShowInventory();
            }
        }


        private void HouseDialogue()
        {

            Console.WriteLine("\n=== HOUSE ===");
            Console.WriteLine("-.......................................................................:-\r\n-.                                        .:+:.                         .-\r\n-.               .:::::::::::::::::::::::=**#**:.                       .-\r\n-.              :*######################*##=:+%*+:.                     .-\r\n-.           .:=*++=++=++==++=++=+++=+**#+:...-##*=:.                   .-\r\n-.         .:=+++=++=++==++=++=++==+**%+*###%##%**#*=:.                 .-\r\n-.        .+++==++=++=+++=++=++==***%+::+=.-#-.%+:-*#*+.                .-\r\n-.      .=*++=++==++=++==++=++=+**##:...+*=+%+-%=...=#**=.              .-\r\n-.   ..-*++=++==++=++=+++=++=+**#*-.....:=======:....:=#**-..           .-\r\n-.  .=*#*********************#%@%%#####################%@@#+=.          .-\r\n-.  +**#####@#**#@#############*#%+:%:..+=.:::.%+..-#:*@#%@@%#          .-\r\n-.   .......%=:.=#:...........-:=*::%:..+%#####@=..-#:.%=#%*++*:.       .-\r\n-.   .......%=::=#:...........-:=*::%:..+=.:::.%=..-#:.%=-+++=+++:.     .-\r\n-.   .......+++++=..........++=:=*-*%:..+#+++++%+..-%+.%==+=++==+*=:.   .-\r\n-.  ..:::::::::::::::::::+@@-=%@@@#::::::::::::::::::-%@=+##########=.  .-\r\n-.  :+%@@############@@#*+++==+++*#@@%#############%@@####%%%%%%%@@%+:  .-\r\n-.   .=**===@*==*%+=++*+==========+**+==#*=++==@*==+**===%@@@@@@%**=.   .-\r\n-.   .-+=...%=:.=#:.:=+-.::::::::.:+=:..+=.:::.%+..:++:..#@@@@@#-=+-.   .-\r\n-.   .-+=...%=:.=#:.:=+-.=%%%%%%+.:+=:..+=.:::.%+..:++...#@@@*:*-=+-.   .-\r\n-.   .-+=...%=:.=#:.:=+-.=*.::.*+.:+=:..+=.:::.%+..:++...#%%+. *-=+-.   .-\r\n-.   .-+=...#####+...=+:.=*----*+.:+=:..=#######=..:++...=:-+. *-=+-.   .-\r\n-.   .-+=............=+:.=#@@@@%+.:+=:.............:++...+*##**##++-.   .-\r\n-.   .-+=............=+:.=#@@@@%+.:+=:.............:++...+*******++-.   .-\r\n-.  .=##############################################################=.  .-\r\n-.  .-++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++-.  .-\r\n--+********************************************************************+--\r\n-.  .:=======+**********************************************+=======:.  .-\r\n-.          ..........+****************************+..........          .-\r\n-::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::::-");
            Console.WriteLine("You saw a small house. Lights coming out of its windows.");
            Console.WriteLine("1. Knock the door.");
            Console.WriteLine("2. Leave");
            string choice = Console.ReadLine();
            switch (choice)

            {

                case "1":
                    Console.WriteLine("\nYou talk about the book you find in the cave , homeowner seemed little bit suspicous,but he said he is so exhasuted to live like that he will help you" +
                        "and he give you a  'radiation mask'");
                    playerInventory.AddItem("Mask");
                    Console.WriteLine("\nYour current inventory:");
                    playerInventory.ShowInventory();



                    break;


                case "2":
                    Console.WriteLine("\nYou left the House");
                    break;


            }



        }


        private void BaseDialogue()
        {

            Console.WriteLine("\n=== MILITARY BASE ===");
            Console.WriteLine("You are in a abandon military base.The radiation level seems very high.");
            Console.WriteLine("1.Enter the base.");
            Console.WriteLine("2. Leave the area.");

            string choice = Console.ReadLine();
            switch (choice)

            {

                case "1":

                    if (playerInventory.HasItem("Mask"))
                    {
                        Console.WriteLine("Mask saves you from high level of radiation. You searched all the facilty and you found a key in the admin room .");
                        playerInventory.AddItem("Key");
                        Console.WriteLine("\nYour current inventory:");
                        playerInventory.ShowInventory();
                    }
                    else
                    {
                        health -= 50;
                        Console.WriteLine("The radiation levels are to high. Your skin started to burn.");
                        Console.WriteLine("Leave the area immediately.");
                        Console.WriteLine("Without radiation mask , you cant go further.");
                    }
                    break;


                case "2":
                    Console.WriteLine("\nYou left the tower.");
                    break;


            }
        }

        private void ExitDialogue()
        {

            Console.WriteLine("\n=== Exit ===");
            Console.WriteLine("You are in the exit .");
            Console.WriteLine("1.Exit ");
            Console.WriteLine("2. Continue");

            string choice = Console.ReadLine();
            switch (choice)

            {

                case "1":

                    if (playerInventory.HasItem("Finish"))
                    {
                        Console.WriteLine("You succesfully finished the game!");
                        Thread.Sleep(2000);
                        Inventory playerInventory = new Inventory();
                        health = 100;
                        Console.Clear();
                        begin.start();



                    }
                    else
                    {

                        Console.WriteLine("You need to finish the game before exit");

                    }
                    break;


                case "2":

                    break;


            }

        }




        private int playerX = 0;
        private int playerY = 0;

        public void DisplayMap()
        {
            Console.Clear();
            Console.WriteLine("\nMap Legend: P = Player, . = Empty, Other symbols show special locations");
            Console.WriteLine("Current Location: " + map[playerY, playerX]);
            Console.WriteLine();

            for (int row = 0; row < 5; row++)
            {
                for (int col = 0; col < 5; col++)
                {
                    if (row == playerY && col == playerX)
                        Console.Write("P ");
                    else if (map[row, col] != ".")
                        Console.Write(map[row, col][0] + " ");
                    else
                        Console.Write(". ");
                }
                Console.WriteLine();
            }
        }


        private void UpdateHealthBasedOnLocation()
        {
            string currentLocation = map[playerY, playerX];

            switch (currentLocation)
            {
                case "Cave":
                    health -= 0;
                    Console.WriteLine(" ");
                    break;
                case "Tower":
                    health -= 30;
                    Console.WriteLine("The radiation started to poison you. (-20 HP)");
                    break;
                case "House":
                    health += 20;
                    if (health > maxhealth) health = maxhealth;
                    Console.WriteLine("\nStaying in a warm house help to collecting you energy. (+20 HP)");
                    break;
                case "Base":
                    health -= 30;
                    if (health > maxhealth) health = maxhealth;
                    Console.WriteLine("\nThe radiation started to poison you (-20 HP)");
                    break;
            }


            if (health <= 0)
            {
                Console.Clear();
                healthbar();
                Console.WriteLine("\nÖLDÜNÜZ! Oyun bitti.");
                Environment.Exit(0);
            }
        }


        public void MovePlayer(string input)
        {
            int oldX = playerX;
            int oldY = playerY;

            switch (input.ToLower())
            {
                case "w": if (playerY > 0) playerY--; break;
                case "s": if (playerY < 4) playerY++; break;
                case "a": if (playerX > 0) playerX--; break;
                case "d": if (playerX < 4) playerX++; break;
                default: Console.WriteLine("Invalid move! Use W/A/S/D."); return;
            }

            if (playerX != oldX || playerY != oldY)
            {
                Console.WriteLine($"\nYou moved to a new location.");
                UpdateHealthBasedOnLocation();
                CheckLocation();
            }
            else
            {
                Console.WriteLine("You can't move there!");
            }
        }

    }
}

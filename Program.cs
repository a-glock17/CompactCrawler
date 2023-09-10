using System;
using System.Threading;

// ANSI art title screen created with -> http://www.patorjk.com/software/taag/#p=display&f=ANSI%20Shadow
// code was written in Visual Studio Code with the Better Comments extension, for best note readibility, have it installed -> https://marketplace.visualstudio.com/items?itemName=aaron-bond.better-comments

namespace CompactDungeonCrawler {
    class Program {
        static void Main(string[] args) {

            // displays game logo with menu options and requests an int type input
            Console.WriteLine("██████╗ ██████╗ ███╗   ███╗██████╗  █████╗  ██████╗████████╗  \n██╔════╝██╔═══██╗████╗ ████║██╔══██╗██╔══██╗██╔════╝╚══██╔══╝  \n██║     ██║   ██║██╔████╔██║██████╔╝███████║██║        ██║     \n██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██╔══██║██║        ██║     \n╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ██║  ██║╚██████╗   ██║     \n ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝  ╚═╝ ╚═════╝   ╚═╝ ");
            Console.WriteLine("██████╗ ██╗   ██╗███╗   ██╗ ██████╗ ███████╗ ██████╗ ███╗   ██╗\n██╔══██╗██║   ██║████╗  ██║██╔════╝ ██╔════╝██╔═══██╗████╗  ██║\n██║  ██║██║   ██║██╔██╗ ██║██║  ███╗█████╗  ██║   ██║██╔██╗ ██║\n██║  ██║██║   ██║██║╚██╗██║██║   ██║██╔══╝  ██║   ██║██║╚██╗██║\n██████╔╝╚██████╔╝██║ ╚████║╚██████╔╝███████╗╚██████╔╝██║ ╚████║\n╚═════╝  ╚═════╝ ╚═╝  ╚═══╝ ╚═════╝ ╚══════╝ ╚═════╝ ╚═╝  ╚═══╝");
            Console.WriteLine(" ██████╗██████╗  █████╗ ██╗    ██╗██╗     ███████╗██████╗ ██╗  \n██╔════╝██╔══██╗██╔══██╗██║    ██║██║     ██╔════╝██╔══██╗██║  \n██║     ██████╔╝███████║██║ █╗ ██║██║     █████╗  ██████╔╝██║  \n██║     ██╔══██╗██╔══██║██║███╗██║██║     ██╔══╝  ██╔══██╗╚═╝  \n╚██████╗██║  ██║██║  ██║╚███╔███╔╝███████╗███████╗██║  ██║██╗  \n ╚═════╝╚═╝  ╚═╝╚═╝  ╚═╝ ╚══╝╚══╝ ╚══════╝╚══════╝╚═╝  ╚═╝╚═╝  ");
            Console.Write("---------------------------------------------------------------\nWelcome! Please select a menu.\n\n1. New Game\n2. Close Game\n\n>>> ");

            // kinda jank method to get int input, will need to improve later
            string playerMainMenuInput = Console.ReadLine();
            int playerMainMenuConvertedInput = Convert.ToInt32(playerMainMenuInput);

            // input == 1, this is the case for a new game
            if (playerMainMenuConvertedInput == 1) {
                CreateNewSaveFile(true);
            }

            // input == 2, this is the case for closing the game
            else if (playerMainMenuConvertedInput == 2) {
                Console.WriteLine("Program closing...");
                Thread.Sleep(250); 
                // * thread.sleep() is measured in milliseconds and not seconds
            }

            // extra else command as a catch for basically everything else, throws code 1 for error
            else {
                Console.Error.Write("Input given is not valid.\n");
                Environment.Exit(1);
            }

        }

        private static void CreateNewSaveFile(bool GameState) {
            if (GameState != true) {
                Console.Error.Write("Error in boolean 'GameState'.\nBoolean was not set to true state.\n");
                Environment.Exit(1);
            }

            // * super basic character creation saved to a text file before game is loaded

            string playerCharacterName;
            int playerChosenGenderIdentity;

            // these are customizable even after player chose identity
            string playerIdentifyingPronoun1; // ? pronoun1 is "she/he/they"
            string playerIdentifyingPronoun2; // ? pronoun2 is "her/him/them"

            Console.WriteLine("What is your characters name?\n>> ");

            playerCharacterName = Console.ReadLine();


        }

    }

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Scark.ast;

namespace Scark.ast.start
{
    public class Menu
    {
        public void menuSeq()
        {
            Console.Clear();
            //Choose a random colour
            ConsoleColor[] colours = {ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.DarkCyan, ConsoleColor.DarkMagenta, ConsoleColor.Green, ConsoleColor.Yellow, ConsoleColor.White, ConsoleColor.DarkRed };
            Random rand = new Random();
            int chosenIndex = rand.Next(colours.Length);
            
            //Print the title with the random colour chosen (if special effects is enabled)
            if (Character.Settings["SpecialEffects"])
            {
                Console.ForegroundColor = colours[chosenIndex];
            }
            
            Console.WriteLine("      ███████                                         █    \n    █       ███                                     ██  \n   █         ██                                     ██\n   ██        █                                      ██ \n    ███                                ███  ████    ██\n   ██ ███           ████       ████     ████ ████ █ ██  ███  \n    ███ ███        █ ███  █   █ ███  █   ██   ████  ██ █ ███\n      ███ ███     █   ████   █   ████    ██         ███   █ \n        ███ ███  ██         ██    ██     ██         ██   █ \n          ██ ███ ██         ██    ██     ██         ██  █\n           ██ ██ ██         ██    ██     ██         ██ ██ \n            █ █  ██         ██    ██     ██         ██████ \n  ███        █   ███     █  ██    ██     ███        ██  ███ \n █  █████████     ███████    █████ ██     ███       ██   ███ █\n█     █████        █████      ███   ██               ██   ███\n█      \n ██ ");
            
            //Change the colour scheme to desired setting
            if (Character.Settings["ColourTheme"] == "dark")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (Character.Settings["ColourTheme"] == "light")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }

            //Print version with colours conforming with the theme
            Console.Write("                        " + Program.gameVersion);

            //Wait for player input to start the game
            Console.WriteLine("\n                 ┌─────────────────────────┘\n");
            Console.WriteLine("           Press any key to enter the realm of Scark");
            Console.ReadKey();

            //Instantiate classes for later
            menuSequenceAntiComplex.main(colours, chosenIndex);
        }

        internal static class menuSequenceAntiComplex
        {
            internal static void main(ConsoleColor[] colours, int chosenIndex)
            {
                //Option selection
                bool optionSelected = false;

                while (optionSelected == false)
                {
                    menuSequenceAntiComplex.prints(colours, chosenIndex);
                    optionSelected = run((Console.ReadLine().ToLower().Replace(" ", "") + "   ").Substring(0, 3).Replace(" ", ""));
                }
            }

            internal static void prints(ConsoleColor[] colours, int chosenIndex)
            {
                Console.Clear();

                //Print the title with the random colour chosen (if special effects is enabled)
                if (Character.Settings["SpecialEffects"])Console.ForegroundColor = colours[chosenIndex];

                Console.WriteLine("      ███████                                         █    \n    █       ███                                     ██  \n   █         ██                                     ██\n   ██        █                                      ██ \n    ███                                ███  ████    ██\n   ██ ███           ████       ████     ████ ████ █ ██  ███  \n    ███ ███        █ ███  █   █ ███  █   ██   ████  ██ █ ███\n      ███ ███     █   ████   █   ████    ██         ███   █ \n        ███ ███  ██         ██    ██     ██         ██   █ \n          ██ ███ ██         ██    ██     ██         ██  █\n           ██ ██ ██         ██    ██     ██         ██ ██ \n            █ █  ██         ██    ██     ██         ██████ \n  ███        █   ███     █  ██    ██     ███        ██  ███ \n █  █████████     ███████    █████ ██     ███       ██   ███ █\n█     █████        █████      ███   ██               ██   ███\n█      \n ██ ");
                Character.revertColourScheme();

                if (Character.Loaded) Console.Write("\n                 Start      Settings    Exit\n           =[ 1 ]=    =[ 2 ]=    =[ 3 ]=   =[ x ]=\n> "); // Options
                else Console.Write("\n             New       Load      Settings    Exit\n           =[ 1 ]=    =[ 2 ]=    =[ 3 ]=   =[ x ]=\n> "); // Options

                if (Character.dev == true) Console.Write("Dev mode enabled\n> "); // Saying if dev mode is enabled
            }

            internal static bool run(string option)
            {
                switch (option)
                {
                    case "1": //New Game
                        new ast.story().Run();
                        return true;
                    case "dev": //Dev mode (hidden)
                        if (Character.dev == false) Character.dev = true;
                        else Character.dev = false;
                        return false;
                    case "2": //Load character (doesn't work yet)
                        Console.WriteLine("\nThis feature is currently WIP");
                        Character.pressAnyKeyToContinue();
                        Console.Clear();
                        return false;
                    case "3": //Settings
                        new SettingsMenu().run();
                        return false;
                    case "x": //Exit
                        Character.stage = -1;
                        return true;
                    default: //for when they try to be smartasses
                        Console.WriteLine("Please input a valid number!");
                        return false;
                }
                throw new NotImplementedException();
            }
        }
    }
}
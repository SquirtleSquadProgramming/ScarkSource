
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

            //Print the title with the random colour chosen
            Console.ForegroundColor = colours[chosenIndex];
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
            story Story = new story();
            SettingsMenu settingsMenu = new SettingsMenu();
            CommandsList commandsList = new CommandsList();

            //Option selection
            bool optionSelected = false;
            while (optionSelected == false)
            {
                Console.Clear();

                //Print the title with the random colour chosen
                Console.ForegroundColor = colours[chosenIndex];
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
                Console.Write("\n        New       Load     Settings   Commands     Exit\n      =[ 1 ]=    =[ 2 ]=    =[ 3 ]=    =[ 4 ]=    =[ x ]=\n> "); // Options
                if (Character.dev == true) Console.Write("Dev mode enabled\n> "); // Saying if dev mode is enabled

                switch (Console.ReadLine())
                {
                    case "1": //New Game
                        optionSelected = true;
                        Story.Run();
                        break;
                    case "dev": //Dev mode (hidden)
                        if (Character.dev == false) Character.dev = true;
                        else Character.dev = false;
                        break;
                    case "2": //Load character (doesn't work yet)
                        optionSelected = true;
                        Console.WriteLine("\nThis feature is currently WIP");
                        Thread.Sleep(Character.Settings["SpeechSpeed"]);
                        Console.Clear();
                        menuSeq();
                        
                        break;
                    case "3": //Settings
                        settingsMenu.run();
                        break;
                    case "4":
                        commandsList.run();
                        break;
                    case "x": //Exit
                        optionSelected = true; // what does this code do?? - DC

                        Console.Clear();
                        Console.Write("Are you sure you want to exit?\n[1] Yes \n[2] No\n\n> ");
                        string r = Console.ReadLine();
                        
                        switch (r)
                        {
                            case "1":
                                Environment.Exit(0); // closes the consoleapp window -- might have problems according to stackoverflow but idk lmao
                                break;
                            case "2":
                                menuSeq();
                                break;
                            default:
                                Console.WriteLine("\nPlease input a valid number!");
                                Thread.Sleep(Character.Settings["SpeechSpeed"]);
                                break;
                        }

                        break;
                    default: //for when they try to be smartasses
                        Console.WriteLine("Please input a valid number!");
                        break;
                }
            }
        }

        
    }
}

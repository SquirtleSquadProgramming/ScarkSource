
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

            //Print the title and toggle a blue colour
            Console.ForegroundColor = ConsoleColor.DarkCyan;
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
            Console.WriteLine("\n\nPress any key to enter the realm of Scark...");
            Console.ReadKey();
            
            //Instantiate classes for later
            story Story = new story();
            SettingsMenu settingsMenu = new SettingsMenu();

            //Option selection
            bool optionSelected = false;
            while (optionSelected == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.DarkCyan;
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

                Console.Write("\n[1] New Game\n[2] Load Player [WIP]\n[3] Settings\n\n[x] Exit\n> "); // Options
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
                        Console.WriteLine("This feature is currently WIP");
                        Thread.Sleep(Character.Settings["SpeechSpeed"]);
                        menuSeq();
                        break;
                    case "3": //Settings
                        settingsMenu.run();
                        break;
                    case "x": //Exit
                        optionSelected = true;
                        break;
                    default: //for when they try to be smartasses
                        Console.WriteLine("Please input a valid number!");
                        break;
                }
            }
        }
    }
}

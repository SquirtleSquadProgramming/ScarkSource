using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Scark.ast.start
{
    class SettingsMenu
    {
        Menu menu = new Menu();

        public void run() // starting code
        {
            Console.Clear();

            Console.Write($"Please select the setting you wish to edit.\n[1] Dialogue Speed\n= {Character.Settings["SpeechSpeed"]}\n\n[2] Profanity\n= {Character.Settings["Profanity"]}\n\n[3] ColourTheme\n= {Character.Settings["ColourTheme"]}\n\n[x] Exit\n> ");
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    editDialogueSpeedSetting();
                    break;
                case "2":
                    editProfanitySetting();
                    break;
                case "3":
                    editColourThemeSetting();
                    break;
                case "x":
                case "X":
                    menu.menuSeq();
                    break;
                default:
                    Console.WriteLine("\nPlease enter a valid number!");
                    Thread.Sleep(Character.Settings["SpeechSpeed"]);
                    break;
            }
        }

        public void editDialogueSpeedSetting()
        {
            Console.Clear();

            Console.Write("\nPlease enter the speed of dialogue in milliseconds (1000ms = 1s).\nThe default is 1500ms\n> ");
            string response = Console.ReadLine();

            try
            {
                if (Convert.ToInt32(response) <= 5000)
                {
                    Character.Settings["SpeechSpeed"] = Convert.ToInt32(response);
                    Console.WriteLine("\n");
                    for (int i = 0; i < 3; i++)
                    {
                        Console.WriteLine("Testing Speed...");
                        Thread.Sleep(Character.Settings["SpeechSpeed"]);
                    }
                    
                    run();
                }
                else
                {
                    Console.WriteLine("Please enter a value equal or less than 5000!");
                    Thread.Sleep(Character.Settings["SpeechSpeed"]);
                    Console.Clear();
                    editDialogueSpeedSetting();
                }
            }
            catch // if theres an error eg. inputted string
            {
                Console.WriteLine("Please enter a valid number!");
                
                Thread.Sleep(Character.Settings["SpeechSpeed"]);
                Console.Clear();
                editDialogueSpeedSetting();
            }

        }

        public void editProfanitySetting()
        {
            Console.Clear();

            Console.Write("\nPlease input \"T\" or \"F\".\n> ");
            string response = Console.ReadLine();

            try
            {
                if (response.ToLower() == "f")
                {
                    Character.Settings["Profanity"] = false;

                    Character.SwearReplacements["the hell"] = "the hell";

                    run();
                }
                if (response.ToLower() == "t")
                {
                    Character.Settings["Profanity"] = true;

                    Character.SwearReplacements["the hell"] = "the fuck";

                    run();
                }
                else
                {
                    Console.WriteLine("Please enter a valid value! (T or F)");
                    Thread.Sleep(Character.Settings["SpeechSpeed"]);
                    Console.Clear();
                    editProfanitySetting();

                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid input! (f or t)");

                Thread.Sleep(Character.Settings["SpeechSpeed"]);
                Console.Clear();
                editProfanitySetting();
            }
        }

        public void editColourThemeSetting()
        {
            Console.Clear();

            Console.Write("\nPlease input \"Dark\" or \"Light\".\n> ");
            string response = Console.ReadLine();

            try
            {
                if (response.ToLower() == "dark")
                {
                    Character.Settings["ColourTheme"] = "dark";
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.BackgroundColor = ConsoleColor.Black;

                    run();
                }
                if (response.ToLower() == "light")
                {
                    Character.Settings["ColourTheme"] = "light";
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.BackgroundColor = ConsoleColor.White;

                    run();
                }
                else
                {
                    Console.WriteLine("Please enter a valid value! (Dark or Light)");
                    Thread.Sleep(Character.Settings["SpeechSpeed"]);
                    Console.Clear();
                    editColourThemeSetting();

                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid input! (f or t)");

                Thread.Sleep(Character.Settings["SpeechSpeed"]);
                Console.Clear();
                editColourThemeSetting();
            }
        }
    }
}

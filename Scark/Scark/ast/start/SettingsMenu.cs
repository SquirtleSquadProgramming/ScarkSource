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

            Console.Write($"Please select the setting you wish to edit.\n[1] Dialogue Speed\n= {Character.Settings["SpeechSpeed"]}\n\n[2] Profanity\n= {Character.Settings["Profanity"]}\n\n[3] ColourTheme\n= {Character.Settings["ColourTheme"]}\n\n[4] SpecialEffects\n= {Character.Settings["SpecialEffects"]}\n\n[5] Full Screen(WIP - Not Recommended)\n\n[x] Exit\n> ");
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
                case "4":
                    editSpecialEffectsSetting();
                    break;
                case "5":
                    FullScreen FS = new FullScreen();
                    FS.MakeFullScreen(); // Full Screen was abit to big so it has its own file
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

            Console.Write("\nPlease enter a speed modifier less than 10.\nThe default is 4\n> ");
            string response = Console.ReadLine();

            try
            {
                if (Convert.ToInt32(response) <= 10)
                {
                    Character.Settings["SpeechSpeed"] = Convert.ToInt32(response);
                    Console.WriteLine("\n");
                    
                    run();
                }
                else
                {
                    Console.WriteLine("Please enter a value equal or less than 10!");
                    Thread.Sleep(2000);
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

                    run();
                }
                if (response.ToLower() == "t")
                {
                    Character.Settings["Profanity"] = true;

                    run();
                }
                else
                {
                    Console.WriteLine("Please enter a valid value! (T or F)");
                    Thread.Sleep(2000);
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

                Thread.Sleep(2000);
                Console.Clear();
                editColourThemeSetting();
            }
        }

        public void editSpecialEffectsSetting()
        {
            Console.Clear();

            Console.Write("\nPlease input \"T\" or \"F\".\n> ");
            string response = Console.ReadLine();

            try
            {
                if (response.ToLower() == "t")
                {
                    Character.Settings["SpecialEffects"] = true;

                    run();
                }
                if (response.ToLower() == "f")
                {
                    Character.Settings["SpecialEffects"] = false;

                    run();
                }
                else
                {
                    Console.WriteLine("Please enter a valid value! (T or F)");
                    Thread.Sleep(2000);
                    Console.Clear();
                    editSpecialEffectsSetting();
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid input! (f or t)");

                Thread.Sleep(2000);
                Console.Clear();
                editSpecialEffectsSetting();
            }
        }
    }
}

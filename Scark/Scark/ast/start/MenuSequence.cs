
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

            //Danny Doing Font Stuff and idk how it works plz halp
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      #######                                         #    \n    #       ###                                     ##  \n   #         ##                                     ##\n   ##        #                                      ## \n    ###                                ###  ####    ##\n   ## ###           ####       ####     #### #### # ##  ###  \n    ### ###        # ###  #   # ###  #   ##   ####  ## # ###\n      ### ###     #   ####   #   ####    ##         ###   # \n        ### ###  ##         ##    ##     ##         ##   # \n          ## ### ##         ##    ##     ##         ##  #\n           ## ## ##         ##    ##     ##         ## ## \n            # #  ##         ##    ##     ##         ###### \n  ###        #   ###     #  ##    ##     ###        ##  ### \n #  #########     #######    ##### ##     ###       ##   ### #\n#     #####        #####      ###   ##               ##   ###\n#      \n ## ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                        " + Program.gameVersion);

            Console.WriteLine("\n\nPRESS ANY KEY TO BEGIN...");
            Console.ReadKey();
            
            story Story = new story();
            SettingsMenu settingsMenu = new SettingsMenu();


            bool optionSelected = false;
            while (optionSelected == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n      #######                                         #    \n    #       ###                                     ##  \n   #         ##                                     ##\n   ##        #                                      ## \n    ###                                ###  ####    ##\n   ## ###           ####       ####     #### #### # ##  ###  \n    ### ###        # ###  #   # ###  #   ##   ####  ## # ###\n      ### ###     #   ####   #   ####    ##         ###   # \n        ### ###  ##         ##    ##     ##         ##   # \n          ## ### ##         ##    ##     ##         ##  #\n           ## ## ##         ##    ##     ##         ## ## \n            # #  ##         ##    ##     ##         ###### \n  ###        #   ###     #  ##    ##     ###        ##  ### \n #  #########     #######    ##### ##     ###       ##   ### #\n#     #####        #####      ###   ##               ##   ###\n#      \n ## ");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\n[1] New Game\n[2] Load Player [WIP]\n[3] Settings\n\n[x] Exit\n> "); // Options
                if (Character.dev == true) Console.Write("Dev mode enabled\n> "); // Saying if dev mode is enabled

                switch (Console.ReadLine())
                {
                    case "1":
                        optionSelected = true;
                        Story.Run();
                        break;
                    case "dev":
                        if (Character.dev == false) Character.dev = true;
                        else Character.dev = false;
                        break;
                    case "2":
                        optionSelected = true;
                        Console.WriteLine("This feature is WIP");
                        Thread.Sleep(Character.Settings["SpeechSpeed"]);
                        menuSeq();
                        break;
                    case "3":
                        settingsMenu.run();
                        break;
                    case "x":
                        optionSelected = true;
                        break;
                    default:
                        Console.WriteLine("Please input a valid number!");
                        break;
                }
            }
        }
    }
}

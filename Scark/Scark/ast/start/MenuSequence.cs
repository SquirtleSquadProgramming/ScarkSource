
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
        public static bool dev = false;
        public const string version = "v0.1.3-alpha";

        public void menuSeq()
        {
            Console.Clear();

            //Danny Doing Font Stuff and idk how it works plz halp
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      #######                                         #    \n    #       ###                                     ##  \n   #         ##                                     ##\n   ##        #                                      ## \n    ###                                ###  ####    ##\n   ## ###           ####       ####     #### #### # ##  ###  \n    ### ###        # ###  #   # ###  #   ##   ####  ## # ###\n      ### ###     #   ####   #   ####    ##         ###   # \n        ### ###  ##         ##    ##     ##         ##   # \n          ## ### ##         ##    ##     ##         ##  #\n           ## ## ##         ##    ##     ##         ## ## \n            # #  ##         ##    ##     ##         ###### \n  ###        #   ###     #  ##    ##     ###        ##  ### \n #  #########     #######    ##### ##     ###       ##   ### #\n#     #####        #####      ###   ##               ##   ###\n#      \n ## ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("                        " + version);

            Console.WriteLine("\n\nPRESS ANY KEY TO BEGIN...");
            Console.ReadKey();

            Menu menu = new Menu();
            story Story = new story();
            SettingsMenu settingsMenu = new SettingsMenu();


            bool optionSelected = false;
            while (optionSelected == false)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("\n      #######                                         #    \n    #       ###                                     ##  \n   #         ##                                     ##\n   ##        #                                      ## \n    ###                                ###  ####    ##\n   ## ###           ####       ####     #### #### # ##  ###  \n    ### ###        # ###  #   # ###  #   ##   ####  ## # ###\n      ### ###     #   ####   #   ####    ##         ###   # \n        ### ###  ##         ##    ##     ##         ##   # \n          ## ### ##         ##    ##     ##         ##  #\n           ## ## ##         ##    ##     ##         ## ## \n            # #  ##         ##    ##     ##         ###### \n  ###        #   ###     #  ##    ##     ###        ##  ### \n #  #########     #######    ##### ##     ###       ##   ### #\n#     #####        #####      ###   ##               ##   ###\n#      \n ## ");
                Console.ForegroundColor = ConsoleColor.White;

                Console.Write("\n[1] New Game\n[2] Load Player [WIP]\n[3] Settings\n> "); // Options
                if (dev == true) Console.Write("Dev mode enabled\n> "); // Saying if dev mode is enabled

                switch (Console.ReadLine())
                {
                    case "1":
                        optionSelected = true;
                        Story.Run(new string[] { "", "", "0" });
                        break;
                    case "dev":
                        if (dev == false) dev = true;
                        else dev = false;
                        break;
                    case "2":
                        optionSelected = true;
                        Console.WriteLine("This feature is WIP");
                        Thread.Sleep(settingsMenu.dialogueSpeed);
                        menuSeq();
                        break;
                    case "3":

                        settingsMenu.run();
                        break;
                    default:
                        Console.WriteLine("Please input a valid number!");
                        break;
                }
            }

            Console.Read();
        }
    }
}

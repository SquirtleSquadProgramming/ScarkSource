
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.start
{
    public class Menu
    {

        string version = "v0.1.1-alpha";

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

            Console.Clear();
            //Looks Nicer if We Put The Title Up For The Rest of the menu options
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("      #######                                         #    \n    #       ###                                     ##  \n   #         ##                                     ##\n   ##        #                                      ## \n    ###                                ###  ####    ##\n   ## ###           ####       ####     #### #### # ##  ###  \n    ### ###        # ###  #   # ###  #   ##   ####  ## # ###\n      ### ###     #   ####   #   ####    ##         ###   # \n        ### ###  ##         ##    ##     ##         ##   # \n          ## ### ##         ##    ##     ##         ##  #\n           ## ## ##         ##    ##     ##         ## ## \n            # #  ##         ##    ##     ##         ###### \n  ###        #   ###     #  ##    ##     ###        ##  ### \n #  #########     #######    ##### ##     ###       ##   ### #\n#     #####        #####      ###   ##               ##   ###\n#      \n ## ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n[1] New Game\n[2] Load [WIP]");
            string input = Console.ReadLine();
            Scark.ast.story Story = new Scark.ast.story();

            switch (input)
            {
                case "1":
                    Story.Run(new string[] { "", "", "0" });
                    break;
                case "1d":
                    Story.Run(new string[] { "", "", "0" }, true);
                    break;
                case "2":
                    Console.WriteLine("This feature is WIP");
                    break;
                default:
                    Console.WriteLine("Please input a valid number!");
                    menuSeq();
                    break;
            }

            Console.Read();
        }
    }
}

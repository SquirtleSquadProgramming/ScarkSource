﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.start
{
    public class Menu
    {
        public void menuSeq()
        {
            CC charcterCreation = new CC();
            //Danny Doing Font Stuff and idk how it works plz halp
            Console.WriteLine("      #######                                         #    \n    #       ###                                     ##  \n   #         ##                                     ##\n   ##        #                                      ## \n    ###                                ###  ####    ##\n   ## ###           ####       ####     #### #### # ##  ###  \n    ### ###        # ###  #   # ###  #   ##   ####  ## # ###\n      ### ###     #   ####   #   ####    ##         ###   # \n        ### ###  ##         ##    ##     ##         ##   # \n          ## ### ##         ##    ##     ##         ##  #\n           ## ## ##         ##    ##     ##         ## ## \n            # #  ##         ##    ##     ##         ###### \n  ###        #   ###     #  ##    ##     ###        ##  ### \n #  #########     #######    ##### ##     ###       ##   ### #\n#     #####        #####      ###   ##               ##   ###\n#      \n ## ");

            Console.WriteLine("\nPress any key to begin...");
            Console.ReadKey();
            Console.Clear();
            //Looks Nicer if We Put The Title Up For The Rest of the menu options
            Console.WriteLine("      #######                                         #    \n    #       ###                                     ##  \n   #         ##                                     ##\n   ##        #                                      ## \n    ###                                ###  ####    ##\n   ## ###           ####       ####     #### #### # ##  ###  \n    ### ###        # ###  #   # ###  #   ##   ####  ## # ###\n      ### ###     #   ####   #   ####    ##         ###   # \n        ### ###  ##         ##    ##     ##         ##   # \n          ## ### ##         ##    ##     ##         ##  #\n           ## ## ##         ##    ##     ##         ## ## \n            # #  ##         ##    ##     ##         ###### \n  ###        #   ###     #  ##    ##     ###        ##  ### \n #  #########     #######    ##### ##     ###       ##   ### #\n#     #####        #####      ###   ##               ##   ###\n#      \n ## ");
            Console.WriteLine("\n[1] New Game\n[2] Load");
            string input = Console.ReadLine();

            string[] tmp;

            switch (input)
            {
                case "1":
                    //New Game Should be Called
                    //Call NewPlayer In CC
                    tmp = charcterCreation.NewPlayer(false);
                    break;
                case "1d":
                    tmp = charcterCreation.NewPlayer(true);
                    break;
                case "2":
                    //Load Should be Called But It Might Not Idk... JK
                    //Danny Fanny Needs To Do Stuff Here
                    Console.WriteLine("u did smthng 2");
                    break;
                default:
                    Console.WriteLine("Please input a valid number!");
                    menuSeq();
                    break;
            }
            

        }
    }
}

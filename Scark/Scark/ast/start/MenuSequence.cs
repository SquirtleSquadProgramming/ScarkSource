using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.start
{
    public void menuSeq()
    {
        CC charcterCreation = new CC();
        //Danny Doing Font Stuff and idk how it works plz halp
        Console.WriteLine(""/*Ascii.Title*/);

        Console.WriteLine("Press any key to begin...");
        Console.ReadKey();
        Console.WriteLine("1: New Game\n2: Load");
        string input = Console.ReadLine();

        switch (input)
        {
            case "1":
                //New Game Should be Called
                //Call NewPlayer In CC
                string[] tmp = charcterCreation.NewPlayer();
                break;
            case "2":
                //Load Should be Called But It Might Not Idk... JK
                //Danny Fanny Needs To Do Stuff Here
                Console.WriteLine("u did smthng 2");
                break;
            default:
                Console.WriteLine("Please input a valid number!");
                //	menuSeq();
                break;
        }

        // lord farquad is the good lorde
        //Iron Man Dies Shreak 4
        // ur mom is raped by ur pillowcase

    }
}

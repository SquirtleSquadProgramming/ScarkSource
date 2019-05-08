using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Scark.ast;

namespace Scark.ast.start
{
    class BoardShip
    {
        public string[] aboardShip(string[] charinf)
        {
            Console.WriteLine(@"                    |
                    |
             |    __-__
           __-__ /  | (
          /  | ((   | |
        /(   | ||___|_.  .|
      .' |___|_|`---|-'.' (
 '-._/_| (   |\     |.'    \
     '-._|.-.|-.    |'-.____'.
         |------------------'
          `-      Farquaad '
            `-------------'");

            wd("Days pass aboard the Farquaad.");
            wd("[LORD WAKEHART] Hey kid.");
            wd("[LORD WAKEHART] Not long 'til the Farquaad arrives at Scark.");
            wd("[LORD WAKEHART] She's gonna stay in the port for a lil' while as we restock.");
            wd("[LORD WAKEHART] Y'know what, go to the town not far from here, and go to the tarven called \"The Medallion\".");
            wd("[LORD WAKEHART] Talk to my friend Orpheus, he's the barman. He'll tell you some stuff you ought to know.");

            charinf[2] = "2"; // Continuing story
            return charinf;
        }

        public void wd(string text) // write dialogue and wait 1.5 s
        {
            if (!start.Menu.dev)
            {
                Console.WriteLine(text);
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine(text);
            }
        }
    }
}

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
        public void aboardShip()
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

            Character.wd("\nDays pass aboard the Farquaad.");
            Character.wd("[LORD WAKEHART] Hey kid.");
            Character.wd("[LORD WAKEHART] Not long 'til the Farquaad arrives at Scark.");
            Character.wd("[LORD WAKEHART] She's gonna stay in the port for a lil' while as we restock.");
            Character.wd("[LORD WAKEHART] Y'know what, go to the town called Narsk not far from here, and go to the tarven called \"The Medallion\".");
            Character.wd("[LORD WAKEHART] Talk to my friend Orpheus, he's the barman. He'll tell you some stuff you ought to know.");
            Character.wd("[LORD WAKEHART] Here's some ethryl to start you off.");
            Character.wd("Wakehart hands over a few coins radiating with a strange light.");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Character.wd(@"                ______________
    __,.,---'''''              '''''---..._
 ,-'             .....:::''::.:            '`-.
'           ...:::.....       '                .
            ''':::'''''       .                '
|'-.._           ''''':::..::':          __,,-'
 '-.._''`---.....______________.....---''__,,-'
      ''`---.....______________.....---''"); // <= this is a coin

            Character.revertColourScheme();
            Character.awardEthryl(25);

            Console.ReadLine();

            Character.stage++; // Continuing story
        }

        
    }
}

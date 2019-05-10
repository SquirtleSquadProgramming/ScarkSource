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

            Character.awardEthryl(25);

            Character.wd("[LORD WAKEHART] Wizards back in korambia granted me a few vials of this strange substance aswell."); //if there is a better town name by all means add it korambia is just a placeholder
            Character.wd("[LORD WAKEHART] I will give you some, you never know when it might come in handy.");
            Character.wd("You take a handful of the substance, and it seems to infuse into your skin.");

            Character.awardMagika(10);

            Character.wd("[LORD WAKEHART] I'll give you some, you never know when it might come in handy.");
            Character.wd("The once lapping waves run still. The farquaad enters the bay...");

            Console.ReadLine();

            Character.stage++; // Continuing story
        }

        
    }
}

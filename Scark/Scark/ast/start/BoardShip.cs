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

            wd("\nDays pass aboard the Farquaad.");
            wd("[LORD WAKEHART] Hey kid.");
            wd("[LORD WAKEHART] Not long 'til the Farquaad arrives at Scark.");
            wd("[LORD WAKEHART] She's gonna stay in the port for a lil' while as we restock.");
            wd("[LORD WAKEHART] Y'know what, go to the town not far from here, and go to the tarven called \"The Medallion\".");
            wd("[LORD WAKEHART] Talk to my friend Orpheus, he's the barman. He'll tell you some stuff you ought to know.");
            wd("[LORD WAKEHART] Here's some ethryl to start you off.");
            wd("Wakehart hands over a few coins radiating with a strange light.");
            

            Console.ReadLine();

            Character.stage++; // Continuing story
        }

        public void wd(string text) // write dialogue and wait 1.5 s
        {
            string filteredText = text;

            //profanitise if selected
            if (Character.Settings["Profanity"])
            {
                //replaces good boy words with their more profane counterparts
                filteredText = filteredText.Replace("hell", "fuck");
                filteredText = filteredText.Replace("flip", "fuck");
                filteredText = filteredText.Replace("darn", "damn");
                filteredText = filteredText.Replace("idiot", "cunt");
                filteredText = filteredText.Replace("bloody", "fucking");
            }
            Console.WriteLine("\n" + filteredText);
            if (!Character.dev)
            {
                // Console.Write("[DEV: {0}]", start.Menu.dev);
                Thread.Sleep(Character.Settings["SpeechSpeed"]);
            }
        }
    }
}

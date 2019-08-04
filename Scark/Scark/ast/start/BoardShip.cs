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
            if (Character.Settings["SpecialEffects"])
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
            }

            EOA.wd("\nThree days pass aboard the Farquaad.");
            EOA.wd("You are awoken from your sleep by the noise of the crew.");
            EOA.wd("Another smaller ship, about a quarter the size of the Farquaad pulls into the wharf beside the Farquaad.");
            EOA.wd("[LORD WAKEHART] Worry not, they are the local merchants.");
            EOA.wd("As the incoming ship berths beside the Farquaad, you see the name \"Thorul\" on the starboard side of the vessel.");
            EOA.wd("A man walks onto the top deck, facing Lord Wakehart.");
            EOA.wd("[THORUL] I am Thorul of Braedon.");
            EOA.wd("[THORUL] I present no harm, I have come to trade.");
            EOA.wd("[LORD WAKEHART] By my troth, I accept your presence.");
            EOA.wd("Thorul brings a rack of some of his merchandise out onto the deck.");
            EOA.wd("[THORUL] Take your pick, if you wish.");
            EOA.wd("[LORD WAKEHART] Oh my, could it be...?");
            EOA.wd("Wakehart reaches into the rack, and takes out a large bottle.");
            EOA.wd("[LORD WAKEHART] 43%, aged scotch!");
            EOA.wd("[LORD WAKEHART] For what do you wish to trade with?");
            EOA.wd("[THORUL] 25 Ethryl, for this was quite the doozy to get ahold of.");
            EOA.wd("Wakehart hands a bag over to Thorul, and leaves the deck grinning.");
            EOA.wd("Other crew members make their trades, and exit the deck.");
            EOA.wd("Thorul walks up to you.");
            EOA.wd("[THORUL] Is there anything you wish to purchase?");
            EOA.wd("[THORUL] How about this Scroll of Wisdom?");
            EOA.wd("[THORUL] It was gifted to me by a man over at Narsk.");
            EOA.wd("[THORUL] When chanted, the spell enchants you with wisdom and intelligence.");
            EOA.wd("[THORUL] Alas, it only works on humankind such as yourself, which is quite a shame for a dwarf like myself.");
            EOA.wd("[THORUL] I will give it to you if you polish my balmorals.");

            EOA.wd($"[1] I accept your trade.\n[2] I do not accept your trade.");

            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.D1:
                    EOA.wd("[THORUL] It is all yours.");
                    EOA.wd("You pick up the scroll, and it vanishes.");
                    EOA.wd("Your head tingles, and you feel more intelligent.");
                    EOA.wd("Your intelligence ability increases by one.");
                    Character.AbilityScores["intelligence"]++;
                    EOA.wd("You spend the rest of the day polishing Thorul's shoes before heading back inside to sleep.");
                    // wow those must be some massive shoes
                    EOA.wd("Thorul departed just after nightfall.");
                    break;
                case ConsoleKey.D2:
                default:
                    EOA.wd("[THORUL] That is alright.");
                    EOA.wd("[THORUL] Stay safe, my friend.");
                    EOA.wd("You go back inside to have an early nap.");
                    EOA.wd("Thorul and his crew departs the berth.");
                    break;
            }
            EOA.pressAnyKeyToContinue();

            EOA.wd("\nAnother week passes.");
            EOA.wd("[LORD WAKEHART] Hey kid.");
            EOA.wd("[LORD WAKEHART] Not long 'til the Farquaad arrives at Scark.");
            EOA.wd("[LORD WAKEHART] She's gonna stay in the port for a lil' while as we restock.");
            EOA.wd("[LORD WAKEHART] Y'know what, go to the town called Narsk not far from here, and go to the tarven called \"The Medallion\".");
            EOA.wd("[LORD WAKEHART] Talk to my friend Orpheus, he's the barman. He'll tell you some stuff you ought to know.");
            EOA.wd("[LORD WAKEHART] Also, if you didn't know already, ethryl is the currency of Scark.");
            EOA.wd("[LORD WAKEHART] Here's some of it to start you off.");
            EOA.wd("Wakehart hands over a few coins radiating with a strange light.");

            Character.awardEthryl(25);

            EOA.wd("[LORD WAKEHART] Wizards back in Braedon, on the West Coast granted me a few vials of this strange substance as well."); 
            EOA.wd("[LORD WAKEHART] I will give you some; you never know when it might come in handy.");
            EOA.wd("You take a handful of the substance, and it seems to infuse into your skin.");

            Character.addMagika(10);

            EOA.wd("The once lapping waves run still. The Farquaad enters the bay...");
            EOA.wd("[LORD WAKEHART] Make sure you come back by dusk!");

            EOA.pressAnyKeyToContinue();

            Character.stage++; // Continuing story
        }
    }
}

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

            Character.wd("\nThree days pass aboard the Farquaad.");
            Character.wd("You are awoken from your sleep by the noise of the crew.");
            Character.wd("Another smaller ship, about a quarter the size of the Farquaad pulls into the wharf beside the Farquaad.");
            Character.wd("[LORD WAKEHART] Worry not, they are the local merchants.");
            Character.wd("As the incoming ship berths beside the Farquaad, you see the name \"Thorul\" on the starboard side of the vessel.");
            Character.wd("A man walks onto the top deck, facing Lord Wakehart.");
            Character.wd("[THORUL] I am Thorul of Braedon.");
            Character.wd("[THORUL] I present no harm, I have come to trade.");
            Character.wd("[LORD WAKEHART] By my troth, I accept your presence.");
            Character.wd("Thorul brings a rack of some of his merchandise out onto the deck.");
            Character.wd("[THORUL] Take your pick, if you wish.");
            Character.wd("[LORD WAKEHART] Oh my, could it be...?");
            Character.wd("Wakehart reaches into the rack, and takes out a large bottle.");
            Character.wd("[LORD WAKEHART] 43%, aged scotch!");
            Character.wd("[LORD WAKEHART] For what do you wish to trade with?");
            Character.wd("[THORUL] 25 Ethryl, for this was quite the doozy to get ahold of.");
            Character.wd("Wakehart hands a bag over to Thorul, and leaves the deck grinning.");
            Character.wd("Other crew members make their trades, and exit the deck.");
            Character.wd("Thorul walks up to you.");
            Character.wd("[THORUL] Is there anything you wish to purchase?");
            Character.wd("[THORUL] How about this Scroll of Wisdom?");
            Character.wd("[THORUL] It was gifted to me by a man over at Narsk.");
            Character.wd("[THORUL] When chanted, the spell enchants you with wisdom and intelligence.");
            Character.wd("[THORUL] Alas, it only works on humankind such as yourself, which is quite a shame for a dwarf like myself.");
            Character.wd("[THORUL] I will give it to you if you polish my balmorals.");

            Character.wd($"[1] I accept your trade.\n[2] I do not accept your trade.");
            Console.Write("> ");
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    Character.wd("[THORUL] It is all yours.");
                    Character.wd("You pick up the scroll, and it vanishes.");
                    Character.wd("Your head tingles, and you feel more intelligent.");
                    Character.wd("Your intelligence ability increases by one.");
                    Character.AbilityScores["intelligence"]++;
                    Character.wd("You spend the rest of the day polishing Thorul's shoes before heading back inside to sleep.");
                    // wow those must be some massive shoes
                    Character.wd("Thorul departed just after nightfall.");
                    break;
                case "2":
                default:
                    Character.wd("[THORUL] That is alright.");
                    Character.wd("[THORUL] Stay safe, friend.");
                    Character.wd("You go back inside to have an early nap.");
                    Character.wd("Thorul and his crew departs the berth.");
                    break;
            }
            Character.pressAnyKeyToContinue();

            Character.wd("\nAnother week passes.");
            Character.wd("[LORD WAKEHART] Hey kid.");
            Character.wd("[LORD WAKEHART] Not long 'til the Farquaad arrives at Scark.");
            Character.wd("[LORD WAKEHART] She's gonna stay in the port for a lil' while as we restock.");
            Character.wd("[LORD WAKEHART] Y'know what, go to the town called Narsk not far from here, and go to the tarven called \"The Medallion\".");
            Character.wd("[LORD WAKEHART] Talk to my friend Orpheus, he's the barman. He'll tell you some stuff you ought to know.");
            Character.wd("[LORD WAKEHART] Also, if you didn't know already, ethryl is the currency of Scark.");
            Character.wd("[LORD WAKEHART] Here's some of it to start you off.");
            Character.wd("Wakehart hands over a few coins radiating with a strange light.");

            Character.awardEthryl(25);

            Character.wd("[LORD WAKEHART] Wizards back in Braedon, on the West Coast granted me a few vials of this strange substance as well."); 
            Character.wd("[LORD WAKEHART] I will give you some; you never know when it might come in handy.");
            Character.wd("You take a handful of the substance, and it seems to infuse into your skin.");

            Character.addMagika(10);

            Character.wd("The once lapping waves run still. The Farquaad enters the bay...");
            Character.wd("[LORD WAKEHART] Make sure you come back by dusk!");

            Character.pressAnyKeyToContinue();

            Character.stage++; // Continuing story
        }
    }
}

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
        Random rand = new Random();
        int result = rand.Next(1,3);
        bool boughtProstitute = false;
        bool savedProstitute = false;


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
            

            if (result == 13) // temp
            {
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

                EOA.wd($"[1] I accept your trade.\n[2] I do not accept your trade.\n> ");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        EOA.wd("\n[THORUL] It is all yours.");
                        EOA.wd("You pick up the scroll, and it vanishes.");
                        EOA.wd("Your head tingles, and you feel more intelligent.");
                        EOA.wd("Your intelligence ability increases by one.");
                        Character.AbilityScores["intelligence"]++;
                        EOA.wd("You spend the rest of the day polishing Thorul's shoes before heading back inside to sleep.");
                        // wow those must be some massive shoes
                        EOA.wd("Thorul departed just after nightfall.");
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    default:
                        EOA.wd("\n[THORUL] That is alright.");
                        EOA.wd("[THORUL] Stay safe, my friend.");
                        EOA.wd("You go back inside to have an early nap.");
                        EOA.wd("Thorul and his crew departs the berth.");
                        break;
                }
                EOA.pressAnyKeyToContinue();
            }
            else if (result == 2 || result == 1) // temp
            {
                EOA.wd("\nThree days pass aboard the Farquaad.");
                EOA.wd("You are awoken from your sleep by the noise of the crew.");
                EOA.wd("Another smaller ship, about a quarter the size of the Farquaad pulls into the wharf beside the Farquaad.");
                EOA.wd("[LORD WAKEHART] Worry not, they are the local... ah... \"pleasure dealers\".");
                EOA.wd("As the incoming ship berths beside the Farquaad, you see the name \"The Pleasurer\" on the starboard side of the vessel.");
                EOA.wd("A man walks onto the top deck, facing Lord Wakehart.");
                EOA.wd("Following the man is a line of five gagged women, each with a tough-looking man holding their arms.");
                EOA.wd("[THORUL] I am Thorul of Braedon.");
                EOA.wd("[THORUL] I present no harm, I have come to sell my... \"goods\".");
                EOA.wd("[LORD WAKEHART] By my troth, I accept your presence.");
                EOA.wd("Thorul shows the women to Lord Wakehart, you and the crew of the Farquaad.");
                EOA.wd("[THORUL] Take your pick, if you wish!");
                EOA.wd("At once, two of the Farquaad's crew raise their hands and point at a woman each. Thorul approaches them and the crew give them a few Ethryl coins.");
                EOA.wd("After scrutinising the remaining three women, Lord Wakehart does the same and pays Thorul some money.");
                EOA.wd("Now, Thorul approaches you.");
                EOA.wd("[THORUL] So, kid. Wanna buy one? 20 ethryl for one night.");
                EOA.wd("[1] I wish to buy one.\n[2] I refuse to buy one.");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        EOA.wd("You look in your wallet and realise that you have no money.");
                        EOA.wd("\n[THORUL] Don't worry. Since it's your first time, you can have it for free.");
                        EOA.wd("\n[THORUL] It is all yours. I'll come back for it tomorrow!");
                        EOA.wd("You and the woman go to your cabin.");
                        EOA.wd("Thorul departed shortly later.");
                        boughtProstitute = true;
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                    default:
                        EOA.wd("\n[THORUL] That is alright.");
                        EOA.wd("[THORUL] Stay safe, my friend.");
                        EOA.wd("You go back inside to have an early nap.");
                        EOA.wd("Thorul and his crew departs the berth.");
                        break;
                }

                if (boughtProstitute) 
                {
                    EOA.wd("Inside your cabin, the woman whimpers slightly.");
                    EOA.wd("[PROSTITUTE] Please... help me! Let me free!");
                    EOA.wd("[1] You help the woman.\n[2] You ignore her pleads.");

                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            EOA.wd("You sneak the woman out of the ship and into the town.");
                            EOA.wd("[PROSTITUTE] How can I ever thank you?");
                            EOA.wd("[PROSTITUTE] Here, have some ethryl; it's the least I can do...");

                            Character.awardEthryl(69);
                            savedProstitute = true;
                            break;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                        default:
                            EOA.wd("The woman sighs.");
                            EOA.wd("[PROSTITUTE] I understand.");
                            EOA.wd("She takes off her clothes, and you do the same.");
                            EOA.wd(". . .");
                            break;

                    }
                }
            }

            EOA.wd("The following day, Thorul returns to the ship.");
            EOA.wd("[THORUL] May I have them, please?");
            EOA.wd("The crew and captain hand over their women. The prostitutes all look tired and uncomfortable.");
            if (!savedProstitute)
            {
                EOA.wd("You hand in your woman.");
                EOA.wd("[THORUL] Thank you all!");
            }
            else
            { 
                EOA.wd("[THORUL] Where's yours?");
                EOA.wd("You explain that your woman is gone.");
                if (Character.rollCheck("charisma", 18))
                {
                    EOA.wd("[THORUL] I see.");
                    EOA.wd("[THORUL] That's a shame, it was one of our best.");
                    EOA.wd("Your charisma saved you.");
                }
                else
                {
                    EOA.wd("[THORUL] I don't believe your stupid little mouth, kid.");
                    EOA.wd("[THORUL] WHERE THE FUCK IS IT?");
                    EOA.wd("You continue to pretend that you do not know.");
                    EOA.wd("Thorul punches you in the face.");
                    EOA.subtractHealth(5);
                    EOA.wd("[THORUL] Fuck you!");
                }
            }

            EOA.wd("\nAnother week passes.");
            EOA.wd("[LORD WAKEHART] Hey kid.");
            EOA.wd("[LORD WAKEHART] Not long 'til the Farquaad arrives at Sārk.");
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

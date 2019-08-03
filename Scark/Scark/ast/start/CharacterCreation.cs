using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Scark.ast;
using Scark.ast.items;
using Scark.ast.items.weapons;
using Scark.ast.items.general;

namespace Scark.ast.start
{
    public class CC
    {
        SettingsMenu sm = new SettingsMenu();

        //NewPlayer function
        public void NewPlayer()
        {
            //Story Line
            EOA.wd("You carefully aim your crossbow directly at the King's chest.");
                
            EOA.wd("A bloodstained crossbow loaded with a lead bolt sits in your \nsweaty hand as you observe the speech from a ramshackle building.");

            EOA.wd("Your finger pulls the trigger.");
                
            EOA.wd("You hear an instant uproar as the King's body topples down the \nstone stairs.");
                
            EOA.wd("In the midst of all the confusion, you begin running.");
                
            EOA.wd("Suddenly, a baton bludgeons you from behind.");
            if (!Character.dev)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Thread.Sleep(3000);
            }

            EOA.wd("You wake up in a mysterious place and realize where you are...");
                
            EOA.wd("You have been arrested for treason to the king. You are walked up \nto the gallows to which you will be executed.");
                
            EOA.wd("The executioner firms his grasp around the lever. Before he pulls \nthe lever he mumbles a quick prayer.");
               
            EOA.wd("[EXECUTIONER] Does anybody object to this her' hanging?");
                
            EOA.wd("Nothing but silence comes from the crowd.");

            EOA.wd("[TOWNFOLK] Just bloody pull the lever already!");

            EOA.wd("As the executioner moves his hand towards the lever, a voice shouts \nout.");
                
            EOA.wd("[VOICE] I object!");
                
            EOA.wd("The executioner's eyes fix upon the man who called.");
                
            EOA.wd("[EXECUTIONER] Arr, an' who d'ya think you ar'?");
                
            EOA.wd("[VOICE] Lord Wakehart, the explorer.");
                
            EOA.wd("[LORD WAKEHART] I wish to pardon this kid.");
                
            EOA.wd("The executioner has no choice but to obey the laws, Wakehart's lordship \ngrants him power to pardon anyone he wishes.");
                
            EOA.wd("The rope is loosened around your neck as you are escorted into the \ndisappointed audience by Lord Wakehart.");

            EOA.wd("[LORD WAKEHART] Hey kid, what's your name?");

            EOA.wd("> ", true);

            Character.name = Console.ReadLine();

            Character.awardXP(10);

            EOA.wd($"[LORD WAKEHART] Hey, {Character.name}. Don't think I'm pardoning \nyou for nothing, nah.");
                
            EOA.wd("[LORD WAKEHART] I've a quest for you, and if you succeed, you'll be \na very rich man.");
                
            EOA.wd("[LORD WAKEHART] Ha ha, I'm guessing you want to know what this quest \ninvolves!");
                
            EOA.wd("[LORD WAKEHART] Well, I need a brave adventurer to go to the island \nof Scark.");
                
            EOA.wd("[LORD WAKEHART] I'll tell you more when we get there, kid.");
                
            EOA.wd("Before you can say anything, you are rushed off to a training fort...");

            Console.Clear();

            //Training Fort
            
            EOA.wd("[TRAINER] So.");
            EOA.wd("[TRAINER] I see that the idiot Wakehead or whatever the hell his name \nis has pardoned you.");
            EOA.wd("[TRAINER] Well, I guess I'll have to obey.");
            EOA.wd("[TRAINER] So kid, how'll your flimsy little limbs fight, eh?");
            EOA.wd("[TRAINER] Don't know what I'm talking about?");
            EOA.wd("[TRAINER] Not surprised, from some wanna-be revolutionist like yourself.");
            EOA.wd("[TRAINER] Forgive me, but your attempt on the glorious King's life was \nfutile at best.");
            EOA.wd("[TRAINER] At worst?");
            EOA.wd("[TRAINER] Ha ha ha ha.");
            EOA.wd("[TRAINER] Well anyways, I can train you in four classes.");
            EOA.wd("[TRAINER] Rouge, warrior, ranger or mage.");

            Console.WriteLine(@"The trainer asks you how you would like to fight.

Select a role by inputting it's respective number.
[1] Rouge
[2] Warrior
[3] Ranger
[4] Mage");

            bool userPickedOption = false;
            while (userPickedOption == false)
            {
                Console.Write("> ");

                Character.characterClass = Console.ReadLine().Substring(0, 1);
                switch (Character.characterClass)
                {
                    case "1": // Rouge
                        Character.characterClass = "Rouge";
                        Character.inventory.Add(ItemID.StringToItem("Iron Shortsword"));
                        Character.inventory.Add(IronShortsword.ToItem());
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        EOA.pressAnyKeyToContinue();

                        assignAbilityScoreIntro();
                        break;
                    case "2": // Warrior
                        Character.characterClass = "Warrior";
                        Character.inventory.Add(ItemID.StringToItem("Iron Broadsword"));
                        Character.inventory.Add(IronBroadsword.ToItem());
                        userPickedOption = true;
                        Thread.Sleep(1500);

                        EOA.pressAnyKeyToContinue();

                        assignAbilityScoreIntro();
                        break;
                    case "3": // Ranger
                        Character.characterClass = "Ranger";
                        Character.inventory.Add(ItemID.StringToItem("Iron Bow"));
                        Character.inventory.Add(ItemID.StringToItem("Leather Quiver"));
                        Character.inventory.Add(IronBow.ToItem());
                        Character.inventory.Add(LeatherQuiver.ToItem());
                        userPickedOption = true;
                        Thread.Sleep(1500);

                        EOA.pressAnyKeyToContinue();

                        assignAbilityScoreIntro();
                        break;
                    case "4": // Mage
                        Character.characterClass = "Mage";
                        Character.inventory.Add(ItemID.StringToItem("Book of Souls"));
                        Character.inventory.Add(BookOfSouls.ToItem());
                        userPickedOption = true;
                        Thread.Sleep(1500);

                        EOA.pressAnyKeyToContinue();

                        assignAbilityScoreIntro();
                        break;

                    default:
                        Console.WriteLine("Please input a valid number between 1 and 4!");
                        break;
                }
            }

            //Sean Write Some More Story
            Character.stage++;
        }

        public void assignAbilityScoreIntro()
        {
            EOA.wd("[TRAINER] Hey, don't start packing yet.");
            EOA.wd("[TRAINER] You need to choose some ability scores as well.");
            EOA.wd("[TRAINER] They determine how good you are at certain things.");
            EOA.wd("[TRAINER] There are six ability scores; Constitution, Charisma, Intelligence, Perception, Strength and Stealth.");
            EOA.wd("[TRAINER] You get 25 Ability Points to spend on these scores at the start.");
            Character.awardAbilityPoint(25);
            EOA.wd("[TRAINER] You can get more points by leveling up, or doing certain quests.");
            EOA.wd("[TRAINER] Your skills will start out bad, but as you progress, you'll get better and better.");

            EOA.pressAnyKeyToContinue();

            Character.chooseAbilityScorePoints();
        }
    }
}

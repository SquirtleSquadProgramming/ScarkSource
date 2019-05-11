using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Scark.ast;

namespace Scark.ast.start
{
    public class CC
    {
        SettingsMenu sm = new SettingsMenu();

        //NewPlayer function
        public void NewPlayer()
        {

            //Story Line
            Character.wd("You carefully aim your crossbow directly at the King's chest.");

            Character.showCharInfoGUI();
                
            Character.wd("A bloodstained crossbow loaded with a lead bolt sits in your \nsweaty hand as you observe the speech from a ramshackle building.");

            Character.wd("Your finger pulls the trigger.");
                
            Character.wd("You hear an instant uproar as the King's body topples down the \nstone stairs.");
                
            Character.wd("In the midst of all the confusion, you begin running.");
                
            Character.wd("Suddenly, a baton bludgeons you from behind.");
            if (!Character.dev)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Thread.Sleep(3000);
            }

            Character.wd("You wake up in a mysterious place and realize where you are...");
                
            Character.wd("You have been arrested for treason to the king. You are walked up \nto the gallows to which you will be executed.");
                
            Character.wd("The executioner firms his grasp around the lever. Before he pulls \nthe lever he mumbles a quick prayer.");
               
            Character.wd("[EXECUTIONER] Does anybody object to this her' hanging?");
                
            Character.wd("Nothing but silence comes from the crowd.");

            Character.wd("[TOWNFOLK] Just bloody pull the lever already!");

            Character.wd("As the executioner moves his hand towards the lever, a voice shouts \nout.");
                
            Character.wd("[VOICE] I object!");
                
            Character.wd("The executioner's eyes fix upon the man who called.");
                
            Character.wd("[EXECUTIONER] Arr, an' who d'ya think you ar'?");
                
            Character.wd("[VOICE] Lord Wakehart, the explorer.");
                
            Character.wd("[LORD WAKEHART] I wish to pardon this kid.");
                
            Character.wd("The executioner has no choice but to obey the laws, Wakehart's lordship \ngrants him power to pardon anyone he wishes.");
                
            Character.wd("The rope is loosened around your neck as you are escorted into the \ndisappointed audience by Lord Wakehart.");
                

            Character.wd("[LORD WAKEHART] Hey kid, what's your name?");
            Console.Write("> ");
            Character.name = Console.ReadLine();

            Character.awardXP(10);

            Character.wd($"[LORD WAKEHART] Hey, {Character.name}. Don't think I'm pardoning \nyou for nothing, nah.");
                
            Character.wd("[LORD WAKEHART] I've a quest for you, and if you succeed, you'll be \na very rich man.");
                
            Character.wd("[LORD WAKEHART] Ha ha, I'm guessing you want to know what this quest \ninvolves!");
                
            Character.wd("[LORD WAKEHART] Well, I need a brave adventurer to go to the island \nof Scark.");
                
            Character.wd("[LORD WAKEHART] I'll tell you more when we get there, kid.");
                
            Character.wd("Before you can say anything, you are rushed off to a training fort...");

            Console.Clear();

            //Training Fort
            
            Character.wd("[TRAINER] So.");
            Character.wd("[TRAINER] I see that the idiot Wakehead or whatever the hell his name \nis has pardoned you.");
            Character.wd("[TRAINER] Well, I guess I'll have to obey.");
            Character.wd("[TRAINER] So kid, how'll your flimsy little limbs fight, eh?");
            Character.wd("[TRAINER] Don't know what I'm talking about?");
            Character.wd("[TRAINER] Not surprised, from some wanna-be revolutionist like yourself.");
            Character.wd("[TRAINER] Forgive me, but your attempt on the glorious King's life was \nfutile at best.");
            Character.wd("[TRAINER] At worst?");
            Character.wd("[TRAINER] Ha ha ha ha.");
            Character.wd("[TRAINER] Well anyways, I can train you in four classes.");
            Character.wd("[TRAINER] Rouge, warrior, ranger or mage.");

            Console.WriteLine(
                "\nThe trainer asks you how you like to fight \n" +
                "[1] Rouge\n[2] Warrior\n[3] Ranger\n[4] Mage\n" +
                "Please select a role by inputting a number\n");

            bool userPickedOption = false;
            while (userPickedOption == false)
            {
                Console.Write("> ");
                Character.characterClass = Console.ReadLine();
                switch (Character.characterClass)
                {
                    case "1": // Rouge
                        Character.characterClass = "Rouge";
                        Character.inventory.Add(ItemID.ConvertStringToID("Iron Shortsword"));
                        userPickedOption = true;
                        Thread.Sleep(1500);

                        Character.pressAnyKeyToContinue();

                        assignAbilityScoreIntro();
                        break;
                    case "2": // Warrior
                        Character.characterClass = "Warrior";
                        Character.inventory.Add(ItemID.ConvertStringToID("Iron Broadsword"));
                        userPickedOption = true;
                        Thread.Sleep(1500);

                        Character.pressAnyKeyToContinue();

                        assignAbilityScoreIntro();
                        break;
                    case "3": // Ranger
                        Character.characterClass = "Ranger";
                        Character.inventory.Add(ItemID.ConvertStringToID("Iron Bow"));
                        Character.inventory.Add(ItemID.ConvertStringToID("Leather Quiver"));
                        userPickedOption = true;
                        Thread.Sleep(1500);

                        Character.pressAnyKeyToContinue();
                        Console.Clear();

                        assignAbilityScoreIntro();
                        break;
                    case "4": // Mage
                        Character.characterClass = "Mage";
                        Character.inventory.Add(ItemID.ConvertStringToID("Book of Souls"));
                        userPickedOption = true;
                        Thread.Sleep(1500);

                        Character.pressAnyKeyToContinue();

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
            Character.wd("[TRAINER] Oh, I almost forgot.");
            Character.wd("[TRAINER] You need to choose some ability scores as well.");
            Character.wd("[TRAINER] They determine how good you are at certain things.");
            Character.wd("[TRAINER] There are six ability scores; Constitution, Charisma, Intelligence, Perception, Strength and Stealth.");
            Character.wd("[TRAINER] You get 25 Ability Points to spend on these scores at the start.");
            Character.awardAbilityPoint(25);
            Character.wd("[TRAINER] You can get more points by leveling up, or doing certain quests.");
            Character.wd("[TRAINER] Your skills will start out bad, but as you progress, you'll get better and better.");

            Character.pressAnyKeyToContinue();

            Character.chooseAbilityScorePoints();

        }
    }
}

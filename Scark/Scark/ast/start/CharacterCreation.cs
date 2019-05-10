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
                
            Character.wd("A bloodstained crossbow loaded with a lead bolt sits in your sweaty hand as you observe the speech from a ramshackle building.");

            Character.wd("Your finger pulls the trigger.");
                
            Character.wd("You hear an instant uproar as the King's body topples down the stone stairs.");
                
            Character.wd("In the midst of all the confusion, you begin running.");
                
            Character.wd("Suddenly, a baton bludgeons you from behind.");
            if (!Character.dev)
            {
                Thread.Sleep(2000);
                Console.Clear();
                Thread.Sleep(3000);
            }

            Character.wd("You wake up in a mysterious place and realize where you are...");
                
            Character.wd("You have been arrested for treason to the king. You are walked up to the gallows to which you will be executed.");
                
            Character.wd("The executioner firms his grasp around the lever. Before he pulls the lever he mumbles a quick prayer.");
               
            Character.wd("[EXECUTIONER] Does anybody object to this her' hanging?");
                
            Character.wd("Nothing but silence comes from the crowd.");

            Character.wd("[TOWNFOLK] Just bloody pull the lever already!");

            Character.wd("As the executioner moves his hand towards the lever, a voice shouts out.");
                
            Character.wd("[VOICE] I object!");
                
            Character.wd("The executioner's eyes fix upon the man who called.");
                
            Character.wd("[EXECUTIONER] Arr, an' who d'ya think you ar'?");
                
            Character.wd("[VOICE] Lord Wakehart, the explorer.");
                
            Character.wd("[LORD WAKEHART] I wish to pardon this kid.");
                
            Character.wd("The executioner has no choice but to obey the laws, Wakehart's lordship grants him power to pardon anyone he wishes.");
                
            Character.wd("The rope is loosened around your neck as you are escorted into the disappointed audience by Lord Wakehart.");
                

            Character.wd("[LORD WAKEHART] Hey kid, what's your name?");
            Console.Write("> ");
            Character.name = Console.ReadLine();
            
            Character.wd($"[LORD WAKEHART] Hey, {Character.name}. Don't think I'm pardoning you for nothing, nah.");
                
            Character.wd("[LORD WAKEHART] I've a quest for you, and if you succeed, you'll be a very rich man.");
                
            Character.wd("[LORD WAKEHART] Ha ha, I'm guessing you want to know what this quest involves!");
                
            Character.wd("[LORD WAKEHART] Well, I need a brave adventurer to go to the island of Scark.");
                
            Character.wd("[LORD WAKEHART] I'll tell you more when we get there, kid.");
                
            Character.wd("Before you can say anything, you are rushed off to a training fort...");

            Console.Clear();

            //Training Fort
            

            Character.wd("[TRAINER] So.");
            Character.wd("[TRAINER] I see that the idiot Wakehead or whatever the hell his name is has pardoned you.");
            Character.wd("[TRAINER] Well, I guess I'll have to obey.");
            Character.wd("[TRAINER] So kid, how'll your flimsy little limbs fight, eh?");
            Character.wd("[TRAINER] Don't know what I'm talking about?");
            Character.wd("[TRAINER] Not surprised, from some wanna-be revolutionist like yourself.");
            Character.wd("[TRAINER] Forgive me, but your attempt on the glorious King's life was futile at best.");
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
                Character.race = Console.ReadLine();
                switch (Character.race)
                {
                    case "1": // Rouge
                        Character.race = "Rouge";
                        Character.inventory.Add(ItemID.ConvertStringToID("Iron Shortsword"));

                        Console.WriteLine("You are trained in basic Stealth and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        break;
                    case "2": // Warrior
                        Character.race = "Warrior";
                        Console.WriteLine("You are trained in basic Combat and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        break;
                    case "3": // Ranger
                        Character.race = "Ranger";
                        Console.WriteLine("You are trained in basic Archery and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        break;
                    case "4": // Mage
                        Character.race = "Mage";
                        Console.WriteLine("You are trained in basic Magery and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        Thread.Sleep(1500);
                        break;

                    default:
                        Console.WriteLine("Please input a valid number between 1 and 4!");
                        break;
                }
            }

            //Sean Write Some More Story
            Character.stage++;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Scark.ast.start
{
    public class CC
    {
        //NewPlayer function
        public string[] NewPlayer(bool dev)
        {
            //declare The New T's And C's Of The New Player
            string[] CharacterInfo = new string[3];

            Console.Clear();



            if (!dev) // TEMPORARY: If user is dev then skip story lines
            {
                //Story Line
                wd("\nYou carefully aim your crossbow directly at the King's chest.");
                
                wd("\nA bloodstained crossbow loaded with a lead bolt sits in your sweaty hand as you observe the speech from a ramshackle building.");

                wd("\nYour finger pulls the trigger.");
                
                wd("\nYou hear an instant uproar as the King's body topples down the stone stairs.");
                
                wd("\nIn the midst of all the confusion, you begin running.");
                
                wd("\nSuddenly, a baton bludgeons you from behind.");
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(10000);

                wd("You wake up in a mysterious place and realize where you are...");
                
                wd("You have been arrested for treason to the king. You are walked up to the gallows to which you will be executed.");
                
                wd("\nThe executioner firms his grasp around the lever. Before he pulls the lever he mumbles a quick prayer.");
                
                wd("\n[EXECUTIONER] Does anybody object to this her' hanging?");
                
                wd("\nSilence.");
                
                wd("\nAs the executioner moves his hand towards the lever, a voice shouts out.");
                
                wd("\n[VOICE] I object!");
                
                wd("\nThe executioner's eyes fix upon the man who called.");
                
                wd("\n[EXECUTIONER] Arr, an' who d'ya think you ar'?");
                
                wd("\n[VOICE] Lord Wakehart, the explorer.");
                
                wd("\n[LORD WAKEHART] I wish to pardon this kid.");
                
                wd("\nThe executioner has no choice but to obey the laws, Wakehart's lordship grants him power to pardon anyone he wishes.");
                
                wd("\nThe rope is loosened around your neck as you are escorted into the disappointed audience by Lord Wakehart.");
                
            }

            wd("[LORD WAKEHART] Hey kid, what's your name?");
            Console.Write("> "); // !!! MAKE SURE TO ADD THIS TO ANYTHING W/ USER INPUT
            CharacterInfo[0] = Console.ReadLine();

            if (!dev) // TEMPORARY: If user is dev then skip story lines
            {
                wd($"[LORD WAKEHART] Hey, {CharacterInfo[0]}. Don't think I'm pardoning you for nothing, nah.");
                
                wd("\n[LORD WAKEHART] I've a quest for you, and if you succeed, you'll be a very rich man.");
                
                wd("\n[LORD WAKEHART] Ha ha, I'm guessing you want to know what this quest involves!");
                
                wd("\n[LORD WAKEHART] Well, I need a brave adventurer to go to the island of Scark.");
                
                wd("\n[LORD WAKEHART] I'll tell you more when we get there, kid.");
                
                wd("Before you can say anything, you are rushed off to a training fort...");
                
            }

            //Training Fort
            Console.WriteLine("The trainer asks you how you like to fight \n[1] Rouge\n[2] Warrior\n[3] Ranger\n[4] Mage");
            Console.WriteLine("Please select a role by inputting a number");


            bool userPickedOption = false;
            while (userPickedOption == false)
            {
                Console.Write("> ");
                CharacterInfo[1] = Console.ReadLine();
                switch (CharacterInfo[1])
                {
                    case "1": //Rouge
                        CharacterInfo[1] = "Rouge";
                        Console.WriteLine("You are trained in basic Stealth and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        break;
                    case "2": //Warrior
                        CharacterInfo[1] = "Warrior";
                        Console.WriteLine("You are trained in basic Combat and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        break;
                    case "3": //Ranger
                        CharacterInfo[1] = "Ranger";
                        Console.WriteLine("You are trained in basic Archery and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        break;
                    case "4": //Mage
                        CharacterInfo[1] = "Mage";
                        Console.WriteLine("You are trained in basic Magery and shipped to the distant land of Scark...");
                        userPickedOption = true;
                        break;

                    default:
                        Console.WriteLine("Please input a valid number between 1 and 4!");
                        break;
                }
            }

            //Sean Write Some More Story
            CharacterInfo[2] = "1";
            return CharacterInfo;
        }

        public void wd(string text) // write dialogue and wait 1.5 s
        {
            Console.WriteLine(text);
            Thread.Sleep(1500);
        }
    }
}

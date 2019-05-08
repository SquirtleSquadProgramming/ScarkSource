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
            string[] CharacterInfo = new string[2];

            Console.Clear();



            if (!dev) // TEMPORARY: If user is dev then skip story lines
            {
                //Story Line
                Console.WriteLine("\nYou carefully aim your crossbow directly at the King's chest.");
                Thread.Sleep(1500);
                Console.WriteLine("\nA bloodstained crossbow loaded with a lead bolt sits in your sweaty hand as you observe the speech from a ramshackle building.");
                Thread.Sleep(5000);
                Console.WriteLine("\nYour finger pulls the trigger.");
                Thread.Sleep(1500);
                Console.WriteLine("\nYou hear an instant uproar as the King's body topples down the stone stairs.");
                Thread.Sleep(1500);
                Console.WriteLine("\nIn the midst of all the confusion, you begin running.");
                Thread.Sleep(1500);
                Console.WriteLine("\nSuddenly, a baton bludgeons you from behind.");
                Thread.Sleep(3000);
                Console.Clear();
                Thread.Sleep(10000);

                Console.WriteLine("You wake up in a mysterious place and realize where you are...");
                Thread.Sleep(1500)
                Console.WriteLine("You have been arrested for treason to the king. You are walked up to the gallows to which you will be executed.");
                Thread.Sleep(1500);
                Console.WriteLine("\nThe executioner firms his grasp around the lever. Before he pulls the lever he mumbles a quick prayer.");
                Thread.Sleep(1500);
                Console.WriteLine("\n[Executioner] Does anybody objects to the hanging?");
                Thread.Sleep(1500);
                Console.WriteLine("\nSilence.");
                Thread.Sleep(1500);
                Console.WriteLine("\nAs the executioner moves his hand towards the lever, a voice shouts out.");
                Thread.Sleep(1500);
                Console.WriteLine("\n[VOICE] I object!");
                Thread.Sleep(1500);
                Console.WriteLine("\nThe executioner's eyes fix upon the man who called.");
                Thread.Sleep(1500);
                Console.WriteLine("\n[EXECUTIONER] Ar, an' who d'ya think you are?");
                Thread.Sleep(1500);
                Console.WriteLine("\n[VOICE] Lord Wakehart, the explorer.");
                Thread.Sleep(1500);
                Console.WriteLine("\n[LORD WAKEHART] I wish to pardon this kid.");
                Thread.Sleep(1500);
                Console.WriteLine("\nThe executioner has no choice but to obey the laws, Wakehart's lordship grants him power to pardon anyone he wishes.");
                Thread.Sleep(1500);
                Console.WriteLine("\nThe rope is loosened around your neck as you are escorted into the disappointed audience by Lord Wakehart.");
                Thread.Sleep(1500);
            }

            Console.WriteLine("[LORD WAKEHART] Hey kid, what's your name?");
            Console.Write("> "); // !!! MAKE SURE TO ADD THIS TO ANYTHING W/ USER INPUT
            CharacterInfo[0] = Console.ReadLine();

            if (!dev) // TEMPORARY: If user is dev then skip story lines
            {
                Console.WriteLine($"[LORD WAKEHART] Hey, {CharacterInfo[0]}. Don't think I'm pardoning you for nothing, nah.");
                Thread.Sleep(1500);
                Console.WriteLine("\n[LORD WAKEHART] I've a quest for you, and if you succeed, you'll be a very rich man.");
                Thread.Sleep(1500);
                Console.WriteLine("\n[LORD WAKEHART] Ha ha, I'm guessing you want to know what this quest involves!");
                Thread.Sleep(1500);
                Console.WriteLine("\n[LORD WAKEHART] Well, I need a brave adventurer to go to the island of Scark.");
                Thread.Sleep(1500);
                Console.WriteLine("\n[LORD WAKEHART] I'll tell you more when we get there, kid.");
                Thread.Sleep(1500);
                Console.WriteLine("Before you can say anything, you are rushed off to a training fort...");
                Thread.Sleep(1500);
            }

            //Training Fort
            Console.WriteLine("The trainer asks you how you like to fight \n[1] Rouge\n[2] Warrior\n[3] Ranger\n[4] Mage");
            Console.WriteLine("Please select a role by inputting a number");
            Console.Write("> ");


            //Add Class Options Here
            CharacterInfo[1] = Console.ReadLine();

            switch (CharacterInfo[1])
            {
                case "1": //Rouge
                    Console.WriteLine("You are trained in basic Stealth and shipped to the distant land of scark...");
                    CharacterInfo[1] = "Rouge";
                    break;
                case "2": //Warrior
                    CharacterInfo[1] = "Warrior";
                    Console.WriteLine("You are trained in basic Combat and shipped to the distant land of scark...");
                    break;
                case "3": //Ranger
                    CharacterInfo[1] = "Ranger";
                    Console.WriteLine("You are trained in basic Archery and shipped to the distant land of scark...");
                    break;
                case "4": //Mage
                    CharacterInfo[1] = "Mage";
                    Console.WriteLine("You are trained in basic Magery and shipped to the distant land of scark...");
                    break;
                default:
                    Console.WriteLine("Please input a valid number between 1 and 4!");
                    break;
            }
            //Sean Write Some More Story
            return CharacterInfo;
        }
    }
}

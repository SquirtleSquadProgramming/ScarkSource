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
                Console.WriteLine("You have been arrested for treason to the king. You are walked up to the gallows to which you will be executed.");
                Thread.Sleep(3000);
                Console.WriteLine("The executioner firms his grasp around the lever. Before he pulls the lever he mumbles a quick prayer.");
                Thread.Sleep(3000);
                Console.WriteLine("The executioner asks if anybody objects. Suddenly legendary explorer Lord Wakehart says that you could be of service.");
                Thread.Sleep(3000);
                Console.WriteLine("His lordship allows him to pardon anybody he wishes.");
                Thread.Sleep(3000);
            }

            Console.WriteLine("He asks you what's your name?");
            CharacterInfo[0] = Console.ReadLine();

            if (!dev) // TEMPORARY: If user is dev then skip story lines
            {
                Console.WriteLine("Then tells you that he desperately needs an explorer to go to the island of scark.");
                Thread.Sleep(1000);
                Console.WriteLine("He promises you a fortune if you complete his quest.");
                Thread.Sleep(4000);
                Console.WriteLine("Before you can say anything you are rushed off to a training fort.");
                Thread.Sleep(3000);
            }

            //Training Fort
            Console.WriteLine("The trainer asks you how you like to fight \n(1) Rouge\n(2) Warrior\n(3) Ranger\n(4) Mage");
            Console.Write("Please select a role (number): ");

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
            }

            return CharacterInfo;
        }
    }
}

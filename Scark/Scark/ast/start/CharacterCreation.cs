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
        //Danny IDK if Static Is Ment To be here but i removed it because it gave me an error add if you can fix the error
        public string[] NewPlayer()
        {
            //declare The New T's And C's Of The New Player
            string[] CharacterInfo = new string[2];
            //name,Class
            Console.Clear();
            //Story Line
            Console.WriteLine("You have been arrested for treason to the king. You are walked up to the gallows to which you will be executed.");
            Thread.Sleep(4000);
            Console.WriteLine("The executioner firms his grasp around the lever. Before he pulls the lever he mumbles a quick prayer.");
            Thread.Sleep(4000);
            Console.WriteLine("The executioner asks if anybody objects when legendary explorer “Lord Wakehart” says that you could be of service to him.");
            Thread.Sleep(4000);
            Console.WriteLine("His lordship allows him to pardon anybody he wishes.");
            Thread.Sleep(4000);
            Console.WriteLine("He asks you what's your name?");
            CharacterInfo[0] = Console.ReadLine();
            Console.WriteLine("Then tells you that he desperately needs an explorer to go to the island of scark.\nHe promises you a fortune if you complete his quest.");
            Thread.Sleep(7000);
            Console.WriteLine("Before you can say anything you are rushed off to a training fort.");
            //Traing Fort
            Thread.Sleep(3000);
            Console.WriteLine("The trainer asks you how you like to fight \n1:Rouge\n2:Warrior\n3:Ranger\n4:Mage");
            //Add Class Options Here
            CharacterInfo[1] = Console.ReadLine();
            //put switch statement here

            switch (CharacterInfo[1])
            {
                case "1":
                    Console.WriteLine("you are trained in basic Stealth and shipped to scark.");
                    //Rouge
                    CharacterInfo[1] = "Rouge";
                    break;
                case "2":
                    CharacterInfo[1] = "Warrior";
                    Console.WriteLine("you are trained in basic Combat and shipped to scark.");
                    //Warrior
                    break;
                case "3":
                    CharacterInfo[1] = "Ranger";
                    Console.WriteLine("you are trained in basic Archery and shipped to scark.");
                    //Ranger
                    break;
                    CharacterInfo[1] = "Mage";
                case "4":
                    Console.WriteLine("you are trained in basic Magery and shipped to scark.");
                    //Mage
                    break;
            }
            //Sean Write Some More Story
            return CharacterInfo;
        }
    }
}

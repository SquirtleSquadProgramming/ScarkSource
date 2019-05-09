using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Scark.ast.start
{
    class SettingsMenu
    {
        public int dialogueSpeed = 2000;
        Menu menu = new Menu();

        public void run()
        {
            Console.Clear();

            Console.Write("Please select the setting you wish to edit.\n[1] Dialogue Speed\n\n[x] Exit\n> ");
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    editDialogueSpeedSetting();
                    break;
                case "x":
                case "X":
                    menu.menuSeq();
                    break;
                default:
                    Console.WriteLine("\nPlease enter a valid number!");
                    Thread.Sleep(dialogueSpeed);
                    break;
            }
        }

        public void editDialogueSpeedSetting()
        {
            Console.Clear();

            Console.Write("\nPlease enter the speed of dialogue in milliseconds (1000ms = 1s).\n> ");
            string response = Console.ReadLine();

            try
            {
                if (Convert.ToInt32(response) <= 5000)
                {
                    dialogueSpeed = Convert.ToInt32(response);

                    Console.WriteLine("\ntesting speed");
                    Thread.Sleep(dialogueSpeed);
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("testing speed");
                        Thread.Sleep(dialogueSpeed);
                    }
                    
                    run();
                }
                else
                {
                    Console.WriteLine("Please enter a value equal or less than 5000!");
                    Thread.Sleep(dialogueSpeed);
                    Console.Clear();
                    editDialogueSpeedSetting();
                }
            }
            catch
            {
                Console.WriteLine("Please enter a valid number!");
                
                Thread.Sleep(dialogueSpeed);
                Console.Clear();
                editDialogueSpeedSetting();
            }

        }
    }
}

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
        public static int dialogueSpeed = 2000;

        public static void run()
        {
            Console.WriteLine(@"Please select the setting you wish to edit.
[1] Dialogue Speed\n");
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    break;
                default:
                    Console.WriteLine("\nPlease enter a valid number!");
                    Thread.Sleep(dialogueSpeed);
                    break;
            }
        }
    }
}

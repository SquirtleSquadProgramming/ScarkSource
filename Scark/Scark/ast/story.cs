using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast;

namespace Scark.ast
{
    class story
    {
        public void Run(string[] charinf)
        {
            bool end = false;
            while (end == false)
            {
                switch (charinf[2])
                {
                    case "0": // Character Creation
                        Console.Clear();
                        start.CC cC = new start.CC();
                        charinf = cC.NewPlayer();
                        break;
                    case "1": // Aboarding Ship
                        Console.Clear();
                        start.BoardShip boardShip = new start.BoardShip();
                        charinf = boardShip.aboardShip(charinf);
                        break;
                    case "2": // Further Story [WIP]
                        end = true; // temp as Abording Ship isn't completed and story isn't written for here.
                        break;
                    case "3": // settings menu
                        Console.Clear();
                        start.SettingsMenu settingsMenu = new start.SettingsMenu();
                        break;
                    default:
                        // Ummmmm... idk what goes here but...
                        break;
                }
            }
        }
    }
}

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
                        Scark.ast.start.CC cC = new Scark.ast.start.CC();
                        charinf = cC.NewPlayer();
                        break;
                    case "1": // Aboarding Ship
                        Console.Clear();
                        Scark.ast.start.BoardShip boardShip = new Scark.ast.start.BoardShip();
                        charinf = boardShip.aboardShip(charinf);
                        break;
                    case "2": // Further Story [WIP]
                        end = true; // temp as Abording Ship isn't completed and story isn't written for here.
                        break;
                    default:
                        // Ummmmm... idk what goes here but...
                        break;
                }
            }
        }
    }
}

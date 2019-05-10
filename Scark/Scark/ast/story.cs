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
        public void Run()
        {
            bool end = false;
            while (end == false)
            {
                switch (Character.stage)
                {
                    case 0: // Character Creation
                        Console.Clear();
                        start.CC cC = new start.CC();
                        cC.NewPlayer();
                        break;
                    case 1: // Aboarding Ship
                        Console.Clear();
                        start.BoardShip boardShip = new start.BoardShip();
                        boardShip.aboardShip();
                        break;
                    case 2: // Further Story [WIP]
                        Console.Clear();
                        
                        
                        break;
                    case 3:
                        end = true;
                        break;
                    default:
                        // Ummmmm... idk what goes here but...
                        break;
                }
            }
        }
    }
}

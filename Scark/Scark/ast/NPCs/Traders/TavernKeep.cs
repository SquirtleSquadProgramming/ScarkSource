using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.NPCs.Traders
{
    public class TavernKeep : Trader
    {
        public TavernKeep()
        {
            Name = "TavernKeep";
            ethryl = 300;
            MaxHP = 100;
            CurrentHP = 100;
            inventory = new int[1][];
            inventory[0] = new int[2] { 1, 100 };
        }
    }
}

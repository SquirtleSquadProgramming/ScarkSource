using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.NPCs.Traders
{
    static class TavernKeep
    {
        internal static string Name = "TavernKeep";
        internal static int ID = 0;
        internal static int CurrentHP = 100;
        internal static int MaxHP = 100;
        internal static int[][] Inventory = new int[1][]
        {
            new int[2] { 1, 100 }
        };
        internal static int Ethryl = 300;

        public static Trader ToTrader() => new Trader(Name, ID, CurrentHP, MaxHP, Inventory, Ethryl);
    }
}

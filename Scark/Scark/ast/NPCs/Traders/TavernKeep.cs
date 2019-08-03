using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;
using Scark.ast.items.weapons;
using Scark.ast.items.general;

namespace Scark.ast.NPCs.Traders
{
    static class TavernKeep
    {
        internal static string Name = "TavernKeep";
        internal static int ID = 0;
        internal static int CurrentHP = 100;
        internal static int MaxHP = 100;
        internal static List<Item> Inventory = new List<Item>
        {
            IronShortsword.ToItem(),
            BookOfSouls.ToItem(),
            IronBroadsword.ToItem(),
            LeatherQuiver.ToItem(),
            IronBow.ToItem()
        }; // Need to change
        internal static int Ethryl = 300;

        public static Trader ToTrader() => new Trader(Name, ID, CurrentHP, MaxHP, Inventory, Ethryl);
    }
}

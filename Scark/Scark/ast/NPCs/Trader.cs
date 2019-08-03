using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.NPCs
{
    public class Trader
    {
        public string Name = "";
        public int ID;
        public int CurrentHP;
        public int MaxHP;
        public int[][] Inventory;
        public int Ethryl;

        public Trader(string name, int id, int currentHP, int maxHP, int[][] inventory, int ethryl)
        {
            Name = name;
            ID = id;
            CurrentHP = currentHP;
            MaxHP = maxHP;
            Inventory = inventory;
            Ethryl = ethryl;
        }
    }
}

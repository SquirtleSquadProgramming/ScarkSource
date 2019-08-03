using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.NPCs
{
    public class Trader
    {
        public string Name = "";
        public int ID;
        public int CurrentHP;
        public int MaxHP;
        public List<Item> Inventory;
        public int Ethryl;

        public Trader(string _Name, int _ID, int _CurrentHP, int _MaxHP, List<Item> _Inventory, int _Ethryl)
        {
            Name = _Name;
            ID = _ID;
            CurrentHP = _CurrentHP;
            MaxHP = _MaxHP;
            Inventory = _Inventory;
            Ethryl = _Ethryl;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    static class Tomahawk
    {
        public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>()
        {
            { "Damage", 6 }, // WIP
            { "Class", "Melee" } // WIP
        };
        public static int ID = 5;
        public static int Price = 50;
        public static int SellPrice = 35;
        public static string Name = "Tomahawk";
        public static string Description = "A lightweight hatchet that gets the job done";
        public static string Image = @"|`-. __      __
 ||     ------   '-,
 ||               /
 ||              '
 ||              |
 ||  _,------\_/-|
 |L./        |-  |
             | - |
             |- -|
             |_-_|
             |___|
             |_-_|
             |___|
             |_-_|
             |___|
             |_-_|
             |___|
             |_-_|
             L___|";

        public static Item ToItem() => new Item(ID, Price, SellPrice, Name, Description, Image, Attributes);
    }
}
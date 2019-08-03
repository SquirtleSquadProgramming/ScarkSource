using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    static class IronBow
    {
        public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>()
        {
            { "Damage", 6 }, // WIP
            { "Class", "Ranged" } // WIP
        };
        public static int ID = 3;
        public static string Name = "Iron Bow";
        public static string Description = "A trusty bow. A little bit rusty, but capable of hunting easy game.";
        public static string Image = @"             __
            .  \
            ,' \
         _,'  ,'
        `   _' .
      ./  /`   |
     `  .'      |
    /  `        |
   /  /         |
  /  /           |
 /  /            |
 | |             |
 | |             |
 |0|             |
 | |             |
 \  \            |
  \  \          |
   \  \         |
    \  `.       |
     `.  \      |
       \  `._  |
        `.   `.'
          `.   `
            `'  \
             .__\";

        public static Item ToItem() => new Item(ID, Name, Description, Image, Attributes);
    }
}

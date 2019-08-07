using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    static class IronBroadsword
    {
        public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>()
        {
            { "Damage", 5 }, // WIP
            { "Class", "Melee" } // WIP
        };
        public static int ID = 1;
        public static int Price = 25; // Need to Change!
        public static int SellPrice = 20;
        public static string Name = "Iron Broadsword";
        public static string Description = "A relatively large, rusting sword with a faint smell of blood.";
        public static string Image = @"                '
               / \
              /   \
             /  `  \
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  |  |
             |  `  |
 \           |     |           /
  '-.._____..`.....`.._____..-'
  \  ---__,    [X]    .__---  /
   '.________..-_-..________.'
              |___|
              |_-_|
              |___|
              |_-_|
              L___|";

        public static Item ToItem() => new Item(ID, Price, SellPrice, Name, Description, Image, Attributes);
    }
}

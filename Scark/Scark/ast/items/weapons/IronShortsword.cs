using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    static class IronShortsword
    {
        public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>()
        {
            { "Damage", 5 }, // WIP
            { "Class", "Melee" } // WIP
        };
        public static int ID = 0;
        public static string Name = "Iron Shortsword";
        public static string Description = "A rather short, bloodstained sword. Old, but it works";
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
             |  `  |
 \           |     |           /
  '-.._____..`.....`.._____..-'
  \  ---__     [0]     __---  /
   '.________..---..________.'
              |___|
              |___|
              |___|
              |___|
              |___|";

        public static Item ToItem() => new Item(ID, Name, Description, Image, Attributes);
    }
}

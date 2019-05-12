using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    public class IronShortsword : Weapon
    {
        public IronShortsword()
        {
            Damage = 5; // tbc
            Name = "Iron Shortsword";
            WeaponClass = "Melee";
            Description = "A rather short, bloodstained sword. Old but it works.";

            ID = 0;

            Image = @"                '
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
        }
    }
}

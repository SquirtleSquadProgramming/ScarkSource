using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    class IronBroadsword : Weapon
    {
        public IronBroadsword()
        {
            Damage = 4; // tbc
            Name = "Iron Broadsword";
            WeaponClass = "Melee";
            Description = "A relatively large, rusting sword with a faint smell of blood.";

            ID = 1;

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
        }
    }
}

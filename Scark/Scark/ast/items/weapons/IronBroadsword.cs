using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        }
    }
}

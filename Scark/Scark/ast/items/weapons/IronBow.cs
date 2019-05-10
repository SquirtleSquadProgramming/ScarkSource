using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items.weapons
{
    class IronBow : Weapon
    {
        IronBow()
        {
            Name = "Iron Bow";
            Damage = 6; // tbc
            WeaponClass = "Ranged";
            Description = "A trusty bow. A little bit rusty, but capable of hunting easy game."

            ID = 3;
        }
    }
}

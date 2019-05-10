using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items.weapons
{
    class BookOfSouls : Weapon
    {
        BookOfSouls()
        {
            Name = "Book of Souls";
            Damage = 7; // tbc
            WeaponClass = "Magic";

            ID = 4;
        }
    }
}

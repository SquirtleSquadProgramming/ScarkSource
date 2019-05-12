using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    class IronBow : Weapon
    {
        public IronBow()
        {
            Damage = 6;
            Name = "Iron Bow";
            WeaponClass = "Ranged";
            Description = "A trusty bow. A little bit rusty, but capable of hunting easy game.";

            ID = 3;

            Image = @"             __
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
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items
{
    public class Weapon : Item
    {
        public static int Damage {
            get { return Damage; }
            set { Damage = value; }
        }
        public static string WeaponClass
        {
            get { return WeaponClass; }
            set { WeaponClass = value; }
        }
    }
}

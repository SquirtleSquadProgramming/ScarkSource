using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.NPCs
{
    public class Monster : NPC
    {
        // array bc damage is random, thus; [x,y] x is the number of dice to "roll", y is the number of sides the "dice" has
        public static int[] Damage { get; set; }
    }
}

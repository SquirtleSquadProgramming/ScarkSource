using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.NPCs
{
    public class NPC
    {
        public string Name { get; set; }
        public int id { get; set; } //Possible usefull later on
        public int CurrentHP { get; set; }
        public int MaxHP { get; set; }
    }
}

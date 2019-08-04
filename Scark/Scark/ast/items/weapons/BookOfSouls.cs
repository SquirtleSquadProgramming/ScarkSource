using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    static class BookOfSouls
    {
        public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>()
        {
            { "Damage", 7 },
            { "Class", "Magic" }
        };
        public static int ID = 4;
        public static int Price = 25; // Need to Change!
        public static string Name = "Book of Souls";
        public static string Description = "Harnessing dark magic, for those who follow, death awaits.";
        public static string Image = @"                      ____________
                __.--'      _.--'|
           _,,-'       _.--;.-   |
     _,.-''       _.--'  ,''     |
_.==i_______ _.--'    _,'        |
|           '        '  __==--   |
|           |     ,'        _,   |
| |.|_  _  _|    ,' _,--=.,'     |
| |||_)(/_| |   '| + _    |  |   |
| animarum  |   / |||. `  |  |   |
| -~-~-~-~- |  /  |      /   '   |
|           | `  ,'|    /        |
| qui post  |    ' `.  /   ___   |
|  mortem   |      |\_|          |
|  maneat   |      |  \ ,|       |
|           |  '  /   _'         |
|   ,--.    | d   |   '        ,'
|  ( () )   |    '          ,-'
|   `--'    |    _,'     ,-'
|       ... |    '    _,'
| .____     |       ,'
|     ___   |    ,-'
|  ---      | ,-'
............|'";

        public static Item ToItem() => new Item(ID, Price, Name, Description, Image, Attributes);
    }
}

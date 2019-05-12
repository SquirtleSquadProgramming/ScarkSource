using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.weapons
{
    class BookOfSouls : Weapon
    {
        public BookOfSouls()
        {
            Damage = 7;
            Name = "Book of Souls";
            WeaponClass = "Magic";
            Description = "Harnessing dark magic, for those who follow, death awaits.";

            ID = 4;

            Image = @"                      ____________
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
        }
    }
}

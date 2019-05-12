using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items.general_items
{
    class LeatherQuiver : Item 
    {
        LeatherQuiver()
        {
            Name = "Leather Quiver";

            ID = 2;

            Image = @"                          |
                        | |      |
                        | |,'/ | |     _,
                        | ,'/_ | |,'/.'
      ,__                / /'  | ,'/_,-
      ||``.             / /     / /'
     ,-' \ \           /,'     / /
    +     \ |        ,','     /,'
 _':|      `.     ' --..._  ,','
./-'        ``b--/        `.
||             ;' .         `--
||            /  |        .   ,'
||           / .          |  /
`:._        / ,' |       < ,'
 `./      ,' /   /    -  ,'
  |.     /      '       /
   `\_  /  '       ,  ,'
    `.|/  '       `  /
     '/            ,'
    ,'        --  /
   .i'''`--._   ,'
     `.__    `.'
         `''''";
        }
    }
}

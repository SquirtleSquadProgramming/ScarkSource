using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items.general
{
    static class LeatherQuiver
    {
        public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>()
        {
            {"Capacity", 25 }
        };
        public static int ID = 2;
        public static int Price = 10; // Need to Change!
        public static string Name = "Leather Quiver";
        public static string Description = "A container made from skinned cows to hold your arrows.";

        public static string Image = @"                          |
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

        public static Item ToItem() => new Item(ID, Price, Name, Description, Image, Attributes);
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark
{
    public class ItemID
    {
      //    Character.inventory.Add(ItemID.ConvertStringToID("iron shortsword"));
      //    Character.inventory.ForEach(i => Console.Write("{0} ", ItemID.ConvertIDToString(i)));
      //    
      //    ^ example of adding item to inventory

        public static string ConvertIDToString(int item_id)
        {
            switch (item_id)
            {
                case 0: return "Iron Shortsword";
                case 1: return "Iron Broadsword";
                case 2: return "Leather Quiver";
                case 3: return "Iron Bow";
                case 4: return "Book of Souls";
            }

            throw new NotImplementedException();
        }

        public static int ConvertStringToID(string item_name)
        {
            switch (item_name)
            {
                case "Iron Shortsword": return 0;
                case "Iron Broadsword": return 1;
                case "Leather Quiver":  return 2;
                case "Iron Bow":        return 3;
                case "Book of Souls":   return 4;
            }

            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items
{
    public class ItemID
    {
        /*
         * Character.inventory.Add(ItemID.StringToItem("Iron Shortsword");
         * // OR \\
         * Character.inventory.Add(ItemID.IDToItem(0);
         * // OR \\
         * Character.inventory.Add(weapons.IronShortsword.ToItem());
         */

        public static string ConvertIDToString(int item_id) // Kinda Obsolete... But still *can* be useful
        {
            switch (item_id)
            {
                case 0: return "Iron Shortsword";
                case 1: return "Iron Broadsword";
                case 2: return "Leather Quiver";
                case 3: return "Iron Bow";
                case 4: return "Book of Souls";
                case 5: return "Tomahawk";
            }

            throw new Item.UnknownException($"Could not find item with id of {item_id}");
        }

        public static Item IDToItem(int item_id)
        {
            switch (item_id)
            {
                case 0: return weapons.IronShortsword.ToItem();
                case 1: return weapons.IronBroadsword.ToItem();
                case 2: return general.LeatherQuiver.ToItem();
                case 3: return weapons.IronBow.ToItem();
                case 4: return weapons.BookOfSouls.ToItem();
                case 5: return weapons.Tomahawk.ToItem();
            }

            throw new Item.UnknownException($"Could not find item with id of {item_id}");
        }

        public static Item StringToItem(string item_name)
        {
            switch (item_name)
            {
                case "Iron Shortsword": return weapons.IronShortsword.ToItem();
                case "Iron Broadsword": return weapons.IronBroadsword.ToItem();
                case "Leather Quiver":  return general.LeatherQuiver.ToItem();
                case "Iron Bow":        return weapons.IronBow.ToItem();
                case "Book of Souls":   return weapons.BookOfSouls.ToItem();
                case "Tomahawk":        return weapons.Tomahawk.ToItem();
            }

            throw new Item.UnknownException($"Could not find item with name of {item_name}");
        }

        public static int ConvertStringToID(string item_name) // Kinda Obsolete... But still *can* be useful
        {
            switch (item_name)
            {
                case "Iron Shortsword": return 0;
                case "Iron Broadsword": return 1;
                case "Leather Quiver":  return 2;
                case "Iron Bow":        return 3;
                case "Book of Souls":   return 4;
                case "Tomahawk":        return 5;
            }

            throw new Item.UnknownException($"Could not find item with name of {item_name}");
        }
    }
}

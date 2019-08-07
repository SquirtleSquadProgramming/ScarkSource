using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast.items;

namespace Scark.ast.items.general
{
    public static class RoyalTopaz
    {
        public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>()
        {
            { "Capacity", 25 },
            { "Amount", 25 }
        };
        public static int ID = 6;
        public static int Price = 200; // Need to Change!
        public static int SellPrice = 150;
        public static string Name = "Royal Topaz";
        public static string Description = "A shiny topaz";
        public static string Image = @"";

        public static Item ToItem() => new Item(ID, Price, SellPrice, Name, Description, Image, Attributes);
    }
}

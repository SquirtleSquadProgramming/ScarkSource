using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items
{
    public class Item
    {
        public const int Unsellable = -1;
        public int ID { get; set; }
        public int Price { get; set; }
        public int SellPrice { get; set; }
        public string Name { get; set; } // CANNOT EXCEDE 20 CHARACTERS
        public string Description { get; set; }
        public string Image { get; set; }
        
        public Dictionary<string, dynamic> Attributes { get; set; }

        public Item(int _ID, int _Price, int _SellPrice, string _Name, string _Description, string _Image, Dictionary<string, dynamic> _Attributes)
        {
            if (_Name.Length > 20)
                throw new LengthException($"Exception with item name's length as it excedes the maximum of 20 characters. Name: {_Name} || ID: {_ID}");

            ID = _ID;
            Price = _Price;
            SellPrice = _SellPrice;
            Name = _Name;
            Description = _Description;
            Image = _Image;
            Attributes = _Attributes;
        }

        public static void showItemInfoGUI(Item item)
        {
            Console.WriteLine($"ITEM:        {item.Name} [ID: {item.ID}]");
            Console.WriteLine($"DESCRIPTION: {item.Description}");
            Console.WriteLine($"BUY PRICE:   {item.Price} Ethryl");
            Console.WriteLine($"SELL PRICE:  {item.SellPrice} Ethryl");
            Console.WriteLine(item.Image);
            Console.WriteLine($"ATTRIBUTES:  ");
            foreach (KeyValuePair<string, dynamic> attribute in item.Attributes)
            {
                Console.WriteLine($"{attribute.Key} : {attribute.Value}");
            }
            Console.WriteLine("\n");
        }

        [Serializable]
        public class UnknownException : Exception
        {
            public UnknownException() { }
            public UnknownException(string Message) { }
            public UnknownException(string Message, Exception inner) { }
            protected UnknownException(SerializationInfo info, StreamingContext context) { }
        }

        [Serializable]
        private class LengthException : Exception
        {
            public LengthException() { }
            public LengthException(string message) { }
            public LengthException(string message, Exception innerException) { }
            protected LengthException(SerializationInfo info, StreamingContext context) { }
        }
    }
}

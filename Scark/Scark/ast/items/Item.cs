using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items
{
    public class Item
    {
        public const int Unsellable = -1;
        public int ID { get; set; }
        public int Price { get; set; }
        public string Name { get; set; } // CANNOT EXCEDE 20 CHARACTERS
        public string Description { get; set; }
        public string Image { get; set; }
        public Dictionary<string, dynamic> Attributes { get; set; }

        public Item(int _ID, int _Price, string _Name, string _Description, string _Image, Dictionary<string, dynamic> _Attributes)
        {
            if (_Name.Length > 20)
                throw new LengthException($"Exception with item name's length as it excedes the maximum of 20 characters. Name: {_Name} || ID: {_ID}");

            ID = _ID;
            Price = _Price;
            Name = _Name;
            Description = _Description;
            Image = _Image;
            Attributes = _Attributes;
        }

        public class UnknownException : System.Exception
        {
            public UnknownException() { }
            public UnknownException(string Message) : base(Message) { }
            public UnknownException(string Message, Exception inner) : base(Message, inner) { }
        }

        private class LengthException : System.Exception
        {
            public LengthException(string Message) : base(Message) { }
        }

        public static void showItemInfoGUI(Item item)
        {

            Console.WriteLine($"ITEM:        {item.Name} [ID: {item.ID}]");
            Console.WriteLine($"DESCRIPTION: {item.Description}");
            Console.WriteLine($"VALUE:       {item.Price}");
            Console.WriteLine(item.Image);
            Console.WriteLine($"ATTRIBUTES:  ");
            foreach (KeyValuePair<string, dynamic> attribute in item.Attributes)
            {
                Console.WriteLine($"{attribute.Key} : {attribute.Value}");
            }
        }
    }
}

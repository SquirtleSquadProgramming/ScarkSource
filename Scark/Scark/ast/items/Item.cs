using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.items
{
    public class Item
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public Dictionary<string, dynamic> Attributes { get; set; };

        public Item(int item_ID, string item_Name, string item_Description, string item_Image, Dictionary<string, dynamic> item_Attributes)
        {
            ID = item_ID;
            Name = item_Name;
            Description = item_Description;
            Image = item_Image;
            Attributes = item_Attributes;
        }
    }

    public class UnknownItemException : System.Exception
    {
        public UnknownItemException()
        {

        }

        public UnknownItemException(string Message) : base(Message)
        {

        }

        public UnknownItemException(string Message, Exception inner) : base(Message, inner)
        {

        }
    }
}

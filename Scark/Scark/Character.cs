using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark
{
    class Character
    {

        // Interger Variables
        public static int stage; // What stage of story the player is at
        public static int ethryl; // Currency
        public static int health; // Health
        public static int magika; // Mana/Magika

        // String Variables
        public static string name; // Name
        public static string race; // Race

        // Boolean Variables
        public static bool dev; // If dev

        // List for inventory
        public static List<string> inventory = new List<string>();

        // Dictionary for settings, accessed by setting in []: eg. Character.Settings["SpeechSpeed"]
        public static Dictionary<string, int> Settings = new Dictionary<string, int>()
        {
            {"SpeechSpeed", 1000}
        };

        // Puts all character data into one
        public static string[] dataCollection()
        {
            string listToString = "["; // Used for converting the list to a string (for saving)
            for (int i = 0; i < inventory.Count; i++)
            {
                if (i < inventory.Count - 1)
                    listToString += inventory[i] + ",";
                else listToString += inventory[i] + "]";
            }
            return new string[] { stage.ToString(), ethryl.ToString(), health.ToString(), name, race, listToString};
        }

    }
}

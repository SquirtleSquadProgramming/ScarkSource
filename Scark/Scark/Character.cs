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
        public static Dictionary<string, dynamic> Settings = new Dictionary<string, dynamic>()
        {
            {"SpeechSpeed", 1500 },
            {"Profanity", false},
            {"ColourTheme", "dark"}
        };

        // Ability scores dictionary
        public static Dictionary<string, int> AbilityScores = new Dictionary<string, int>()
        {
            {"constitution", 0},
            {"charisma", 0 },
            {"intelligence", 0 },
            {"perception", 0 },
            {"strength", 0 },
            {"stealth", 0 },
        };

        // Sets swear word censorship/not (maybe could be optimized)
        public static Dictionary<string, string> SwearReplacements = new Dictionary<string, string>()
        {
            {"the hell", "the hell"},
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

        // Converts ability SCORE into ability MODIFIER
        public static int convertAbilityScoreToAbilityModifier(string ability_score_name)
        {
            switch (AbilityScores[ability_score_name])
            {
                case 0:
                    return -5;
                case 1:
                    return -4;
                case 2:
                    return -3;
                case 3:
                case 4:
                    return -2;
                case 5:
                case 6:
                    return -1;
                case 7:
                case 8:
                case 9:
                    return 0;
                case 10:
                case 11:
                case 12:
                    return 1;
                case 13:
                case 14:
                case 15:
                    return 2;
                case 16:
                case 17:
                case 18:
                case 19: 
                    return 3;
                case 20:
                case 21:
                case 22:
                case 23:
                    return 4;
                case 24:
                case 25:
                    return 5;
            }
            
            return 0;
        }

    }
}

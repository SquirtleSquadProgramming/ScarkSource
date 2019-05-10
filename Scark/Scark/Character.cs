using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Scark
{
    class Character
    {

        // Void for saving the character data
        public void save()
        {

        }
        
         
        // Integer Variables
        public static int stage; // What stage of story the player is at
        public static int ethryl; // Currency
        public static int health; // Health
        public static int magika; // Mana/Magika

        public static int level; // Player level
        public static int currentXP; // player's current XP
        public static int maxXP; // maximum xp player can get before level up

        // String Variables
        public static string name; // Name
        public static string race; // Race

        // Boolean Variables
        public static bool dev; // If dev

        // List for inventory
        public static List<int /* int is for item ID */> inventory = new List<int>();

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
            return new string[] { stage.ToString(), ethryl.ToString(), health.ToString(), magika.ToString(), level.ToString(), currentXP.ToString(), maxXP.ToString(), name, race, listToString};
        }

        // Converts ability SCORE into ability MODIFIER
        public static int convertAbilityScoreToAbilityModifier(string ability_score_name)
        {
            int[] tmp = new int[26] { -5, -4, -3, -2, -2, -1, -1, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5 };

            for (int i = 0; i < 26; i++)
                if (AbilityScores[ability_score_name] == i)
                    return tmp[i];

            return 0;
        }


        // awards ethyrl to the player
        public static void awardEthryl(int amount)
        {
            //Change to dark or light magenta and print a message to console
            if (Character.Settings["ColourTheme"] == "dark")
                Console.ForegroundColor = ConsoleColor.Magenta; 
            else if (Character.Settings["ColourTheme"] == "light")
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
            
            Console.WriteLine("+ " + amount.ToString() + " Ethryl");

            //actually give the player the ethryl
            Character.ethryl = Character.ethryl + amount;
            revertColourScheme();

            // Wait a bit (because why not) (and also incase a Console.Clear() is directly after this.)
            Thread.Sleep(Character.Settings["SpeechSpeed"]);

        }

        // awards magika to the player
        public static void awardMagika(int amount)
        {
            //Change to dark or light green and print a message to console
            if (Character.Settings["ColourTheme"] == "dark")
                Console.ForegroundColor = ConsoleColor.Green;
            else if (Character.Settings["ColourTheme"] == "light")
                Console.ForegroundColor = ConsoleColor.DarkGreen;

            Console.WriteLine("+ " + amount.ToString() + " Magika");

            //actually give the player the ethryl
            Character.magika = Character.magika + amount;
            revertColourScheme();

            // Wait a bit (because why not) (and also incase a Console.Clear() is directly after this.)
            Thread.Sleep(Character.Settings["SpeechSpeed"]);

        }


        // reverts all colours to normal (colour scheme dependent)
        public static void revertColourScheme()
        {
            //Revert back to colour scheme
            if (Character.Settings["ColourTheme"] == "dark")
                Console.ForegroundColor = ConsoleColor.White;
            else if (Character.Settings["ColourTheme"] == "light")
                Console.ForegroundColor = ConsoleColor.Black;
        }


        // write text w/ delay (depending on admin or not)
        public static void wd(string text)
        {
            string filteredText = text;

            //profanitise if selected
            if (Character.Settings["Profanity"])
            {
                //replaces good boy words with their more profane counterparts
                filteredText = filteredText.Replace("hell", "fuck");
                filteredText = filteredText.Replace("flip", "fuck");
                filteredText = filteredText.Replace("darn", "damn");
                filteredText = filteredText.Replace("idiot", "dick");
                filteredText = filteredText.Replace("bloody", "fucking");
            }
            Console.WriteLine("\n" + filteredText);
            if (!Character.dev)
            {
                // Console.Write("[DEV: {0}]", start.Menu.dev);
                Thread.Sleep(Character.Settings["SpeechSpeed"]);
            }
        }

    }
}

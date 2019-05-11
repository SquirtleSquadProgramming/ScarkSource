#region Usings
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
#endregion

namespace Scark
{
    class Character
    {
        #region Character Attributes
        // Integer Variables
        public static int stage; // What stage of story the player is at
        public static int ethryl; // Currency
        public static int abilityPoints;
        public static int level; // Player level
        public static int currentXP; // player's current XP
        public static int maxXP; // maximum xp player can get before level up

        // String Variables
        public static string name; // Name
        public static string characterClass; // Race -- but race is only human tho

        // Boolean Variables
        public static bool dev; // If dev

        // List for inventory
        public static List<int /* int is for item ID */> inventory = new List<int>();

        // Dictionary for settings, accessed by setting in []: eg. Character.Settings["SpeechSpeed"]
        public static Dictionary<string, dynamic> Settings = new Dictionary<string, dynamic>()
        {
            {"SpeechSpeed", 1500 },
            {"Profanity", false},
            {"ColourTheme", "dark"},
            {"SpecialEffects", true}
        };

        // Ability scores dictionary (modifer) [from -5 to 5]
        public static Dictionary<string, int> AbilityScores = new Dictionary<string, int>()
        {
            {"constitution", 0},
            {"charisma", 0 },
            {"intelligence", 0 },
            {"perception", 0 },
            {"strength", 0 },
            {"stealth", 0 },
        };

        // Health
        public static Dictionary<string, int> health = new Dictionary<string, int>()
        {
            {"max", 0},
            {"current", 0}
        };

        // Mana/Magika
        public static Dictionary<string, int> magika = new Dictionary<string, int>()
        {
            {"max", 0},
            {"current", 0}
        };

        // Puts all character data into one
        public static string[] dataCollection()
        {
            string listToString = ""; // Used for converting the list to a string (for saving)
            for (int i = 0; i < inventory.Count; i++)
            {
                if (i < inventory.Count - 1)
                    listToString += inventory[i] + ",";
                else listToString += inventory[i];
            }

            dynamic a = AbilityScores; // For EOA

            return new string[] {
                stage.ToString(),
                ethryl.ToString(),
                health["max"].ToString() + "," + health["current"].ToString(),
                magika["max"].ToString() + "," + magika["current"].ToString(),
                level.ToString(),
                currentXP.ToString(),
                maxXP.ToString(),
                name,
                characterClass,
                listToString,
                Settings["SpeechSpeed"] + "," + Settings["Profanity"] + "," + Settings["ColourTheme"],
                a["constitution"].ToString() + "," + a["charisma"].ToString() + "," +
                a["intelligence"].ToString() + ","+ a["perception"].ToString() + "," +
                a["strength"].ToString() + "," + a["stealth"].ToString()
            };
        }

        #endregion

        #region Adding Attributes
        // awards ethyrl to the player
        public static void awardEthryl(int amount)
        {
            // If the user has special effects enabled
            if (Character.Settings["SpecialEffects"])
            {
                // If the users theme is dark mode
                if (Character.Settings["ColourTheme"] == "dark")
                    Console.ForegroundColor = ConsoleColor.Magenta; // Setting the colour to magenta
                // If the users theme is light mode (ew gay)
                else if (Character.Settings["ColourTheme"] == "light")
                    Console.ForegroundColor = ConsoleColor.DarkMagenta; // Setting the colour to a dark magenta
            }
            
            // Writing: "+ * Ethryl" * amount of ethryl to console
            Console.WriteLine("+ " + amount.ToString() + " Ethryl");

            // Adding the ethryl to the player
            Character.ethryl = Character.ethryl + amount;

            // Setting the foreground colour back to the default
            revertColourScheme();

            // Wait a bit (because why not) (and also incase a Console.Clear() is directly after this.)
            Thread.Sleep(Character.Settings["SpeechSpeed"]);
        }

        // awards magika to the player
        public static void addMagika(int amount)
        {
            // if the user has special effects enabled
            if (Character.Settings["SpecialEffects"])
            {
                // if the user has dark theme
                if (Character.Settings["ColourTheme"] == "dark")
                    Console.ForegroundColor = ConsoleColor.Blue; // set text colour to blue
                // if the user has light theme (ew gay)
                else if (Character.Settings["ColourTheme"] == "light")
                    Console.ForegroundColor = ConsoleColor.DarkBlue; // set text colour to dark blue
            }

            // Printing the amount of magika added
            Console.WriteLine("+ " + amount.ToString() + " Magika");

            // Adding to the max amount of magika
            Character.magika["max"] += amount;

            // Changing text colour back to the original
            revertColourScheme();

            // Sleeping because a Console.Clear may follow
            Thread.Sleep(Character.Settings["SpeechSpeed"]);
        }

        // gives the player ability point(s)
        public static void awardAbilityPoint(int amount)
        {
            // if the user has special effects enabled
            if (Character.Settings["SpecialEffects"])
            {
                // if the user has dark theme enabled
                if (Character.Settings["ColourTheme"] == "dark")
                    Console.ForegroundColor = ConsoleColor.Cyan; // set the text colour to cyan
                // if the user has light theme enabled (ew gay)
                else if (Character.Settings["ColourTheme"] == "light")
                    Console.ForegroundColor = ConsoleColor.DarkCyan; // set the text colour to dark cyan
            }

            // if the amount added is > 1
            if (amount > 1)
                Console.WriteLine("+ " + amount.ToString() + " Ability Points"); // plural
            else // else
                Console.WriteLine("+ " + amount.ToString() + " Ability Point"); // singular

            // Adding the ability points to the character
            Character.abilityPoints += amount;

            // Reverting text colour to original
            revertColourScheme();

            // Sleeping as there may be a Console.Clear after
            Thread.Sleep(Character.Settings["SpeechSpeed"]);
        }

        // award experience points
        public static void awardXP(int amount)
        {
            //making sure maxXP is up to date
            maxXP = (level + 1) * 100;

            // If user has special effects enabled
            if (Character.Settings["SpecialEffects"])
            {
                // If the user has dark theme
                if (Character.Settings["ColourTheme"] == "dark")
                    Console.ForegroundColor = ConsoleColor.Yellow; // Setting the text colour to yellow
                // If the use has ligth theme (ew gay)
                else if (Character.Settings["ColourTheme"] == "light")
                    Console.ForegroundColor = ConsoleColor.DarkYellow; // Setting the text colour to dark yellow
            }

            // If the player has reached max xp current level
            if (currentXP + amount >= maxXP)
            {
                level++; // Adding to the level
                currentXP += amount - maxXP; // Current XP gets what is left over after leveling up
                // Printing that you leveled up and more data about levels
                Console.WriteLine("+ " + amount.ToString() + " XP \nYou leveled up to level " + level.ToString() + "!\n(" + currentXP.ToString() + "/" + maxXP.ToString() + " needed to gain the next level.)");
            }
            else // If the player didn't level up
            {
                currentXP += amount; // adding amount to currentXP
                // Printing data about levels and XP
                Console.WriteLine("+ " + amount.ToString() + " XP (" + currentXP.ToString() + "/" + maxXP.ToString() + ")");
            }

            // revert back to normal colours
            revertColourScheme();

            // Make sure maxxp is up to date, again
            maxXP = (level + 1) * 100;

            // Waiting just incase a Console.Clear follows
            Thread.Sleep(Character.Settings["SpeechSpeed"]);
        }
        #endregion

        // reverts all colours to normal (colour scheme dependent)
        public static void revertColourScheme()
        {
            // If the users theme is dark
            if (Character.Settings["ColourTheme"] == "dark")
                Console.ForegroundColor = ConsoleColor.White; // Then set the text colour back to white
            // If the users theme is light (ew gay)
            else if (Character.Settings["ColourTheme"] == "light")
                Console.ForegroundColor = ConsoleColor.Black; // Then set the text colour back to black
        }

        #region Save Systems
        // Void for saving the character data
        public static void save(string name)
        {
            // setting fileURL to the url to the save file
            string fileURL = Environment.CurrentDirectory + "\\" + name + ".save";
            string[] tmp = Character.dataCollection(); // setting string[] tmp to dataCollection()
            string output = ""; // string output to blank

            // itterating through dataCollection
            for (int i = 0; i < Character.dataCollection().Length; i++)
            {
                output += tmp[i]; // adding dataCollection[i] to output

                // if ! the last entry of tmp
                if (i < tmp.Length - 1)
                {
                    output += "§"; // adding a seperator character
                }
            }

            // writing ouput to the save file at fileURL
            File.WriteAllText(fileURL, output);
        }

        // Void for reading character saves

        #endregion

        #region Ability Scores

        private static string abbreviationToName(string input)
        {
            switch (input)
            {
                case "CON":
                    return "constitution"; // Setting it to* constitution
                case "CHA":
                    return "charisma"; // * charisma
                case "INT":
                    return "intelligence"; // * intelligence
                case "PER":
                    return "perception"; // * perception
                case "STR":
                    return "strength"; // * strength
                case "STE":
                    return "stealth"; // * stealth
            }
            throw new NotImplementedException();
        }

        // Void for the choose ability score points menu
        public static void chooseAbilityScorePoints()
        {
            Console.Clear();

            bool optionPicked = false; // setting optionPicked to false for later use in a while loop

            //Clearing the Console and printing the options
            Console.Clear();
            Console.Write("                             {0} Ability Points Remaining\n=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n                                Options:\n[STE] Stealth      : Likelihood of surprising people, avoiding danger, hiding, etc.\n[CON] Constitution : Determines HP, likelyhood of surviving sickness, etc.\n[INT] Intelligence : Ability to know about things, traps, enemies, etc.\n[CHA] Charisma     : Likelihood of persuading or other speech actions.\n[PER] Perception   : Ability to sense traps, find clues, etc.\n[STR] Strength     : Ability to use strength\n[ X ]   Exit         : Exit this menu\nPlease select an ability to add points to (Max 25 points to each ability):\n> ", abilityPoints);

            // string addTo processed to give a maximum of 3 characters
            string addTo = (Console.ReadLine().Replace("[", "").Replace("]", "").ToUpper() + "   ").Substring(0, 3).Replace(" ", "");

            // Processing the (processed) input to the actual name of an ability for later use
            if (addTo == "X") return;
            else addTo = abbreviationToName(addTo);

            // Asking the amound of points wants to add to the specified ability
            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nPlease enter the amount of points that want to add to the {0} abilty:\n> ", addTo);
            
            // parsing the input
            int amount = Math.Abs(Int32.Parse(Console.ReadLine()));
                
            // loop while the user has exceeded: the amount of abilityPoints they have
            //                                   the max amount of points an ability can have
            while (!(amount <= abilityPoints && amount + AbilityScores[addTo] <= 25))
            {
                // Writing that they have exceeded an amount
                Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n                        {1} exceeds either: {2} or 25!\n        Please enter the amount of points that want to add to the {0} abilty:\n> ", addTo, amount, abilityPoints);

                // Re-getting their input
                amount = Int32.Parse(Console.ReadLine());
            }

            // Adding the amount to the selected ability
            AbilityScores[addTo] += amount;

            // Subtracting amount from the abilityPoints
            abilityPoints -= amount;

            // setting optionPicked to false as to reuse it
            optionPicked = false;
            dynamic apply = false; // dynamic variable apply to false

            // Looping until the user picks Y/N
            while (optionPicked == false)
            {
                // Asking if they wish to apply the changes
                Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\nDo you wish to apply these changes: Add {0} to {1} leaving you with {2}\n[Y] Apply\n[N] Revert changes\n> ", amount, addTo, abilityPoints);

                //Getting and processing their input to only 1 character
                apply = Console.ReadLine().Replace("[", "").Replace("]", "").Replace(" ", "").Substring(0, 1).ToUpper();

                switch (apply)
                {
                    case "Y": // If they picked yes
                        optionPicked = true; // Exiting while loop
                        apply = true; // Setting apply(dynamic) to true
                        break;
                    case "N": // If they picked no
                        optionPicked = true; // Exiting while loop
                        abilityPoints += amount; // Reversing changes
                        AbilityScores[addTo] -= amount; // Reversing changes
                        apply = false; // Setting apply(dynamic) to false
                        break;
                }
            }
              
            // Asking if they wish to use more ability points
            Console.Write("=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=\n                Do you wish to use more ability points?\n                [Y] Yes I do!            No Thanks! [N]\n> ");
                
            // Getting their input and processing it to 1 character
            string inp = Console.ReadLine().Replace("[", "").Replace("]", "").Replace(" ", "").Substring(0, 1).ToUpper();
            switch (inp)
            {
                case "Y": // if they did wish to use more
                    break;
                case "N": // if they didn't wish to use more
                    return;
                default:
                    return;
            }

            chooseAbilityScorePoints();
        }

        // Converts ability SCORE into ability MODIFIER
        public static int convertAbilityScoreToAbilityModifier(string ability_score_name)
        {
            // Setting tmp to a new int array where the position is the amount of ability points spent on it
            int[] tmp = new int[26] { -5, -4, -3, -2, -2, -1, -1, 0, 0, 0, 1, 1, 1, 2, 2, 2, 3, 3, 3, 3, 4, 4, 4, 4, 5, 5 };

            // itterating through each entry of the array
            for (int i = 0; i < 26; i++)
                // if the ability score is equal to i
                if (AbilityScores[ability_score_name] == i)
                    // return i position of tmp
                    return tmp[i];

            // if gets here exception is thrown
            throw new Exception();
        }
        #endregion

        #region EOA Methods
        // EOA: Ease Of Access

        // IDK What this is for
        internal static void showCharInfoGUI()
        {
            //WIP from derek?
        }

        // Any key to continue
        public static void pressAnyKeyToContinue()
        {
            // Writing dialouge: "Press any key to continue..."
            wd("Press any key to continue...", true);
            Console.ReadKey(); // Getting user to press a key
        }

        // write text w/ delay (depending on admin or not)
        public static void wd(string text, bool writeNotLine = false)
        {
            // String filteredText gets the value of text
            string filteredText = text;

            //profanitise if selected
            if (Character.Settings["Profanity"])
            {
                // 2 dimensional jagged string array for profane words
                string[][] profaneText = new string[5][] { new string[] { "hell", "fuck" }, new string[] { "flip", "fuck" }, new string[] { "darn", "damn" }, new string[] { "idiot", "dick" }, new string[] { "bloody", "fucking" } };
                
                // Itterates through profaneText
                for (int i = 0; i < profaneText.Length; i++)
                    //i replaciing good boiii with bad boiiii words iiiii
                    filteredText = filteredText.Replace(profaneText[i][0], profaneText[i][1]);
            }

            // If to do Console.Write
            if (writeNotLine) Console.Write("\n" + filteredText);

            // or Console.WriteLine
            else Console.WriteLine("\n" + filteredText);

            // If the character isn't a dev
            if (!Character.dev)
            {
                // Sleeping for the specified speech speed
                Thread.Sleep(Character.Settings["SpeechSpeed"]);
            }
        }
        #endregion
    }
}

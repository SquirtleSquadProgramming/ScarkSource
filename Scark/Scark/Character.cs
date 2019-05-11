using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace Scark
{
    class Character
    {

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
            {"ColourTheme", "dark"}
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
        
        // Ability scores dictionary for current levels (out of 25)
        private static Dictionary<string, int> aSScores = new Dictionary<string, int>()
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
        public static void addMagika(int amount)
        {
            //Change to dark or light blue and print a message to console
            if (Character.Settings["ColourTheme"] == "dark")
                Console.ForegroundColor = ConsoleColor.Blue;
            else if (Character.Settings["ColourTheme"] == "light")
                Console.ForegroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("+ " + amount.ToString() + " Magika");

            Character.magika["max"] += amount;
            revertColourScheme();

            Thread.Sleep(Character.Settings["SpeechSpeed"]);

        }

        // gives the player ability point(s)
        public static void awardAbilityPoint(int amount)
        {
            if (Character.Settings["ColourTheme"] == "dark")
                Console.ForegroundColor = ConsoleColor.Cyan;
            else if (Character.Settings["ColourTheme"] == "light")
                Console.ForegroundColor = ConsoleColor.DarkCyan ;

            if (amount == 1)
                Console.WriteLine("+ " + amount.ToString() + " Ability Point"); // singular
            else if (amount > 1)
                Console.WriteLine("+ " + amount.ToString() + " Ability Points"); // plural

            Character.abilityPoints += amount;
            revertColourScheme();

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
        public static void wd(string text, bool writeNotLine = false)
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
            if (writeNotLine) Console.Write("\n" + filteredText);
            else Console.WriteLine("\n" + filteredText);
            if (!Character.dev)
            {
                // Console.Write("[DEV: {0}]", start.Menu.dev);
                Thread.Sleep(Character.Settings["SpeechSpeed"]);
            }
        }

        // award experience points
        public static void awardXP(int amount)
        {
            //making sure maxXP is up to date
            maxXP = (level + 1) * 100;

            //Apply colours for "+ 10 xp" messages
            if (Character.Settings["ColourTheme"] == "dark")
                Console.ForegroundColor = ConsoleColor.Yellow;
            else if (Character.Settings["ColourTheme"] == "light")
                Console.ForegroundColor = ConsoleColor.DarkYellow;

            //If the player has reached max xp for that level, level up.
            if (currentXP + amount >= maxXP)
            {
                level = level + 1;
                currentXP += amount - maxXP;
                Console.WriteLine("+ " + amount.ToString() + " XP \nYou leveled up to level " + level.ToString() + "! (" + currentXP.ToString() + "/" + maxXP.ToString() + " needed to gain the next level.)");
            }
            else
            {
                currentXP += amount;
                Console.WriteLine("+ " + amount.ToString() + " XP (" + currentXP.ToString() + "/" + maxXP.ToString() + ")");
            }

            //revert back to normal colours
            revertColourScheme();

            //Make sure maxxp is up to date, again
            maxXP = (level + 1) * 100;

            Thread.Sleep(Character.Settings["SpeechSpeed"]);
        }
        
        // Void for saving the character data
        public static void save(string name)
        {
            string fileURL = Environment.CurrentDirectory + "\\" + name + ".save";
            string[] tmp = Character.dataCollection();
            string output = "";
            for (int i = 0; i < Character.dataCollection().Length; i++)
            {
                output += tmp[i];
                if (i < tmp.Length - 1) output += "§";
            }
            File.WriteAllText(fileURL, output);
        }

        // Void for reading character saves


        // Void for the choose ability score points menu
        public static void chooseAbilityScorePoints()
        {
            Console.Clear();
            bool loop = true;
            while (loop)
            {
                bool optionPicked = false;
                Console.Clear();
                Console.Write(@"{0} Ability Points Remaining
=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                                    Options:
 [STE] Stealth      : Likelihood of surprising people, avoiding danger, hiding, etc.
 [CON] Constitution : Determines HP, likelyhood of surviving sickness, etc.
 [INT] Intelligence : Ability to know about things, traps, enemies, etc.
 [CHA] Charisma     : Likelihood of persuading
 or other speech actions.
 [PER] Perception   : Ability to sense traps, find clues, etc.
 [STR] Strength     : Ability to use strength
 [ X ]   Exit         : Exit this menu
Please select an ability to add points to (Max 25 points to each ability):
> ", abilityPoints);
                string addTo = (Console.ReadLine().Replace("[", "").Replace("]", "").ToUpper() + "   ").Substring(0, 3).Replace(" ", "");
                switch (addTo)
                {
                    case "CON":
                        addTo = "constitution";
                        break;
                    case "CHA":
                        addTo = "charisma";
                        break;
                    case "INT":
                        addTo = "intelligence";
                        break;
                    case "PER":
                        addTo = "perception";
                        break;
                    case "STR":
                        addTo = "strength";
                        break;
                    case "STE":
                        addTo = "stealth";
                        break;
                    case "X":
                        return;
                }

                Console.Write(
    @"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
         Please enter the amount of points that want to add to the {0} abilty:
> ", addTo);
                int amount = Int32.Parse(Console.ReadLine());
                
                while (!(amount <= abilityPoints && amount + AbilityScores[addTo] <= 25))
                {
                    Console.Write(
@"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                         {1} exceeds either: {2} or 25!
         Please enter the amount of points that want to add to the {0} abilty:
> ", addTo, amount, abilityPoints);
                    amount = Int32.Parse(Console.ReadLine());
                }

                aSScores[addTo] += amount;
                abilityPoints -= amount;

                optionPicked = false;
                dynamic apply = false;

                while (optionPicked == false)
                {
                    Console.Write(
        @"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
Do you wish to apply these changes: Add {0} to {1} leaving you with {2}
[Y] Apply
[N] Revert changes
> ", amount, addTo, abilityPoints);
                    apply = Console.ReadLine().Replace("[", "").Replace("]", "").Replace(" ", "").Substring(0, 1).ToUpper();
                    switch (apply)
                    {
                        case "Y":
                            optionPicked = true;
                            apply = true;
                            break;
                        case "N":
                            optionPicked = true;
                            abilityPoints += amount;
                            aSScores[addTo] -= amount;
                            apply = false;
                            break;
                    }
                }

                if (apply)
                {
                    bool loop2 = true;
                    while (loop2)
                    {
                        Console.Write(
           @"=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
                      Do you wish to use more ability points?
                      [Y] Yes I do!            No Thanks! [N]
> ");
                        string inp = Console.ReadLine().Replace("[", "").Replace("]", "").Replace(" ", "").Substring(0, 1).ToUpper();
                        switch (inp)
                        {
                            case "Y":
                                loop = false;
                                loop2 = false;
                                chooseAbilityScorePoints();
                                break;
                            case "N":
                                loop2 = false;
                                return;
                        }
                    }
                }
            }
        }


        // IDK What this is for
        internal static void showCharInfoGUI()
        {

        }

        // Any key to continue
        public static void pressAnyKeyToContinue()
        {
            wd("Press any key to continue...", true);
            Console.ReadKey();
        }
    }
}

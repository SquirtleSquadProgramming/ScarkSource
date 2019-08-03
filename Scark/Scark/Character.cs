using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using Scark.ast;
using Scark.ast.items;
using Scark.ast.NPCs;
using Scark.ast.NPCs.Traders;

namespace Scark
{
    class Character
    {
        #region Character Attributes
        // Integer Variables
        public static int stage = 0; // What stage of story the player is at
        public static int ethryl = 0; // Currency
        public static int abilityPoints = 0;
        public static int level = 0; // Player level
        public static int currentXP = 0; // player's current XP
        public static int maxXP = 0; // maximum xp player can get before level up

        // String Variables
        public static string name = ""; // Name
        public static string characterClass = ""; // Race -- but race is only human tho

        // Boolean Variables
        public static bool dev = false; // If dev
        public static bool Loaded = false;

        // List for inventory
        public static List<Item> inventory = new List<Item>(); /* int is for item ID */

        // Dictionary for settings, accessed by setting in []: eg. Character.Settings["SpeechSpeed"]
        public static Dictionary<string, dynamic> Settings = new Dictionary<string, dynamic>()
        {
            {"SpeechSpeed", 4},
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

        private static string ItemListToString(List<Item> _Inventory)
        {
            string listToString = ""; // Used for converting the list to a string (for saving)
            for (int i = 0; i < inventory.Count; i++)
            {
                if (i < inventory.Count - 1)
                    listToString += inventory[i].ID + ",";
                else listToString += inventory[i].ID;
            }
            return listToString;
        }

        // Puts all character data into one
        public static string[] dataCollection()
        {
            dynamic a = Character.AbilityScores; // For EOA

            List<string> Output = new List<string>();
            Output.Add(stage.ToString());
            Output.Add(ethryl.ToString());
            Output.Add(health["max"].ToString() + "," + health["current"].ToString());
            Output.Add(magika["max"].ToString() + "," + magika["current"].ToString());
            Output.Add(level.ToString());
            Output.Add(currentXP.ToString());
            Output.Add(maxXP.ToString());
            Output.Add(name);
            Output.Add(characterClass);
            Output.Add(ItemListToString(Character.inventory));
            Output.Add(Settings["SpeechSpeed"] + "," + Settings["Profanity"] + "," + Settings["ColourTheme"] + "," + Settings["SpecialEffects"]);
            Output.Add(a["constitution"].ToString() + "," + a["charisma"].ToString() + "," + a["intelligence"].ToString() + "," + a["perception"].ToString() + "," + a["strength"].ToString() + "," + a["stealth"].ToString());
            return Output.ToArray();
        }

        public static void showCharInfoGUI() //╔ ═ ╗ ║ ╚ ╝
        {
            Console.WriteLine(@"
╔════════╗  ══════════════════════
║   __   ║  IDENTIFICATION DETAIL    
║  /..\  ║  ══════════════════════
║  \  /  ║  Issuing authority of 
║ /    \ ║  Narsk Province, Scark.
╚════════╝  ══════════════════════
                     ");
            Console.WriteLine($"NAME: {Character.name}");
            Console.WriteLine($"CLASS ID: {Character.characterClass}");
            Console.WriteLine("═════════════════════════════════");
            Console.WriteLine($"LEVEL: {Character.level}");
            Console.WriteLine($"XP: [{Character.currentXP}/{Character.maxXP}]");
            Console.WriteLine("═════════════════════════════════");
            Console.WriteLine($"ETHRYL BALANCE: {Character.ethryl}");
            Console.WriteLine("═════════════════════════════════");
            Console.WriteLine($"MAGIKA: [{Character.magika["current"]}/{Character.magika["max"]}]");
            Console.WriteLine($"HEALTH: [{Character.health["current"]}/{Character.health["max"]}]");
            Console.WriteLine("═════════════════════════════════");
            Console.WriteLine($"UNUSED ABILITY POINTS: {Character.abilityPoints}");
            Console.WriteLine($"CON: [{Character.AbilityScores["constitution"]}] CHA: [{Character.AbilityScores["charisma"]}] INT: [{Character.AbilityScores["intelligence"]}] \nPER: [{Character.AbilityScores["perception"]}] STR: [{Character.AbilityScores["strength"]}] STE: [{Character.AbilityScores["stealth"]}]");
        }

        public static void showInventory()
        {
            Console.WriteLine("\n═════════════════════════════════");
            Console.WriteLine($"{Character.name}'s INVENTORY:");
            if (Character.inventory.Count() > 0)
                foreach (Item x in Character.inventory)
                    Console.WriteLine(x.Name);
            else Console.WriteLine("Empty");
        }
        #endregion

        #region Adding Attributes
        // awards ethyrl to the player
        public static void awardEthryl(int amount)
        {
            bool sign = amount > 0;
            // If the user has special effects enabled
            EOA.ChangeToEffects(new ConsoleColor[] { ConsoleColor.Magenta, ConsoleColor.DarkMagenta });

            // Printing text feedback
            if (sign)
                Console.WriteLine("+ " + amount.ToString() + " Ethryl\n");
            else if (!sign)
                Console.WriteLine("- " + (amount * -1).ToString() + " Ethryl\n");

            // Adding the ethryl to the player
            Character.ethryl += amount;

            // Setting the foreground colour back to the default
            EOA.revertColourScheme();

            // Wait a bit (because why not) (and also incase a Console.Clear() is directly after this.)
            Thread.Sleep(1000);
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
            Console.WriteLine("+ " + amount.ToString() + " Magika\n");

            // Adding to the max amount of magika
            Character.magika["max"] += amount;

            // Changing text colour back to the original
            EOA.revertColourScheme();

            // Sleeping because a Console.Clear may follow
            Thread.Sleep(1000);
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
                Console.WriteLine("+ " + amount.ToString() + " Ability Points\n"); // plural
            else // else
                Console.WriteLine("+ " + amount.ToString() + " Ability Point\n"); // singular

            // Adding the ability points to the character
            Character.abilityPoints += amount;

            // Reverting text colour to original
            EOA.revertColourScheme();

            // Sleeping as there may be a Console.Clear after
            Thread.Sleep(1000);
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
                // If the use has ligth theme
                else if (Character.Settings["ColourTheme"] == "light")
                    Console.ForegroundColor = ConsoleColor.DarkYellow; // Setting the text colour to dark yellow
            }

            // If the player has reached max xp current level
            if (currentXP + amount >= maxXP)
            {
                level++; // Adding to the level
                currentXP += amount - maxXP; // Current XP gets what is left over after leveling up
                // Printing that you leveled up and more data about levels
                Console.WriteLine("+ " + amount.ToString() + " XP \nYou leveled up to level " + level.ToString() + "!\n(" + currentXP.ToString() + "/" + maxXP.ToString() + " needed to gain the next level.\n)");
            }
            else // If the player didn't level up
            {
                currentXP += amount; // adding amount to currentXP
                // Printing data about levels and XP
                Console.WriteLine("+ " + amount.ToString() + " XP (" + currentXP.ToString() + "/" + maxXP.ToString() + ")\n");
            }

            // revert back to normal colours
            EOA.revertColourScheme();

            // Make sure maxxp is up to date, again
            maxXP = (level + 1) * 100;

            // Waiting just incase a Console.Clear follows
            Thread.Sleep(1000);
        }
        #endregion

        #region Ability Scores
        // Void for the choose ability score points menu
        public static void chooseAbilityScorePoints()
        {
            Console.Clear();

            string addTo = Scark.ast.Other.CASP.Category();
            if (addTo == "exit") return;

            Console.Clear(); //Clearing the Console and printing the options

            // Asking the amount of points wants to add to the specified ability
            Console.Write("═══════════════════════════════════════════════════════════════════════════════════\nPlease enter the amount of points that want to add to the {0} abilty:\n> ", addTo);

            int amount = Scark.ast.Other.CASP.Amount(addTo);

            // Adding the amount to the selected ability
            AbilityScores[addTo] += amount;
            // Subtracting amount from the abilityPoints
            abilityPoints -= amount;

            bool apply = Scark.ast.Other.CASP.ApplyChanges(amount, addTo);

            if (!apply)
            {
                abilityPoints += amount; // Reversing changes
                AbilityScores[addTo] -= amount; // Reversing changes
            }

            if (!Scark.ast.Other.CASP.UseMorePoints())
                return;

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
            throw new Exception("Does not contain any integer.");
        }
        #endregion

        // EOA: Ease Of Access
        #region EOA Methods
        // Rolls an ability check
        public static bool rollCheck(string ABILITY_SCORE, int PASS_MARK) // Roll's output must be equal to higher than pass mark to suceed the check
        {
            Random rand = new Random();
            int randOutcome = rand.Next(1, 25);

            if (randOutcome + Character.convertAbilityScoreToAbilityModifier(ABILITY_SCORE) < PASS_MARK) // if outcome plus abilty modifier is less to pass mark
                return false;
            else if (randOutcome + Character.convertAbilityScoreToAbilityModifier(ABILITY_SCORE) > PASS_MARK)
                return true;
            else return false;
        }

        //Play a morbid death speel and end the game
        public static void death(string reason)
        {
            //Slow things down so the death speel is more creepy
            Character.Settings["SpeechSpeed"] = 2;
            CharacterDeath.Speel(reason);
            showCharInfoGUI();
            EOA.pressAnyKeyToContinue();
            if (CharacterDeath.lastCheckpoint())
            {
                CharacterDeath.resetStats(); // reset character
                ast.start.Menu start = new ast.start.Menu(); //initialise new menu
                start.menuSeq(); // restart
            }
            else
            {
                new ast.story().Run();
            }
        }

        internal static class CharacterDeath
        {
            // Checking if user wishes to go to last checkpoint
            internal static bool lastCheckpoint()
            {
                while (1 != 0)
                {
                    EOA.wd("Do you wish to restart from the previous checkpoint?\n> ", true);
                    switch ((Console.ReadLine().ToUpper() + " ").Substring(0, 1))
                    {
                        case "Y":
                            return false;
                        case "N":
                            return true;
                        default:
                            Console.WriteLine("That is not an option!");
                            break;
                    }
                }
                throw new NotImplementedException();
            }

            internal static void Speel(string reason)
            {
                //Morbid death speel about the relativity of reality
                EOA.wd("Your eyes fall dark, and your eyelids grow heavy.");
                EOA.wd("Though not much can be said about the darkness,");
                EOA.wd("It does not exist anyway.");
                EOA.wd("Anymore at least.");
                EOA.wd("Not for you, at least.");
                EOA.wd("Others still breathe.");
                EOA.wd("Their hearts still pump.");
                EOA.wd("Their bodies tirelessly work for the same thing.");
                EOA.wd("To live.");
                EOA.wd("But for you, your body turns still.");
                EOA.wd("What is reality, if one cannot sense it?");
                EOA.wd("What can be so real if all is so abstract?");
                EOA.wd("Mortality is so literal.");
                EOA.wd("What is reality?");
                EOA.wd("What is consciousness?");
                EOA.wd("What is the meaning of it all?");
                EOA.wd("...");
                EOA.wd("Everything falls silent.");
                EOA.wd("But nothing falls silent, because, well, silence does not exist.");
                EOA.wd("For you anyway.");
                EOA.wd("You have moven on past reality.");
                EOA.wd("Almost.");
                EOA.wd("Yet, well, reality can't possibly exist anymore. At least for the souls of the deceased.");
                EOA.wd("Or could it?");
                EOA.wd("A final beat.");
                EOA.wd("A final thought.");
                Thread.Sleep(5000);
                EOA.wd("You surrender to the void.");
                EOA.pressAnyKeyToContinue();
                Character.Settings["SpeechSpeed"] = 4;
                EOA.wd($"{Character.name} died with a level of {Character.level} because {reason}.");
                EOA.wd($"A document was left in {Character.name}'s pocket.");
            }

            // Reseting all character attributes
            internal static void resetStats()
            {
                string characterSaveFile = "";
                if (File.Exists(characterSaveFile))
                    File.Delete(characterSaveFile);
                stage = 0;
                ethryl = 0;
                abilityPoints = 0;
                level = 0;
                currentXP = 0;
                maxXP = 0;
                name = "";
                characterClass = "";
                dev = false;
                inventory = new List<Item>();
                AbilityScores = new Dictionary<string, int>()
                {
                    {"constitution", 0},
                    {"charisma", 0 },
                    {"intelligence", 0 },
                    {"perception", 0 },
                    {"strength", 0 },
                    {"stealth", 0 },
                };
                health = new Dictionary<string, int>()
                {
                    {"max", 0},
                    {"current", 0}
                };
                magika = new Dictionary<string, int>()
                {
                    {"max", 0},
                    {"current", 0}
                };
            }
        }
        #endregion

        public static void Save(string name) => ast.Other.FS.save(name);
        public static void Load(string name, bool isFileUrl = false) => ast.Other.FS.load(name, isFileUrl);
        public static void Trade(Trader Vendor) => ast.Other.Trade.With(Vendor);
    }
}

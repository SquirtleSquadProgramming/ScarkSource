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

        // List for inventory
        public static List<int /* int is for item ID */> inventory = new List<int>();

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
                Settings["SpeechSpeed"] + "," + Settings["Profanity"] + "," + Settings["ColourTheme"] + "," + Settings["SpecialEffects"],
                a["constitution"].ToString() + "," + a["charisma"].ToString() + "," +
                a["intelligence"].ToString() + ","+ a["perception"].ToString() + "," +
                a["strength"].ToString() + "," + a["stealth"].ToString()
            };
        }

        internal static void showCharInfoGUI() //╔ ═ ╗ ║ ╚ ╝
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
            Console.WriteLine("═════════════════════════════════");
            Console.WriteLine("INVENTORY:");
            if (Character.inventory.Count() > 0)
                foreach (int x in Character.inventory)
                    Console.WriteLine(ItemID.ConvertIDToString(x));
            else Console.WriteLine("Empty");
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
            Console.WriteLine("+ " + amount.ToString() + " Ethryl\n");

            // Adding the ethryl to the player
            Character.ethryl = Character.ethryl + amount;

            // Setting the foreground colour back to the default
            revertColourScheme();

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
            revertColourScheme();

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
            revertColourScheme();

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
            revertColourScheme();

            // Make sure maxxp is up to date, again
            maxXP = (level + 1) * 100;

            // Waiting just incase a Console.Clear follows
            Thread.Sleep(1000);
        }
        #endregion

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

        public static bool Loaded = false;

        // Void for reading character saves
        public static void load(string name, bool isFileUrl = false)
        {
            Character.Loaded = true;
            string[] data = new string[14];
            if (!isFileUrl)
                name = Environment.CurrentDirectory + String.Format("\\{0}.save", name);
            data = File.ReadAllText(name).Split('§');

            if (data.Length != 12)
                throw new InvalidDataException();

            Character.stage = Int32.Parse(data[0]);

            Character.ethryl = Int32.Parse(data[1]);

            Character.health["max"] = Int32.Parse(data[2].Split(',')[0]);
            Character.health["min"] = Int32.Parse(data[2].Split(',')[1]);

            Character.magika["max"] = Int32.Parse(data[3].Split(',')[0]);
            Character.magika["min"] = Int32.Parse(data[3].Split(',')[1]);

            Character.level = Int32.Parse(data[4]);
            Character.currentXP = Int32.Parse(data[5]);
            Character.maxXP = Int32.Parse(data[6]);

            Character.name = data[7];

            Character.characterClass = data[8];

            Character.inventory = new List<int>();
            foreach (string x in data[9].Split(',').ToList())
                Character.inventory.Add(Int32.Parse(x));

            Character.Settings["SpeechSpeed"] = Int32.Parse(data[10].Split(',')[0]);
            Character.Settings["Profanity"] = Boolean.Parse(data[10].Split(',')[1]);
            Character.Settings["ColourTheme"] = data[10].Split(',')[2];
            Character.Settings["SpecialEffects"] = Boolean.Parse(data[10].Split(',')[3]);

            int i = 0;
            foreach (string x in new string[] { "CON", "CHA", "INT", "PER", "STR", "STE" })
            {
                Character.AbilityScores[ast.Other.CASP.abbreviationToName(x)] = Int32.Parse(data[11].Split(',')[i]);
                i++;
            }
            Console.WriteLine(new List<int>().Count());
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
            throw new Exception();
        }
        #endregion

        #region EOA Methods
        // EOA: Ease Of Access

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

        // Any key to continue
        public static void pressAnyKeyToContinue()
        {
            // Writing dialouge: "Press any key to continue..."
            wd("Press any key to continue...", true);
            //waitFor(); // Getting user to press a key
            Console.ReadKey();
            Console.Clear();
        }

        // write text w/ delay (depending on admin or not)
        public static void wd(string text, bool writeNotLine = false, bool profanitiseIfRequired = true)
        {
            // String filteredText gets the value of text
            string filteredText = text;

            //profanitise if selected
            if (Character.Settings["Profanity"] && profanitiseIfRequired == true)
            {
                // 2 dimensional jagged string array for profane words
                string[][] profaneText = new string[5][] { new string[] { "hell", "fuck" }, new string[] { "flip", "fuck" }, new string[] { "darn", "damn" }, new string[] { "idiot", "dick" }, new string[] { "bloody", "fucking" } };
                
                // Itterates through profaneText
                for (int i = 0; i < profaneText.Length; i++)
                    //i replaciing good boiii with bad boiiii words iiiii
                    filteredText = filteredText.Replace(profaneText[i][0], profaneText[i][1]);
            }

            // If to do Console.Write
            if (writeNotLine) Console.Write(filteredText);
            // or Console.WriteLine
            else Console.WriteLine(filteredText + "\n");

            // If the character isn't a dev
            if (!Character.dev)
            {
                // Sleeping for the specified speech speed
                Thread.Sleep((text.Length * 100) / Character.Settings["SpeechSpeed"]);
            }
        }

        // Rolls an ability check
        public static bool rollCheck(string ABILITY_SCORE, int PASS_MARK) // Roll's output must be equal to higher than pass mark to suceed the check
        {
            Random rand = new Random();
            int randOutcome = rand.Next(1, 25);

            if (randOutcome + Character.convertAbilityScoreToAbilityModifier(ABILITY_SCORE) < PASS_MARK) // if outcome plus abilty modifier is less to pass mark
            {
                return false;
            }
            else if (randOutcome + Character.convertAbilityScoreToAbilityModifier(ABILITY_SCORE) > PASS_MARK)
            {
                return true;
            }
            else // error ocurred
            {
                return false;
            }
        }

        //Play a morbid death speel and end the game
        public static void death(string reason)
        {
            //Slow things down so the death speel is more creepy
            Character.Settings["SpeechSpeed"] = 2;
            CharacterDeath.Speel(reason);
            showCharInfoGUI();
            Character.pressAnyKeyToContinue();
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
                    Character.wd("Do you wish to restart from the previous checkpoint?\n> ", true);
                    switch ((Console.ReadLine().ToUpper() + " ").Substring(0,1))
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
                Character.wd("Your eyes fall dark, and your eyelids grow heavy.");
                Character.wd("Though not much can be said about the darkness,");
                Character.wd("It does not exist anyway.");
                Character.wd("Anymore at least.");
                Character.wd("Not for you, at least.");
                Character.wd("Others still breathe.");
                Character.wd("Their hearts still pump.");
                Character.wd("Their bodies tirelessly work for the same thing.");
                Character.wd("To live.");
                Character.wd("But for you, your body turns still.");
                Character.wd("What is reality, if one cannot sense it?");
                Character.wd("What can be so real if all is so abstract?");
                Character.wd("Mortality is so literal.");
                Character.wd("What is reality?");
                Character.wd("What is consciousness?");
                Character.wd("What is the meaning of it all?");
                Character.wd("...");
                Character.wd("Everything falls silent.");
                Character.wd("But nothing falls silent, because, well, silence does not exist.");
                Character.wd("For you anyway.");
                Character.wd("You have moven on past reality.");
                Character.wd("Almost.");
                Character.wd("Yet, well, reality can't possibly exist anymore. At least for the souls of the deceased.");
                Character.wd("Or could it?");
                Character.wd("A final beat.");
                Character.wd("A final thought.");
                Thread.Sleep(5000);
                Character.wd("You surrender to the void.");
                Character.pressAnyKeyToContinue();
                Character.Settings["SpeechSpeed"] = 4;
                Character.wd($"{Character.name} died with a level of {Character.level} because {reason}.");
                Character.wd($"A document was left in {Character.name}'s pocket.");
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
                inventory = new List<int>();
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
    }
}

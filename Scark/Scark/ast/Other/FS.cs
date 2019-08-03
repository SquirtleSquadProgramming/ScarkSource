using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.Other
{
    /// <summary>
    /// File System
    /// </summary>
    class FS
    {
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

            Character.inventory = new List<items.Item>();
            foreach (string x in data[9].Split(',').ToList())
                Character.inventory.Add(items.ItemID.IDToItem(Int32.Parse(x)));

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
    }
}

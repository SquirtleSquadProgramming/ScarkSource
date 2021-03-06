﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.Other
{
    /// <summary>
    /// Choose Ability Score Points
    /// </summary>
    class CASP : Character
    {
        private static bool optionPicked = false;

        public static string abbreviationToName(string input)
        {
            Dictionary<string, string> Converter = new Dictionary<string, string>()
            {
                { "CON", "constitution" },
                { "CHA", "charisma" },
                { "INT", "intelligence" },
                { "PER", "perception" },
                { "STR", "strength" },
                { "STE", "stealth" },
                { "X", "exit" }
            };
            try
            {
                return Converter[input];
            }
            catch (Exception e)
            {
                throw new NotImplementedException(e.ToString());
            }
        }

        // Choose Ability Score Points Category (For reducing complexity)
        public static string Category()
        {
            optionPicked = false; // setting optionPicked to false for later use in a while loop
            Console.Write("                             {0} Ability Points Remaining\n═══════════════════════════════════════════════════════════════════════════════════\n                                Options:\n[STE] Stealth      : Likelihood of surprising people, avoiding danger, hiding, etc.\n[CON] Constitution : Determines HP, likelyhood of surviving sickness, etc.\n[INT] Intelligence : Ability to know about things, traps, enemies, etc.\n[CHA] Charisma     : Likelihood of persuading or other speech actions.\n[PER] Perception   : Ability to sense traps, find clues, etc.\n[STR] Strength     : Ability to use strength\n[ X ]   Exit         : Exit this menu\nPlease select an ability to add points to (Max 25 points to each ability):\n> ", abilityPoints);

            // string addTo processed to give a maximum of 3 characters
            string addTo = (Console.ReadLine().Replace("[", "").Replace("]", "").ToUpper() + "   ").Substring(0, 3).Replace(" ", "");

            // Processing the (processed) input to the actual name of an ability for later use
            while (!optionPicked)
            {
                optionPicked = true; // Exiting the while loop
                try
                {
                    // Changing the abbreviation to the proper name
                    addTo = abbreviationToName(addTo);
                }
                catch
                {
                    optionPicked = false; // Making the while loop, loop again
                                          // Re asking
                    Console.Write("                              That is not an option\n                             {0} Ability Points Remaining\n═══════════════════════════════════════════════════════════════════════════════════\n                                Options:\n[STE] Stealth      : Likelihood of surprising people, avoiding danger, hiding, etc.\n[CON] Constitution : Determines HP, likelyhood of surviving sickness, etc.\n[INT] Intelligence : Ability to know about things, traps, enemies, etc.\n[CHA] Charisma     : Likelihood of persuading or other speech actions.\n[PER] Perception   : Ability to sense traps, find clues, etc.\n[STR] Strength     : Ability to use strength\n[ X ]   Exit         : Exit this menu\nPlease select an ability to add points to (Max 25 points to each ability):\n> ", abilityPoints);
                    addTo = (Console.ReadLine().Replace("[", "").Replace("]", "").ToUpper() + "   ").Substring(0, 3).Replace(" ", "");
                }
            }
            return addTo;
        }

        public static int Amount(string addTo)
        {
            // parsing the input
            optionPicked = false;
            int amount = 0;
            while (!optionPicked)
            {
                optionPicked = true;
                try
                {
                    amount = Math.Abs(Int32.Parse(Console.ReadLine()));
                }
                catch
                {
                    optionPicked = false;
                    Console.Write("                          Please enter a number!\n═══════════════════════════════════════════════════════════════════════════════════\nPlease enter the amount of points that want to add to the {0} abilty:\n> ", addTo);
                }
            }

            // loop while the user has exceeded: the amount of abilityPoints they have
            //                                   the max amount of points an ability can have
            while (!(amount <= abilityPoints && amount + AbilityScores[addTo] <= 25))
            {
                // Writing that they have exceeded an amount
                Console.Write("═══════════════════════════════════════════════════════════════════════════════════\n                        {1} exceeds either: {2} or 25!\nPlease enter the amount of points that want to add to the {0} abilty:\n> ", addTo, amount, abilityPoints);

                // Re-getting their input
                try
                {
                    amount = Math.Abs(Int32.Parse(Console.ReadLine()));
                }
                catch
                {
                    Console.Write("                             That is not a number!\n");
                }
            }
            return amount;
        }

        public static bool ApplyChanges(int amount, string addTo)
        {
            // setting optionPicked to false as to reuse it
            optionPicked = false;
            dynamic apply = false; // dynamic variable apply to false

            // Looping until the user picks Y/N
            while (optionPicked == false)
            {
                // Asking if they wish to apply the changes
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════\nDo you wish to apply these changes: Add {0} to {1} leaving you with {2}\n[Y] Apply\n[N] Revert changes\n> ", amount, addTo, abilityPoints);
                
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y: // If they picked yes
                        optionPicked = true; // Exiting while loop
                        return true; // Setting apply(dynamic) to true
                    case ConsoleKey.N: // If they picked no
                        optionPicked = true; // Exiting while loop
                        return false; // Setting apply(dynamic) to false
                }
            }

            throw new NotImplementedException();
        }

        public static bool UseMorePoints()
        {
            optionPicked = false;
            while (!optionPicked)
            {
                optionPicked = true;
                // Asking if they wish to use more ability points
                Console.Write("\n═══════════════════════════════════════════════════════════════════════════════════\n                Do you wish to use more ability points?\n                [Y] Yes I do!            No Thanks! [N]\n> ");

                // Getting their input
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Y: // if they did wish to use more
                        return true;
                    case ConsoleKey.N: // if they didn't wish to use more
                        return false;
                    default:
                        optionPicked = false;
                        continue;
                }
            }
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Scark
{
    /// <summary>
    /// Functions for ease of access
    /// </summary>
    public static class EOA
    {
        /// <summary>
        /// Function to change console colours to special colours
        /// </summary>
        /// <param name="Colours">Array of colours in format of: [DarkThemeColour, LightThemeColour]</param>
        public static void ChangeToEffects(ConsoleColor[] Colours)
        {
            if (Character.Settings["SpecialEffects"])
            {
                // If the users theme is dark mode
                if (Character.Settings["ColourTheme"] == "dark")
                    Console.ForegroundColor = Colours[0]; // Setting the colour to magenta
                // If the users theme is light mode
                else if (Character.Settings["ColourTheme"] == "light")
                    Console.ForegroundColor = Colours[1]; // Setting the colour to a dark magenta
            }
        }

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

            wdExtn(filteredText, writeNotLine);
        }

        public static void subtractHealth(int amount)
        {
            Character.health["max"] -= amount;
            // If the user has special effects enabled
            EOA.ChangeToEffects(new ConsoleColor[] { ConsoleColor.Red, ConsoleColor.DarkRed });

            Console.WriteLine($"- {0} health!", amount.ToString());

            // Setting the foreground colour back to the default
            EOA.revertColourScheme();

            // Wait a bit (because why not) (and also incase a Console.Clear() is directly after this.)
            Thread.Sleep(1000);
        }

        private static void wdExtn(string text, bool writeNotLine)
        {
            // If to do Console.Write
            if (writeNotLine) Console.Write(text);
            // or Console.WriteLine
            else Console.WriteLine(text + "\n");

            // If the character isn't a dev
            if (!Character.dev)
            {
                // Sleeping for the specified speech speed
                Thread.Sleep((text.Length * 100) / Character.Settings["SpeechSpeed"]);
            }
        }

        public static void WriteAt(string Text, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(Text);
        }
    }
}

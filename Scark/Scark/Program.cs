﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Scark.ast;
using System.Runtime.InteropServices;
using System.IO;

namespace Scark
{
    class Program
    {
        public readonly static string gameVersion = "v0.2.4-alpha"; // game version variable

        const uint ENABLE_QUICK_EDIT = 0x0040;

        // STD_INPUT_HANDLE (DWORD): -10 is the standard input device.
        const int STD_INPUT_HANDLE = -10;

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern IntPtr GetStdHandle(int nStdHandle);

        [DllImport("kernel32.dll")]
        static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        [DllImport("kernel32.dll")]
        static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);

        internal static bool Go()
        {
            IntPtr consoleHandle = GetStdHandle(STD_INPUT_HANDLE);

            // get current console mode
            uint consoleMode;
            if (!GetConsoleMode(consoleHandle, out consoleMode))
            {
                // ERROR: Unable to get console mode.
                return false;
            }

            // Clear the quick edit bit in the mode flags
            consoleMode &= ~ENABLE_QUICK_EDIT;

            // set the new mode
            if (!SetConsoleMode(consoleHandle, consoleMode))
            {
                // ERROR: Unable to set console mode
                return false;
            }

            return true;
        }

        #pragma warning disable CS0162

        public static void Main(string[] args)
        {
            Console.Title = "Scark";
            Go();
            //Used To Remove Warnings 
            Console.Clear();

            // If the user started the program with a file
            if (args.Length > 0)
                if (args[0] != "")
                    Character.Load(args[0], true);

            // converting the start main function to a non - static
            ast.start.Menu start = new ast.start.Menu();
            start.menuSeq(); // starting the main function

            Console.Write("Press any key to exit...");
            Console.ReadKey();
        }
    }
}

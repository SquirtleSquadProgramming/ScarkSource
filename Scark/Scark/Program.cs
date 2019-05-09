using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Scark.ast;

namespace Scark
{
    class Program
    {
        public readonly static string gameVersion = "v0.1.4-alpha"; // game version variable

        public static void Main(string[] args)
        {
            //Used To Remove Warnings 
            Console.Clear();
            // converting the start main function to a non - static
            ast.start.Menu start = new ast.start.Menu();
            start.menuSeq(); // starting the main function

            Console.Write("Press any key to exit...");
            Console.Read();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.encdec
{
    public class BiCoder
    {
        public static void encStrToNum(string inputString)
        {
            byte[] input = Encoding.ASCII.GetBytes(inputString);
            // List<int> output = new List<int>; 
            foreach (int x in input)
            {
                Console.WriteLine(input[x].ToString());
            }
        }
    }
}

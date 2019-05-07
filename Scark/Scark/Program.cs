using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark
{
    class Program
    {
        //Temp Comment For Build
        //SaveSys Save = new SaveSys(); // intializing the save system
        const string gameVersion = "v0.0.0"; // game version variable
        Dictionary<string, int> charcterdata = new Dictionary<string, int>() // dictionary of local save's data
	    {
            {"ethryl", 0}, // currency
		    {"health", 0},  // health
		    {"characterType", 0}, // character type
		    {"nickName", 0} // character name (encoded)  TODO: create encoder/decoder
 	    };

        public static void Main(string[] args)
        {
            //Used To Remove Warnings 
            Console.Clear();
            // converting the start main function to a non - static
            Menu start = new Menu();
            start.menuSeq(); // starting the main function

            //Temp Comments
            //	bicoder BiCoder = new bicoder();
            //	BiCoder.encStrToNum("abcdefghjiklmnopqrstuvwxyz");
        }
    }
}

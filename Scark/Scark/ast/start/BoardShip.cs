using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.start
{
    class BoardShip
    {
        public string[] aboardShip(string[] charinf, bool dev)
        {
            Console.WriteLine(@"                    |
                    |
             |    __-__
           __-__ /  | (
          /  | ((   | |
        /(   | ||___|_.  .|
      .' |___|_|`---|-'.' (
 '-._/_| (   |\     |.'    \
     '-._|.-.|-.    |'-.____'.
         |------------------'
          `----------------'");


            charinf[2] = "2"; // Continuing story
            return charinf;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Scark.ast;

namespace Scark.ast.narsk
{
    public class TowardsMedallion
    {
        public bool lookedInBarrel = false;
        public bool noticedBarrel = false;
        public bool tryNoticedBarrel = false; // if player has tried to notice barrel already

        public void towardsMedallion()
        {
            if (Character.Settings["SpecialEffects"])
            {
                Character.wd(@"                                                     ___
                                             ___..--'  .`.
                                    ___...--'     -  .` `.`.
                           ___...--' _      -  _   .` -   `.`.
                  ___...--'  -       _   -       .`  `. - _ `.`.
           __..--'_______________ -         _  .`  _   `.   - `.`.
        .`    _ /\    -        .`      _     .`__________`. _  -`.`.
      .` -   _ /  \_     -   .`  _         .` |    The    |`.   - `.`.
    .`-    _  /   /\   -   .`        _   .`   |_Medallion_|  `. _   `.`.
  .`________ /__ /_ \____.`____________.`     ___       ___  - `._____`|
    |   -  __  -|    | - |  ____  |   | | _  |   |  _  |   |  _ |
    | _   |  |  | -  |   | |.--.| |___| |    |___|     |___|    |
    |     |--|  |    | _ | |'--'| |---| |   _|---|     |---|_   |
    |   - |__| _|  - |   | |.--.| |   | |    |   |_  _ |   |    |
 ---``--._      |    |   |=|'--'|=|___|=|====|___|=====|___|====|
 -- . ''  ``--._| _  |  -|_|.--.|_______|_______________________|
`--._           '--- |_  |:|'--'|:::::::|:::::::::::::::::::::::|
_____`--._ ''      . '---'``--._|:::::::|:::::::::::::::::::::::|
----------`--._          ''      ``--.._|:::::::::::::::::::::::|
`--._ _________`--._'        --     .   ''-----..............LGB'
     `--._----------`--._.  _           -- . :''           -    ''
          `--._ _________`--._ :'              -- . :''      -- . ''
 -- . ''       `--._ ---------`--._   -- . :''
          :'        `--._ _________`--._:'  -- . ''      -- . ''
  -- . ''     -- . ''    `--._----------`--._      -- . ''     -- . ''
                              `--._ _________`--._
 -- . ''           :'              `--._ ---------`--._-- . ''    -- . ''
          -- . ''       -- . ''         `--._ _________`--._   -- . ''
:'                 -- . ''          -- . ''  `--._----------`--._");
            }
            
            Character.wd("You walk along a narrow path for five or so minutes until you arrive at a wooden building.");
            Character.wd("A battered sign hangs on a wall, reading \"The Medallion\"");

            towardsMedallionPrompt();
        }

        private void towardsMedallionPrompt()
        {
            Character.wd("[1] Go inside\n[2] Look around");
            Console.Write("> ");
            string response = Console.ReadLine();

            switch (response.ToLower())
            {


                case "1":
                    Character.wd("You walk up to the handsome mahogany door and push it open.");
                    break;
                case "2":

                    // ERROR START ===========================================================================================================
                    if (Character.rollCheck("perception", 10) == false) //if check failed
                    {
                        Character.wd("You look around the building. Nothing seems out of place.");
                        tryNoticedBarrel = true;
                        Console.ReadKey();
                    }
                    else if (tryNoticedBarrel == true) // ERROR - DOESNT WORK, STILL SOMETIMES SAYS THE FOUND BARREL OUTCOME
                    {
                        Character.wd("You look around the building. Nothing seems out of place.");
                        tryNoticedBarrel = true;
                        Console.ReadKey();
                    }
                    else
                    {
                        Character.wd("You look around the building and see a large wooden barrel on its side, its lid slightly ajar.");
                        noticedBarrel = true;
                        tryNoticedBarrel = true; // VARIABLE PART OF ERROR
                        Console.ReadKey();
                    }
                    break;
                    // ERROR END ======================================================================================================================================
            }
        }
    }
}

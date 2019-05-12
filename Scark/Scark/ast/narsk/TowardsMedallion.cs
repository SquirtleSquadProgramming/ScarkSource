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
        
        public void towardsMedallionPrompt(bool NOTICED_BARREL = false, bool TRY_NOTICED_BARREL = false, bool LOOKED_IN_BARREL = false)
        {
            if (NOTICED_BARREL)
                Character.wd("[1] Go Inside\n[2] Look around\n[3] Look in barrel");
            else
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
                        TRY_NOTICED_BARREL = true;
                        Console.ReadKey();
                    }
                    else if (TRY_NOTICED_BARREL == true) // ERROR - DOESNT WORK, STILL SOMETIMES SAYS THE FOUND BARREL OUTCOME
                    {
                        Character.wd("You look around the building. Nothing seems out of place.");
                        TRY_NOTICED_BARREL = true;
                        Console.ReadKey();
                    }
                    else if (Character.rollCheck("perception", 10) == true)
                    {
                        Character.wd("You look around the building and see a large wooden barrel on its side, its lid slightly ajar.");
                        NOTICED_BARREL = true;
                        TRY_NOTICED_BARREL = true; // VARIABLE PART OF ERROR
                        Console.ReadKey();
                    }
                    break;
                    // ERROR END =============================================================================================================
            }
        } 

        private void towardsMedallfionPrompt(bool NOTICED_BARREL = false, bool TRY_NOTICED_BARREL = false, bool LOOKED_IN_BARREL = false)
        {
            //TODO Add stuff here
        }
    }
}

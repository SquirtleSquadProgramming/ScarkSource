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
            Character.wd("You arrive in the wonderful vibrant city of Narsk, people are trading and chattering and the whole place seems overly happy.");
            Character.wd("A strange man walks up to you with a slight limp.");
            Character.wd("[OLD MAN] Welcome dear lad, I welcome you to narsk.");
            Character.wd("[OLD MAN] If you can't already tell, it is becoming quite steamy out here in the sun.");
            Character.wd("[OLD MAN] Therefore I shall be brief.");
            Character.wd($"[OLD MAN] I have come to ask if you go by the name of {Character.name}");
            Character.wd($"[1] Yes, I am {Character.name}\n[2] No, I am not {Character.name}");
            Console.Write(">");
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    Character.wd("[OLD MAN] Ah good!");
                    Character.wd("[OLD MAN] I am possibly the only one in a 20 klick distance that doesn't hate you right now.");
                    Character.wd("[OLD MAN] Don't talk to anyone chunky, I have heard the thugs around here are a tad patriotic.");
                    break;
                case "2":
                default:
                    Character.wd("[OLD MAN] Oh well.");
                    Character.wd("[OLD MAN] You will have to do.");
                    Character.wd("[OLD MAN] I didn't really like the other chap anyway.");
                    Character.wd("[OLD MAN] Did you hear what he did to the king?");
                    Character.wd("...");
                    Character.wd("[OLD MAN] Aight, I have got something for you.");
                    break;
            }

            Character.wd("The old man hands you a scroll.");

            Character.pressAnyKeyToContinue();

            if (MedallionAntiComplex.mission())
                return;

            Character.pressAnyKeyToContinue();

            MedallionAntiComplex.barrelAndEnter.run();
        }

        internal class MedallionAntiComplex
        {
            static bool Loop = true;

            public static bool mission()
            {
                Loop = true;
                while (Loop)
                {
                    Console.WriteLine(@"   _______________________
   \                      \
    \  To the dear soul    \
     | reading this,        |
     |                      |
     | I am in need of help.|
     | I cannot talk about  |
     | this ordeal outloud, |
     | thus I give you this |
    / scroll.              /
   '                      '
  / This town is cursed. /
 | I have a mission for |
 | you. Acceptance will |
 \  be paid richly.     \
  \______________________\");
                    Character.wd($"[OLD MAN] So what do you say, {Character.name}, will you join me in business.");
                    Character.wd($"[1] Sounds like a mission for me.\n[2] I don't want to do this.");
                    Console.Write(">");
                    string response = Console.ReadLine();
                    switch (response)
                    {
                        case "1":
                            Character.wd("[OLD MAN] Splendid!");
                            Character.wd("[OLD MAN] I bid you to go to the medallion.");
                            Character.wd("[OLD MAN] If you have already met Lord Wakeheart, you should know that he has bestowed much honour in a young florentine name Orpheus.");
                            Character.wd("[OLD MAN] He is the informant to our association around here, you will find him at the good ol' medallion.");
                            Character.wd("[OLD MAN] You best get there prior to nightfall,");
                            Character.wd("[OLD MAN] The chunkys loom out here when the night falls silent.");
                            Character.wd("[OLD MAN] Pints is half off aswell, if it tickles ye fancy.");
                            break;
                        case "2":
                            Character.wd("[OLD MAN] Oh my.");
                            Character.wd("[OLD MAN] You are a brave soul to say such a thing.");
                            Character.wd("Suddenly the Old Mans voice drops and pitch.");
                            Character.wd("[OLD MAN] Those who wish to cross my mission, shall be rewarded with death.");
                            Character.wd("His pupils dilate, his skin is a pale white.");
                            Character.wd("His hands reach onto your shoulders.");
                            Character.wd("[OLD MAN] You cannot live knowing that I wish to cross those who burden our society.");
                            Character.wd("His fingers grow sharp, and puncture into your shoulders.");
                            Character.wd("You collapse to the ground, the man on top of you.");
                            Character.wd("The old man breathes in, you feel your soul escaping from your body.");
                            Character.wd("You enter his mouth leaving a lifeless body behind.");
                            Character.wd("You can't feel anything anymore.");
                            Character.pressAnyKeyToContinue();
                            Console.Clear();
                            Character.death("you dared to cross the dark sourcerer.");
                            return true;
                        default:
                            Console.Clear();
                            Console.Write("{0} is not an option! Please input either 1 or 2...", response);
                            break;
                    }
                }
                return false;
            }

            internal class barrelAndEnter
            {
                private static bool NOTICED_BARREL = false, TRY_NOTICED_BARREL = false, LOOKED_IN_BARREL = false, Loop = true;

                public static void run()
                {
                    while (Loop)
                    {
                        Console.Clear();

                        bAHPrints.optionAHPrints();
                        Console.Write("> ");
                        string response = Console.ReadLine();

                        switch (response.ToLower())
                        {
                            case "1":
                                Character.wd("You walk up to the handsome mahogany door and push it open.");
                                Loop = false;
                                break;
                            case "2":
                            case "3":
                                bAHPrints.perceptionPrints();
                                break;
                        }
                    }
                }

                internal class bAHPrints
                {
                    internal static void optionAHPrints()
                    {
                        if (Character.Settings["SpecialEffects"])
                            Console.WriteLine(@"                                                     ___
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

                        if (!NOTICED_BARREL && !TRY_NOTICED_BARREL && !LOOKED_IN_BARREL)
                        {
                            Character.wd("You walk along a narrow path for five or so minutes until you arrive at a wooden building.");
                            Character.wd("A battered sign hangs on a wall, reading \"The Medallion\"");
                        }

                        if (NOTICED_BARREL && !LOOKED_IN_BARREL) Character.wd("[1] Go Inside\n[2] Look around\n[3] Look in barrel");
                        else if (LOOKED_IN_BARREL) Character.wd("[1] Go inside");
                        else Character.wd("[1] Go inside\n[2] Look around");
                    }

                    internal static void perceptionPrints()
                    {
                        if (NOTICED_BARREL && !LOOKED_IN_BARREL)
                        {
                            /* =-=-=-=-=-=-=-=-=-=-= TODO ADD STUF HERE =-=-=-=-=-=-=-=-=-=-= */
                            Character.wd("You open the barrel to find ----");
                            /* =-=-=-=-=-=-=-=-=-=-= TODO ADD STUF HERE =-=-=-=-=-=-=-=-=-=-= */
                            LOOKED_IN_BARREL = true;
                            /* =-=-=-=-=-=-=-=-=-=-= TODO ADD STUF HERE =-=-=-=-=-=-=-=-=-=-= */
                            Console.ReadKey();
                            /* =-=-=-=-=-=-=-=-=-=-= TODO ADD STUF HERE =-=-=-=-=-=-=-=-=-=-= */
                        }
                        else if (!Character.rollCheck("perception", 10) && !LOOKED_IN_BARREL) //if check failed
                        {
                            Character.wd("You look around the building. Nothing seems out of place.");
                            TRY_NOTICED_BARREL = true;
                            Console.ReadKey();
                        }
                        else if (TRY_NOTICED_BARREL && !LOOKED_IN_BARREL)
                        {
                            Character.wd("You look around the building. Nothing seems out of place.");
                            TRY_NOTICED_BARREL = true;
                            Console.ReadKey();
                        }
                        else if (Character.rollCheck("perception", 10) && !LOOKED_IN_BARREL)
                        {
                            Character.wd("You look around the building and see a large wooden barrel on its side, its lid slightly ajar.");
                            NOTICED_BARREL = true;
                            TRY_NOTICED_BARREL = true;
                            Console.ReadKey();
                        }
                    }
                }
            }
        }
    }
}

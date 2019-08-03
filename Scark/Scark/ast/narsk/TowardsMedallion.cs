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
            Character.wd("You arrive in the wonderful and vibrant city of Narsk."); 
            Character.wd("People are trading and chattering and the whole place seems overly joyful and energetic.");
            Character.wd("As you walk through the many market stalls and shops of the city, a strange man walks up to you with a slight limp.");
            Character.wd("[OLD MAN] Ah, w-w-welcome dear lad, I welcome you to Narsk.");
            Character.wd("[OLD MAN] If you can't already t-tell, it is becoming quite st-teamy out here in the sun.");
            Character.wd("[OLD MAN] Therefore I shall b-be brief.");
            Character.wd($"[OLD MAN] A-a-are you {Character.name}?");
            Character.wd($"[1] Yes, I am {Character.name}\n[2] No, I am not {Character.name}");
            Console.Write("> ");
            string response = Console.ReadLine();

            switch (response)
            {
                case "1":
                    Character.wd("[OLD MAN] Ah, good!");
                    Character.wd("[OLD MAN] I am p-p-possibly the only one in a 20 klick distance that doesn't hate you r-right now.");
                    Character.wd("[OLD MAN] T-try not t-to talk to the chunkys, I have heard the thugs around here are rather p-patriotic.");
                    break;
                case "2":
                default:
                    Character.wd("[OLD MAN] Oh well.");
                    Character.wd("[OLD MAN] You will h-have to do.");
                    Character.wd($"[OLD MAN] I didn't really like the {Character.name} chap anyway.");
                    Character.wd("[OLD MAN] Did you hear what he d-did to the king?");
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
            Character.save(Character.name);

            Character.wd("[LOONIE] Huh, boys look who we 'av 'ere");
            Character.wd("[LOONIE] A lil boatie!");
            Character.wd("[LOONIE] How bouts you get your ass out of ere");
            Character.wd("A group of bar thugs gather around you.. ");
            Character.wd("[LOONIE] What do ye 'av on you?");
            Character.wd("The thug shoves you onto the ground.. ");
            Character.wd("[LOONIE] Not a talker aye? Well it aint matter matter to me.");
            Character.wd("[LOONIE] I want yer ethryl and any other dazzle you may 'av");
            Character.wd("[LOONIE] Make it choppy before I send my elbow up yer as.");
            Character.pressAnyKeyToContinue();

            if (Character.rollCheck("charisma", 14))
            {
                Character.wd("You stand back up and confront the thug.");
                Character.wd("After noticing the ring on his hand, you talk to him about what his wife would think of his opression.");
                Character.wd("He calms down and moves to the side, signalling the rest of the gang off.");
                Character.wd("You were saved by your charisma this time.");
            }
            else
            {
                Character.wd("You try talking the thug out of this, but your charisma fails you..");
                if (MedallionAntiComplex.mugging())
                    return;
            }
            Character.wd("You scurry past the thugs to the front of the bar.");
            Character.wd("[ORPHEUS] He-llo fine chap!");
            Character.wd("[ORPHEUS] Wh-at might bring you here?");
        }

        internal class MedallionAntiComplex
        {
            static bool Loop = true;

            public static bool mission()
            {
                while (1 != 0)
                {
                    Console.WriteLine(@"   _______________________
   \                      \
    \  To the dear soul    \
     | reading this,        |
     |                      |
     | I am in need of help.|
     | I cannot talk about  |
     | this ordeal aloud,   |
     | thus I give you this |
    / scroll.              /
   ;                      ;
  / This town is cursed. /
 | I have a mission for |
 | you. Acceptance will |
 \  be paid richly.     \
  \______________________\");
                    Character.wd($"[OLD MAN] So what d-do you say, {Character.name}, will you join me in m-my business?");
                    Character.wd($"[1] Sounds like a mission for me.\n[2] I don't want to do this.");
                    Console.Write(">");
                    string response = Console.ReadLine();
                    switch (response)
                    {
                        case "1":
                            Character.wd("[OLD MAN] Splendid!");
                            Character.wd("[OLD MAN] I bid you to go to the medallion.");
                            Character.wd("[OLD MAN] If you have already met Lord Wakeheart, you should know t-that he has bestowed much honour in a young b-barman named Orpheus.");
                            Character.wd("[OLD MAN] He is the informant to our association around here, and you will find him at the good ol' Medallion t-tavern.");
                            Character.wd("[OLD MAN] You best get there prior to nightfall,");
                            Character.wd("[OLD MAN] The chunkys loom out here when the night falls silent.");
                            Character.wd("[OLD MAN] Mead is half off as well, if it tickles your fancy.");
                            return false;
                        case "2":
                            Character.wd("[OLD MAN] Oh my.");
                            Character.wd("[OLD MAN] You are a brave soul to say such a thing.");
                            Character.wd("Suddenly the Old Mans voice drops an octave, and his breathing makes a rattling noise.");
                            Character.wd("[OLD MAN] Those who wish to cross my mission, shall be rewarded with death.");
                            Character.wd("His pupils dilate, his skin is a pale white.");
                            Character.wd("His hands reach onto your shoulders.");
                            Character.wd("[OLD MAN] You cannot live knowing that I wish to cross those who burden our society.");
                            Character.wd("His fingers grow sharp, and puncture into your shoulders.");
                            Character.wd("You collapse to the ground, the man on top of you.");
                            Character.wd("The old man breathes in, you feel your soul escaping from your body.");
                            Character.wd("You enter his mouth leaving a lifeless body behind.");
                            Character.wd("You can't feel anything anymore."); // this sounds like a Harry Potter dementor knowckoff
                            Character.pressAnyKeyToContinue();
                            Console.Clear();
                            Character.death("you dared to cross the dark sorcerer."); // death already...? maybe make it so that you DONT die lmao
                            return true;
                        default:
                            Console.Clear();
                            Console.Write("{0} is not an option! Please input either 1 or 2...", response);
                            break;
                    }
                }
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

            public static bool mugging()
            {
                Character.wd("[LOONIE] Gimme it all!");
                Character.wd("You reach for your pocket.. \n");
                Character.wd($"You have {Character.ethryl} ethryl. You can either give him your entire worth, or lie and give him only half.");
                Character.wd("[1] Surrender all of your ethryl\n[2] Lie and give him only half of it.");
                Console.Write("> ");

                switch (Console.ReadLine())
                {
                    default:
                        Character.awardEthryl(Character.ethryl * -1);
                        Character.wd("They didn't accept your answer and they steal your leather wallet anyway.");
                        return false;
                    case "1":
                        Character.awardEthryl(Character.ethryl * -1);
                        Character.wd("You break the bank, and hand over your leather wallet to the thug.");
                        return false;
                    case "2":
                        Character.awardEthryl((Character.ethryl / 2) * -1);
                        Character.wd("You reach for your wallet, but take only a few ethryl.");
                        Character.wd("[LOONIE] Is that all you av?");
                        if (Character.rollCheck("stealth", 5))
                        {
                            Character.wd("The thug looks at you suspiciously.");
                            Character.wd("You stare back with a blank poker face, your stomach in knots.");
                            Character.wd("Your stealth saved you this time.");
                            return false;
                        }
                        else
                        {
                            Character.wd("The thug stares at you.");
                            Character.wd("In nervous shock your hand trembles and the thug leans closer.");
                            Character.wd("[LOONIE] You look a lil pale there kiddo.");
                            Character.wd("[LOONIE] How abouts you give me your whole wallet.");
                            Character.wd("The thug's companions shuffle around, and you feel a cold pain around the side of your head.");
                            Character.wd("[LOONIE] Hehehe, some people just don't leeaar--");
                            Character.wd("Darkness.");
                                Character.death("you tried to con a thug in his own game.");
                                return true;
                        }
                }
            }
        }
    }
}

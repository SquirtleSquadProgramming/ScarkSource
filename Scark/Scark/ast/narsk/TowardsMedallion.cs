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
            EOA.wd("You arrive in the wonderful and vibrant city of Narsk."); 
            EOA.wd("People are trading and chattering and the whole place seems overly joyful and energetic.");
            EOA.wd("As you walk through the many market stalls and shops of the city, a strange man walks up to you with a slight limp.");
            EOA.wd("[OLD MAN] Ah, w-w-welcome dear lad, I welcome you to Narsk.");
            EOA.wd("[OLD MAN] If you can't already t-tell, it is becoming quite st-teamy out here in the sun.");
            EOA.wd("[OLD MAN] Therefore I shall b-be brief.");
            EOA.wd($"[OLD MAN] A-a-are you {Character.name}?");
            EOA.wd($"[1] Yes, I am {Character.name}\n[2] No, I am not {Character.name}");
            Console.Write("> ");

            bool Loop = true;
            while (Loop)
            {
                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        EOA.wd("\n[OLD MAN] Ah, good!");
                        EOA.wd("[OLD MAN] I am p-p-possibly the only one in a 20 klick distance that doesn't hate you r-right now.");
                        EOA.wd("[OLD MAN] T-try not t-to talk to the chunkys, I have heard the thugs around here are rather p-patriotic.");
                        Loop = false;
                        break;
                    default:
                        Console.WriteLine("\nPlease select an option!");
                        continue;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        EOA.wd("\n[OLD MAN] Oh well.");
                        EOA.wd("[OLD MAN] You will h-have to do.");
                        EOA.wd($"[OLD MAN] I didn't really like the {Character.name} chap anyway.");
                        EOA.wd("[OLD MAN] Did you hear what he d-did to the king?");
                        EOA.wd("...");
                        EOA.wd("[OLD MAN] Aight, I have got something for you.");
                        Loop = false;
                        break;
                }
            }

            EOA.wd("The old man hands you a scroll.");

            EOA.pressAnyKeyToContinue();

            if (MedallionAntiComplex.mission())
                return;

            EOA.pressAnyKeyToContinue();

            MedallionAntiComplex.barrelAndEnter.run();
            Character.Save(Character.name);

            EOA.wd("[LOONIE] Huh, boys look who we 'av 'ere");
            EOA.wd("[LOONIE] A lil boatie!");
            EOA.wd("[LOONIE] How bouts you get your ass out of ere");
            EOA.wd("A group of bar thugs gather around you.. ");
            EOA.wd("[LOONIE] What do ye 'av on you?");
            EOA.wd("The thug shoves you onto the ground.. ");
            EOA.wd("[LOONIE] Not a talker aye? Well it aint matter matter to me.");
            EOA.wd("[LOONIE] I want yer ethryl and any other dazzle you may 'av");
            EOA.wd("[LOONIE] Make it choppy before I send my elbow up yer as.");
            EOA.pressAnyKeyToContinue();

            if (Character.rollCheck("charisma", 14))
            {
                EOA.wd("You stand back up and confront the thug.");
                EOA.wd("After noticing the ring on his hand, you talk to him about what his wife would think of his opression.");
                EOA.wd("He calms down and moves to the side, signalling the rest of the gang off.");
                EOA.wd("You were saved by your charisma this time.");
            }
            else
            {
                EOA.wd("You try talking the thug out of this, but your charisma fails you..");
                if (MedallionAntiComplex.mugging())
                    return;
            }
            EOA.wd("You scurry past the thugs to the front of the bar.");
            EOA.wd("[ORPHEUS] He-llo fine chap!");
            EOA.wd("[ORPHEUS] Wh-at might bring you here?");
        }

        internal class MedallionAntiComplex
        {
            public static bool mission()
            {
                while (true)
                {
                    Console.WriteLine(@"
   _______________________
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
                    EOA.wd($"[OLD MAN] So what d-do you say, {Character.name}, will you join me in m-my business?");
                    EOA.wd($"[1] Sounds like a mission for me.\n[2] I don't want to do this.");
                    Console.Write("> ");
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.D1:
                        case ConsoleKey.NumPad1:
                            EOA.wd("\n[OLD MAN] Splendid!");
                            EOA.wd("[OLD MAN] I bid you to go to the medallion.");
                            EOA.wd("[OLD MAN] If you have already met Lord Wakeheart, you should know t-that he has bestowed much honour in a young b-barman named Orpheus.");
                            EOA.wd("[OLD MAN] He is the informant to our association around here, and you will find him at the good ol' Medallion t-tavern.");
                            EOA.wd("[OLD MAN] You best get there prior to nightfall,");
                            EOA.wd("[OLD MAN] The chunkys loom out here when the night falls silent.");
                            EOA.wd("[OLD MAN] Mead is half off as well, if it tickles your fancy.");
                            return false;
                        case ConsoleKey.D2:
                        case ConsoleKey.NumPad2:
                            EOA.wd("\n[OLD MAN] Oh my.");
                            EOA.wd("[OLD MAN] You are a brave soul to say such a thing.");
                            EOA.wd("Suddenly the Old Mans voice drops an octave, and his breathing makes a rattling noise.");
                            EOA.wd("[OLD MAN] Those who wish to cross my mission, shall be rewarded with death.");
                            EOA.wd("His pupils dilate, his skin is a pale white.");
                            EOA.wd("His hands reach onto your shoulders.");
                            EOA.wd("[OLD MAN] You cannot live knowing that I wish to cross those who burden our society.");
                            EOA.wd("His fingers grow sharp, and puncture into your shoulders.");
                            EOA.wd("You collapse to the ground, the man on top of you.");
                            EOA.wd("The old man breathes in, you feel your soul escaping from your body.");
                            EOA.wd("You enter his mouth leaving a lifeless body behind.");
                            EOA.wd("You can't feel anything anymore."); // this sounds like a Harry Potter dementor knowckoff
                            EOA.pressAnyKeyToContinue();
                            Console.Clear();
                            Character.death("you dared to cross the dark sorcerer."); // death already...? maybe make it so that you DONT die lmao
                            return true;
                        default:
                            EOA.wd("\nPlease enter 1 or 2!");
                            continue;
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

                        switch (Console.ReadKey().Key)
                        {
                            case ConsoleKey.D1:
                            case ConsoleKey.NumPad1:
                                EOA.wd("\nYou walk up to the handsome mahogany door and push it open.");
                                Loop = false;
                                break;
                            case ConsoleKey.D2:
                            case ConsoleKey.NumPad2:
                            case ConsoleKey.D3:
                            case ConsoleKey.NumPad3:
                                Console.Write("\n");
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
                            EOA.wd("You walk along a narrow path for five or so minutes until you arrive at a wooden building.");
                            EOA.wd("A battered sign hangs on a wall, reading \"The Medallion\"");
                        }

                        if (NOTICED_BARREL && !LOOKED_IN_BARREL) EOA.wd("[1] Go Inside\n[2] Look around\n[3] Look in barrel");
                        else if (LOOKED_IN_BARREL) EOA.wd("[1] Go inside");
                        else EOA.wd("[1] Go inside\n[2] Look around");
                    }

                    internal static bool loop = false;

                    private static void takeItem()
                    {
                        loop = true;
                        while (loop)
                        {
                            items.Item.showItemInfoGUI(items.ItemID.IDToItem(5));
                            EOA.wd("Would you like to take the tomahawk? Y or N");

                            switch (Console.ReadKey().Key)
                            {
                                case ConsoleKey.Y:
                                    EOA.wd("\nThe tomahawk has been added to your inventory.");
                                    Character.inventory.Add(items.ItemID.IDToItem(5));
                                    loop = false;
                                    break;
                                case ConsoleKey.N:
                                    break;
                                default:
                                    EOA.wd("Please either enter Y or N!");
                                    EOA.pressAnyKeyToContinue();
                                    break;
                            }
                        }
                    }

                    internal static void perceptionPrints()
                    {
                        if (NOTICED_BARREL && !LOOKED_IN_BARREL)
                        {
                            EOA.wd("You open the barrel to find a hatchet..");
                            EOA.wd("A vintage tomahawk from when this very tavern was a loghouse..");
                            EOA.pressAnyKeyToContinue();
                            takeItem();
                            /* =-=-=-=-=-=-=-=-=-=-= TODO ADD STUF HERE =-=-=-=-=-=-=-=-=-=-= */
                            LOOKED_IN_BARREL = true;
                            /* =-=-=-=-=-=-=-=-=-=-= TODO ADD STUF HERE =-=-=-=-=-=-=-=-=-=-= */
                            Console.ReadKey();
                            /* =-=-=-=-=-=-=-=-=-=-= TODO ADD STUF HERE =-=-=-=-=-=-=-=-=-=-= */
                        }
                        else if (TRY_NOTICED_BARREL && !LOOKED_IN_BARREL)
                        {
                            EOA.wd("You look around the building. Nothing seems out of place.");
                            TRY_NOTICED_BARREL = true;
                            Console.ReadKey();
                        }
                        else if (!Character.rollCheck("perception", 10) && !LOOKED_IN_BARREL) //if check failed
                        {
                            EOA.wd("You look around the building. Nothing seems out of place.");
                            TRY_NOTICED_BARREL = true;
                            Console.ReadKey();
                        }
                        else if (Character.rollCheck("perception", 10) && !LOOKED_IN_BARREL)
                        {
                            EOA.wd("You look around the building and see a large wooden barrel on its side, its lid slightly ajar.");
                            NOTICED_BARREL = true;
                            TRY_NOTICED_BARREL = true;
                            Console.ReadKey();
                        }
                    }
                }
            }

            public static bool mugging()
            {
                EOA.wd("[LOONIE] Gimme it all!");
                EOA.wd("You reach for your pocket.. \n");
                EOA.wd($"You have {Character.ethryl} ethryl. You can either give him your entire worth, or lie and give him only half.");
                EOA.wd("[1] Surrender all of your ethryl\n[2] Lie and give him only half of it.");
                Console.Write("> ");

                switch (Console.ReadLine())
                {
                    default:
                        Character.awardEthryl(Character.ethryl * -1);
                        EOA.wd("They didn't accept your answer and they steal your leather wallet anyway.");
                        return false;
                    case "1":
                        Character.awardEthryl(Character.ethryl * -1);
                        EOA.wd("You break the bank, and hand over your leather wallet to the thug.");
                        return false;
                    case "2":
                        Character.awardEthryl((Character.ethryl / 2) * -1);
                        EOA.wd("You reach for your wallet, but take only a few ethryl.");
                        EOA.wd("[LOONIE] Is that all you av?");
                        if (Character.rollCheck("stealth", 5))
                        {
                            EOA.wd("The thug looks at you suspiciously.");
                            EOA.wd("You stare back with a blank poker face, your stomach in knots.");
                            EOA.wd("Your stealth saved you this time.");
                            return false;
                        }
                        else
                        {
                            EOA.wd("The thug stares at you.");
                            EOA.wd("In nervous shock your hand trembles and the thug leans closer.");
                            EOA.wd("[LOONIE] You look a lil pale there kiddo.");
                            EOA.wd("[LOONIE] How abouts you give me your whole wallet.");
                            EOA.wd("The thug's companions shuffle around, and you feel a cold pain around the side of your head.");
                            EOA.wd("[LOONIE] Hehehe, some people just don't leeaar--");
                            EOA.wd("Darkness.");
                            Character.death("you tried to con a thug in his own game.");
                                return true;
                        }
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scark.ast.Other
{
    class Trade
    {
        internal static class TradeACC
        {
            internal static int numOfSelectedItem = 1;
            internal static bool Left = true;
            internal static NPCs.Trader Vendor;

            internal static void Prints()
            {
                Console.ResetColor();
                Console.Clear();

                EOA.WriteAt(Vendor.Name.ToUpper(), 0, 0);
                EOA.WriteAt($"│{Character.name.ToUpper()}", 28, 0);

                for (int i = 0; i < 55; i++)
                    EOA.WriteAt("─", i, 1);

                EOA.WriteAt($"ETHRYL: {Vendor.Ethryl}", 0, 2);
                EOA.WriteAt($"│COST│", 23, 2);
                EOA.WriteAt($"ETHRYL: {Character.ethryl}", 29, 2);
                EOA.WriteAt($"│COST", 50, 2);

                EOA.WriteAt("┬", 23, 1);
                EOA.WriteAt("┬", 50, 1);
                EOA.WriteAt("┼", 28, 1);
            }

            internal static void DrawingItems()
            {
                for (int i = 0; i < Vendor.Inventory.Count; i++)
                {
                    if (Left)
                        if (numOfSelectedItem == i + 1)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else Console.ResetColor();
                    EOA.WriteAt($"{i + 1} {Vendor.Inventory[i].Name}", 0, i + 3);
                    EOA.WriteAt($"{Vendor.Inventory[i].Price}", 24, i + 3);
                    Console.ResetColor();
                    EOA.WriteAt($"│", 28, i + 3);
                    EOA.WriteAt($"│", 50, i + 3);
                    EOA.WriteAt($"│", 23, i + 3);
                }
                for (int i = 0; i < Character.inventory.Count; i++)
                {
                    if (!Left)
                        if (numOfSelectedItem == i + 1)
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        else Console.ResetColor();
                    EOA.WriteAt($"{i + 1} {Character.inventory[i].Name}", 29, i + 3);
                    EOA.WriteAt($"{Character.inventory[i].Price}", 51, i + 3);
                    Console.ResetColor();
                    EOA.WriteAt($"│", 28, i + 3);
                    EOA.WriteAt($"│", 50, i + 3);
                    EOA.WriteAt($"│", 23, i + 3);
                }
            }

            private static void MoveSelectedItem(bool Left)
            {
                if (Left)
                {
                    if (numOfSelectedItem >= Vendor.Inventory.Count || !Vendor.Inventory.Any()) numOfSelectedItem--;
                    if (numOfSelectedItem == 0) { Left = false; numOfSelectedItem = 1; }
                }
                else
                {
                    if (numOfSelectedItem >= Character.inventory.Count || !Character.inventory.Any()) numOfSelectedItem--;
                    if (numOfSelectedItem == 0) { Left = true; numOfSelectedItem = 1; }
                }
            }

            internal static void Trade()
            {
                if (Left)
                {
                    if (Vendor.Inventory.Any())
                    {
                        if (Character.ethryl >= Vendor.Inventory[numOfSelectedItem - 1].Price)
                        {
                            Character.inventory.Add(Vendor.Inventory[numOfSelectedItem - 1]);
                            Character.ethryl += Vendor.Inventory[numOfSelectedItem - 1].Price * -1;
                            Vendor.Ethryl += Vendor.Inventory[numOfSelectedItem - 1].Price;
                            Vendor.Inventory.RemoveAt(numOfSelectedItem - 1);
                        }
                    }
                }
                else
                {
                    if (Character.inventory.Any())
                    {
                        if (Vendor.Ethryl >= Character.inventory[numOfSelectedItem - 1].Price)
                        {
                            Vendor.Inventory.Add(Character.inventory[numOfSelectedItem - 1]); //a
                            Vendor.Ethryl += Character.inventory[numOfSelectedItem - 1].Price * -1;
                            Character.ethryl += Character.inventory[numOfSelectedItem - 1].Price;
                            Character.inventory.RemoveAt(numOfSelectedItem - 1);
                        }
                    }
                }
            }

            internal static void Down()
            {
                if (Left)
                {
                    if (numOfSelectedItem < Vendor.Inventory.Count)
                        numOfSelectedItem++;
                }
                else
                {
                    if (numOfSelectedItem < Character.inventory.Count)
                        numOfSelectedItem++;
                }
            }

            internal static void Up()
            {
                if (numOfSelectedItem > 1)
                    numOfSelectedItem--;
            }

            internal static void LeftAndRight()
            {
                if (TradeACC.Left)
                {
                    if (Character.inventory.Any())
                    {
                        if (Character.inventory.Count < TradeACC.numOfSelectedItem) TradeACC.numOfSelectedItem = Character.inventory.Count;
                        TradeACC.Left = false;
                    }
                }
                else
                {
                    if (TradeACC.Vendor.Inventory.Any())
                    {
                        if (TradeACC.Vendor.Inventory.Count < TradeACC.numOfSelectedItem) TradeACC.numOfSelectedItem = TradeACC.Vendor.Inventory.Count;
                        TradeACC.Left = true;
                    }
                }
            }

            internal static void Yes()
            {
                while (true)
                {
                    TradeACC.Prints();
                    TradeACC.DrawingItems();

                    int MaxLength = 0;
                    if (TradeACC.Vendor.Inventory.Count >= Character.inventory.Count) MaxLength = TradeACC.Vendor.Inventory.Count;
                    else MaxLength = Character.inventory.Count; // << unlikely

                    EOA.WriteAt("[Enter] Trade Item", 0, MaxLength + 4);
                    EOA.WriteAt("[Arrow Keys] Select Items", 0, MaxLength + 5);
                    EOA.WriteAt("[X] Exit Menu", 0, MaxLength + 6);

                    bool exit = false;
                    switch (Console.ReadKey().Key)
                    {
                        case ConsoleKey.Enter:
                            TradeACC.Trade();
                            break;
                        case ConsoleKey.UpArrow:
                            break;
                        case ConsoleKey.DownArrow:
                            TradeACC.Down();
                            break;
                        case ConsoleKey.LeftArrow:
                        case ConsoleKey.RightArrow:
                            TradeACC.LeftAndRight();
                            break;

                        case ConsoleKey.X:
                            exit = true;
                            break;
                    }
                    Console.CursorVisible = true;
                    if (exit || ((!TradeACC.Vendor.Inventory.Any()) && (!Character.inventory.Any()))) break;
                    Console.CursorVisible = false;
                }
            }
        }

        public static void With(NPCs.Trader Vendor)
        {
            TradeACC.Vendor = Vendor;
            Console.Clear();
            Console.WriteLine($"[{TradeACC.Vendor.Name.ToUpper()}]: 'Ello there, would ya like to trade with me?");
            Console.Write("[Y] Yes\n[N] No\n> ");
            switch (Console.ReadKey().Key)
            { // TEMP: ─ │ ┬ ┼
                case ConsoleKey.Y:
                    TradeACC.Yes();
                    return;
                case ConsoleKey.N: return;
                default:
                    With(Vendor);
                    return;
            }
        }
    }
}

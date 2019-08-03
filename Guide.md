# Guides for Sārk Code!
#### LINKS:
- [General Items](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#general-items)
	- [Completed Example](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#completed-example-of-general-item)
- [General NPCs](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#general-npcs)
- [Trading NPCs](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#trading-npcs)
	- [Completed Example](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#completed-example-of-trading-npc)




## General Items
###### THE FOLLOWING IS A TUTORIAL AND HAS NOT BEEN IMPLEMENTED INTO THE GAME
1. Create a new static class (file) named the name of the item in [Pascal Case](http://wiki.c2.com/?PascalCase) inside `ast/items/general`:
```cs
namespace Scark.ast.items.general
{
	static class HealingPotion { }
}
```
2. The item has necessary properties which are the following:
- `int ID`
	- The identifying number of the item
	- In this case it will be set to `100`
- `int Price`
	- The amount of ethryl that is required to purchase this item
	- In this case it will be set to `50`
- `string Name`
	- The name of the item
	- In this case it will be set to `"Healing Potion"`
- `string Description`
	- The description of the item (eg. what it does)
	- In this case it will be set to `"A strange elixir that seems to have healing properties."`
- `string Image`
	- ASCII art of the item
	- ~~In this case it will be set to `" "`~~ [View the image in completed code](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#completed-example-of-general-item)
- `Dictionary<string, dynamic> Attributes`
	- Used to add other properties to the item (eg. How much health the item gives)
	- In this case it will be set to `{"HPGain", 20}`
_Note: these all have to be **public** and **static**_

So now the code looks like so:
```cs
static class HealingPotion
{
	public static int ID = 100;
	public static int Price = 50;
	public static Name = "Healing Potion";
	public static Description = "A strange elixir that sames to have healing properties."
	public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>
	{
		{ "HPGain", 20 }
	}
	public static string image = ""; // See in completed example below
}
```
([Completed Example](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#completed-example-of-general-item))

4. It is almost complete but the item needs to be able to be converted into a used instance of the `Item` class. To do so, add this:
```cs
public static Item ToItem() => new Item(ID, Price, Name, Description, Image, Attributes);
```

5. Now the new item must be added to the [ItemID.cs](https://github.com/SquirtleSquadProgramming/ScarkSource/blob/master/Scark/Scark/ast/items/ItemID.cs):
```cs
public class ItemID
{
	public static Item IDToItem(int item_id)
    {
    	switch (item_id)
        {
			case 100: return general.HealingPotion.ToItem();
        }

        throw new Item.UnknownException($"Could not find item with id of {item_id}");
	}

    public static Item StringToItem(string item_name)
    {
		switch (item_name)
        {
        	case "Healing Potion": return general.HealingPotion.ToItem();
		}

        throw new Item.UnknownException($"Could not find item with name of {item_name}");
	}
}
```

##### Completed Example of General Item
```cs
using System.Collections.Generic;

namespace Scark.ast.items.general
{
	static class HealingPotion
	{
		public static int ID = 100;
		public static int Price = 50;
		public static Name = "Healing Potion";
		public static Description = "A strange elixir that sames to have healing properties.";
		public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>
		{
			{ "HPGain", 20 }
		};
		public static string image = @"      _____
     `.___,'
      (___)
      <   >
       ) (
      /`-.\
     /     \
    / _    _\
   :,' `-.' `:
   |         |
   :         ;
    \       /
     `.___.'";
		
		public static Item ToItem() => new Item(ID, Price, Name, Description, Image, Attributes);
	}
}
```
#### Goto [Top](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#guides-for-s%C4%81rk-code)




## Weapon Items
###### THE FOLLOWING IS A TUTORIAL AND HAS NOT BEEN IMPLEMENTED INTO THE GAME
#### Goto [Top](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#guides-for-s%C4%81rk-code)
### WIP




## General NPCs
###### THE FOLLOWING IS A TUTORIAL AND HAS NOT BEEN IMPLEMENTED INTO THE GAME
#### Goto [Top](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#guides-for-s%C4%81rk-code)
### WIP




## Trading NPCs
###### THE FOLLOWING IS A TUTORIAL AND HAS NOT BEEN IMPLEMENTED INTO THE GAME
1. Create a new static class (file) named the name of the trading NPC in [Pascal Case](http://wiki.c2.com/?PascalCase):
```cs
namespace Scark.ast.NPCs.Traders
{
	static class Alchemist { }
}
```
2. The NPC has necessary properties which are the following:
- `string Name`
  - Name of the NPC
  - In this case it will be set to: `"Alchemist"`
- `int ID`
  - ID of the NPC
  - In this case it will be set to: `100`
- `int CurrentHP`
  - The Current Health of the NPC
  - In this case it will be set to: `50`
- `int MaxHP`
  - The Max Health of the NPC
  - In this case it will be set to: `50`
- `List<Item> Inventory`
  - The inventory of the NPC's available items
  - In this case it will be set to: `new List<Item>() { HealingPotion.ToItem()`_x5_` }`
- `int Ethryl`
  - The Ethryl of the NPC
  - In this case it will be set to: `1000`
_Note: these all have to be **public** and **static**_

So now the code looks like so:
```cs
using Scark.ast.items;
using Scark.ast.items.general;
using Scark.ast.items.weapons;

static class Alchemist
{
	public static string Name = "Alchemist";
	public static int ID = 100;
	public static CurrentHP = 50;
	public static MaxHP = 50;
	List<Item> Inventory = new List<Item>()
	{
		HealingPotion.ToItem(),
		HealingPotion.ToItem(),
		HealingPotion.ToItem(),
		HealingPotion.ToItem(),
		HealingPotion.ToItem()
	};
	public static int Ethryl = 1000;
}
```
3. It is almost done but it needs to be able to convert our NPC into a useable instance of the Trader class so add to the code:
```cs
public static Trader ToTrader() => new Trader(Name, ID, CurrentHP, MaxHP, Inventory, Ethryl);
```
##### Completed Example of Trading NPC
```cs
using System.Collections.Generic;
using Scark.ast.items;
using Scark.ast.items.general;
using Scark.ast.items.weapons;

namespace Scark.ast.NPCs.Traders
{
	static class Alchemist
	{
		public static string Name = "Alchemist";
		public static int ID = 100;
		public static CurrentHP = 50;
		public static MaxHP = 50;
		List<Item> Inventory = new List<Item>()
		{
			HealingPotion.ToItem(),
			HealingPotion.ToItem(),
			HealingPotion.ToItem(),
			HealingPotion.ToItem(),
			HealingPotion.ToItem()
		};
		public static int Ethryl = 1000;
		
		public static Trader ToTrader() => new Trader(Name, ID, CurrentHP, MaxHP, Inventory, Ethryl);
	}
}
```
#### Goto [Top](https://github.com/SquirtleSquadProgramming/ScarkSource/new/master/Guides#guides-for-s%C4%81rk-code)

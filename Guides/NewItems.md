# Adding Items
1. Create a new **static** class with the name of your item:
> static class HealingPotion { }
2. Add attributes to class, the necessary attributes are: `Dictionary<string, dynamic>`, `int ID`, `int Price`, `string Name`, `string Description`, `string Image`. My HealingPotion has an irregular property though, so in the Attributes dictionary I add the "HPGain" property. So now my class looks like this:
>	static class HealingPotion
>
>	{
>
>		public static Dictionary<string, dynamic> Attributes = new Dictionary<string, dynamic>()
>
>		{
>
>			{ "HPGain", 20 }
>
>		};
>
>		public static int ID = 100;
>
>		public static int Price = 50;
>
>		public static string Name = "Healing Potion";
>
>		public static string Description = "A strange elixir that seems to have healing properties.";
>
>   	public static image = @"     `.___,'
>
>          (___)
>
>          <   >
>
>           ) (
>
>          /\`-.\
>
>         /     \
>
>        / _    _\
>
>       :,' \`-.' \`:
>
>       |         |
>
>       :         ;
>
>        \       /
>
>         \`.___.'";
>
>	}
3. Then you have to add the `ToItem()` function which converts it to an item:
>    public static Item ToItem() => new Item(ID, Price, Name, Description, Image, Attributes);
4. Finally you need to edit the `ItemID.cs` file and add in the necessary parts:
>		public static Item IDToItem(int item_id)
>
>		{
>
>			switch (item_id)
>
>			{
>
>				case 100: return general.HealingPotion.ToItem();
>
>			}
>
>			throw new Item.UnknownException($"Could not find item with id of {item_id}");
>
>		}
>
>		public static Item StringToItem(string item_name)
>
>		{
>
>			switch (item_name)
>
>			{
>
>				case "Healing Potion": return general.HealingPotion.ToItem();
>			}
>
>		throw new Item.UnknownException($"Could not find item with name of {item_name}");
>
>		}

_Note: A weapon **needs** Class\* and Damage attributes so if you wish to add a weapon then the necessary Attributes are:_
>     { "Damage", 0 },
>
>     { "Class", "None" }
\* Valid weapon class types are: Ranged, Melee, Magic

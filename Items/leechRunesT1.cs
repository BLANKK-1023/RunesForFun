using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RunesForFun.Items
{
	public class leechRunesT1 : ModItem
	{

		public static bool ls1;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leech Runes(Tier I)");
			Tooltip.SetDefault("1% Life Steal");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 32;
			item.height = 32;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = ItemRarityID.Orange;
			ls1 = false;
		}

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            base.UpdateAccessory(player, hideVisual);
			ls1 = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 20);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}

}

using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RunesForFun.Items
{
    class leechRunesT2 : ModItem
    {
		public static bool ls2;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leech Runes(Tier II)");
			Tooltip.SetDefault("3% Life Steal");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 32;
			item.height = 32;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = ItemRarityID.Lime;
			ls2 = false;
		}

		public override void UpdateAccessory(Player player, bool hideVisual)
		{
			base.UpdateAccessory(player, hideVisual);
			ls2 = true;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 30);
			recipe.AddIngredient(ModContent.ItemType<leechRunesT1>(), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

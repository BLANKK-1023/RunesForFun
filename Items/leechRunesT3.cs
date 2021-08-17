using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RunesForFun.Items
{
    class leechRunesT3:ModItem
    {
		public static bool ls3;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Leech Runes(Tier III)");
			Tooltip.SetDefault("5% Life Steal");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 32;
			item.height = 32;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = ItemRarityID.Purple;
			ls3 = false;
		}

        public override void UpdateEquip(Player player)
        {
            base.UpdateEquip(player);
			ls3 = true;
		}

        public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.SoulofNight, 40);
			recipe.AddIngredient(ModContent.ItemType<leechRunesT2>(), 1);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

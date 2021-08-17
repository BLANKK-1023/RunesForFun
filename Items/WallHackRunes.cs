using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RunesForFun.Items
{
	class WallHackRunes : ModItem
	{
		public static bool tw;
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("PTW Charm");
			Tooltip.SetDefault("Projectiles through wall");
		}

		public override void SetDefaults()
		{
			item.accessory = true;
			item.width = 32;
			item.height = 32;
			item.value = Item.sellPrice(platinum: 1);
			item.rare = ItemRarityID.Purple;
			tw = false;
		}

		public override void UpdateEquip(Player player)
		{
			base.UpdateEquip(player);
			tw = true;
		}

		public override void AddRecipes()
		{
			ModRecipe recipe = new ModRecipe(mod);
			recipe.AddIngredient(ItemID.MusketBall, 999);
			recipe.AddIngredient(ItemID.WoodenArrow, 999);
			recipe.AddIngredient(ItemID.DirtBlock, 999);
			recipe.AddIngredient(ItemID.StoneBlock, 999);
			recipe.AddTile(TileID.WorkBenches);
			recipe.SetResult(this);
			recipe.AddRecipe();
		}
	}
}

using RunesForFun.Items;
using Terraria;
using Terraria.ModLoader;

namespace RunesForFun
{
    class LeechGlobalItem:GlobalItem
    {
        public override void SetDefaults(Item item)
        {
            base.SetDefaults(item);
            leechRunesT1.ls1 = false;
            leechRunesT2.ls2 = false;
            leechRunesT3.ls3 = false;
        }

        public override void OnHitNPC(Item item, Player player, NPC target, int damage, float knockBack, bool crit)
        {
            base.OnHitNPC(item, player, target, damage, knockBack, crit);
            
            if (leechRunesT1.ls1)
            {
                int healingAmount = damage * (int)0.01;
                player.statLife += healingAmount;
                player.HealEffect(healingAmount);
            }
            if (leechRunesT2.ls2)
            {
                int healingAmount = damage * (int)0.03;
                player.statLife += healingAmount;
                player.HealEffect(healingAmount);
            }
            if (leechRunesT3.ls3)
            {
                int healingAmount = damage * (int)0.05;
                player.statLife += healingAmount;
                player.HealEffect(healingAmount);
            }
        }
    }
}

using RunesForFun.Items;
using Terraria;
using Terraria.ModLoader;

namespace RunesForFun
{
    class LeechGlobalProjectile : GlobalProjectile
    {
        public override void SetDefaults(Projectile projectile)
        {
            base.SetDefaults(projectile);
            leechRunesT1.ls1 = false;
            leechRunesT2.ls2 = false;
            leechRunesT3.ls3 = false;

            if (WallHackRunes.tw)
            {
                projectile.tileCollide = false;
            }
        }

        public override void OnHitNPC(Projectile projectile, NPC target, int damage, float knockback, bool crit)
        {
            base.OnHitNPC(projectile, target, damage, knockback, crit);
            if (leechRunesT1.ls1)
            {
                int healingAmount = damage * (int)0.01;
                Main.player[projectile.owner].statLife += healingAmount;
                Main.player[projectile.owner].HealEffect(healingAmount);
                
            }
            if (leechRunesT2.ls2)
            {
                int healingAmount = damage * (int)0.03;
                Main.player[projectile.owner].statLife += healingAmount;
                Main.player[projectile.owner].HealEffect(healingAmount);
            }
            if (leechRunesT3.ls3)
            {
                int healingAmount = damage * (int)0.05;
                Main.player[projectile.owner].statLife += healingAmount;
                Main.player[projectile.owner].HealEffect(healingAmount);
            }
        }
    }
}

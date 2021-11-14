using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElysiumMod.Items.Projectiles.PreBoss
{
    public class BasicProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.height = 12;
            projectile.width = 12;
            projectile.melee = true;
            projectile.friendly = true;
            projectile.maxPenetrate = 1;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
            projectile.aiStyle = -1;
        }

        public override void AI()
        {
            projectile.ai[0] += 1f;
            if (projectile.ai[0] >= 15f)
            {
                projectile.ai[0] = 15f;
                projectile.velocity.Y += 0.3f;
            }
            if (projectile.velocity.Y > 16f)
            {
                projectile.velocity.Y = 16f;
            }


            projectile.velocity.X *= 0.97f;


            float scale;
            int random = Main.rand.Next(1, 3);
            if (random == 1)
            {
                scale = 0.7f;
            } else if (random == 2)
            {
                scale = 1.2f;
            } else
            {
                scale = 1.5f;
            }

            Dust.NewDust(projectile.position, projectile.width, projectile.height, DustID.Fire, 0, 0, 0, default, scale);
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Dig, projectile.position);
        }



    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Terraria;
using Terraria.ModLoader;
using Terraria.ID;

namespace ElysiumMod.Items.Weapons.PreBoss
{
    public class BasicSword : ModItem
    {

        public override void SetStaticDefaults()
        {
            Tooltip.SetDefault("This is a basic sword");
        }

        public override void SetDefaults()
        {
	    item.damage = 50; 
	    item.melee = true; 
	    item.width = 40; 
	    item.height = 40; 
	    item.useTime = 20; 
	    item.useAnimation = 20; 
	    item.knockBack = 6; 
       	    item.value = Item.buyPrice(gold: 1); 
	    item.rare = ItemRarityID.Green; 
            item.UseSound = SoundID.Item1; 
	    item.autoReuse = true; 
            item.crit = 6; 
	    item.useStyle = ItemUseStyleID.SwingThrow;
	}
	
	public override bool Shoot(Player player, ref Vector2 position, ref float speedX, ref float speedY, ref int type, ref int damage, ref float knockBack)
        {
			return true;
        }
    }
}

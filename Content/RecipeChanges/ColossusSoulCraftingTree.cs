using CalamityMod.Items.Materials;
using CalamityMod.Items.Placeables;
using CalamityMod.Tiles.Furniture.CraftingStations;
using FargowiltasSouls.Content.Items.Materials;
using SOTS.Items.Chaos;
using SpiritMod.Items.Accessory;
using Terraria.ModLoader;
using Terraria;
using Terraria.ID;
using ThoriumMod.Items.BossLich;
using ThoriumMod.Items.Donate;
using ThoriumMod.Items.Misc;
using ThoriumMod.Tiles;

namespace TheBereftSouls.Content.RecipeChanges;

[ExtendsFromMod("FargowiltasSouls", "SOTS", "Thorium", "Spirit", "Calamity")]
public class ColossusSoulCraftingTree : ModSystem
{
    public override void PostAddRecipes()
    {
        for (int i = 0; i < Recipe.numRecipes; i++)
        {
            Recipe recipe = Main.recipe[i];

            switch (recipe.createItem.type)
            {
                case var id when id == ModContent.ItemType<VoidmageIncubator>():
                    recipe.AddIngredient(ModContent.ItemType<Eridanium>(), 5);
                    recipe.AddIngredient(ModContent.ItemType<ParticleRelocator>());
                    
                    recipe.RemoveTile(TileID.MythrilAnvil);
                    recipe.AddTile(TileID.AlchemyTable);
                    break;
                case var id when id == ModContent.ItemType<GhastlyCarapace>():
                    recipe.AddIngredient(ModContent.ItemType<VoidmageIncubator>());
                    recipe.AddIngredient(ModContent.ItemType<IllusionistEye>());
                    recipe.AddIngredient(ModContent.ItemType<Phylactery>());
                    recipe.AddIngredient(ModContent.ItemType<CapeoftheSurvivor>());
                    recipe.AddIngredient(ModContent.ItemType<SpiritsGrace>());
                    recipe.AddIngredient(ModContent.ItemType<EffulgentFeather>(), 5);
                    recipe.AddIngredient(ModContent.ItemType<AscendantSpiritEssence>(), 6);
                    recipe.AddIngredient(ModContent.ItemType<PlantyMush>(), 10);

                    recipe.RemoveTile(ModContent.TileType<SoulForge>());
                    recipe.AddTile(ModContent.TileType<CosmicAnvil>());
                    break;
            }
        }
    }
}
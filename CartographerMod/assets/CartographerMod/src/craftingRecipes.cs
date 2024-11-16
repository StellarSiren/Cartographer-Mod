using Vintagestory.API.Common;

public class CartographerCraftingRecipes : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        base.Start(api);

        api.World.Config.SetCraftingRecipe(new GridRecipe()
        {
            Ingredients = new CraftingIngredient[]
            {
                new CraftingIngredient() { Code = "cartographer-mod:mapfragment", Quantity = 3 }
            },
            Output = new ItemStack(api.World.GetItem(new AssetLocation("cartographer-mod:completedmap")))
        });
    }
}

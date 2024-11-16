using Vintagestory.API.Common;

[assembly: ModInfo("CartographerMod",
    Version = "1.0.0",
    Authors = new[] { "Reiko" },
    Description = "A mod that adds ancient cartographers and their maps to Vintage Story."
)]

public class CartographerMod : ModSystem
{
    public override void Start(ICoreAPI api)
    {
        base.Start(api);

        api.RegisterItemClass("ItemMapFragment", typeof(ItemMapFragment));
        api.RegisterBlockClass("BlockCartographyStation", typeof(BlockCartographyStation));
    }

    public override void StartServerSide(ICoreServerAPI api)
    {
        base.StartServerSide(api);

        api.ModLoader.GetModSystem<CartographerStructures>().StartServerSide(api);
    }
}

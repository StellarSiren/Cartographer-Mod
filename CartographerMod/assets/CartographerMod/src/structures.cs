using Vintagestory.API.Common;
using Vintagestory.API.Server;

public class CartographerStructures : ModSystem
{
    public override void StartServerSide(ICoreServerAPI api)
    {
        base.StartServerSide(api);

        // Register Guildhall
        api.World.Config.SetStructure(new WorldStructure()
        {
            Code = "cartographer-mod:guildhall",
            Json = api.Assets.Get("cartographer-mod:worldgen/guildhall.json"),
            Type = EnumStructureType.Structure
        });

        // Register Ruins
        api.World.Config.SetStructure(new WorldStructure()
        {
            Code = "cartographer-mod:ruins",
            Json = api.Assets.Get("cartographer-mod:worldgen/ruins.json"),
            Type = EnumStructureType.Ruin
        });
    }
}

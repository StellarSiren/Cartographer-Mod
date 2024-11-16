public class ModEvents : ModSystem
{
    public override void StartClientSide(ICoreClientAPI api)
    {
        base.StartClientSide(api);

        api.Event.OnPlayerInteract += (player, blockSel, itemSel) =>
        {
            if (itemSel.Itemstack?.Collectible.Code.Path == "mapfragment")
            {
                api.World.Logger.Notification("You found a piece of an ancient map!");
            }
        };
    }
}

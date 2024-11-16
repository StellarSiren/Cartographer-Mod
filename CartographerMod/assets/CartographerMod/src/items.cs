using Vintagestory.API.Common;

public class ItemMapFragment : Item
{
    public override void OnHeldInteractStart(ItemSlot slot, EntityAgent byEntity, BlockSelection blockSel, EntitySelection entitySel, ref EnumHandHandling handling)
    {
        handling = EnumHandHandling.PreventDefault;
        byEntity.World.Logger.Notification("You hold a piece of an ancient map!");
    }
}

public static class CartographerUtils
{
    public static bool IsMapFragment(ItemStack stack)
    {
        return stack?.Collectible.Code.Path == "mapfragment";
    }

    public static BlockPos FindGuildLocation(IWorldAccessor world)
    {
        // Placeholder logic for finding a guild
        return new BlockPos(100, 50, 100);
    }
}

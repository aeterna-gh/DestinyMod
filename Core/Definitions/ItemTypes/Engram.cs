namespace DestinyMod.Core.Definitions.ItemTypes
{
    public abstract class Engram : DestinyItem
    {
        public bool isFocused;

        public Dictionary<int, (DestinyItem itemToDrop, int dropChance)> engramLootPool;

        public int focusKey;



        public override void SetDefaults()
        {
            Item.maxStack = 1;

            base.SetDefaults();
        }
    }
}
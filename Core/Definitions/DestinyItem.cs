namespace DestinyMod.Core.Definitions
{
    public abstract class DestinyItem : ModItem
    {
        public const string itemAssetDir = "DestinyMod/Assets/textures/";

        public bool canBeMasterworked;

        public bool isMasterworked;

        public DestinyRarity itemRarity;

        public Element itemElement;

        public int exoticEarnCount;

        public string extraText;

        public string internalName;

        public Texture2D inventoryIconTexture;

        public override void SetDefaults()
        {
            Item.height = 20;
            Item.width = 20;

            base.SetDefaults();
        }
    }
}
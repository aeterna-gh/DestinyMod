namespace DestinyMod.Core.Definitions
{
    public abstract class DestinyRarity : ModType
    {
        public const string inventoryDir = "DestinyMod/Assets/textures/ui/inventory/item_frames";

        public Color rarityColor;

        public int ID { get; private set; }

        public int sortOrder;

        public Texture2D itemFrameTexture;

        public virtual void SetDefaults() { }

        protected sealed override void Register()
        {
            ModTypeLookup<DestinyRarity>.Register(this);

            ID = DestinyRarityLoader.Add(this);
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}
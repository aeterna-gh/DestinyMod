namespace DestinyMod.Core.Definitions
{
    public abstract class DestinyItem : ModItem
    {
        public const string itemAssetDir = "DestinyMod/Assets/textures/";

        public bool canBeMasterworked;

        public bool isMasterworked;

        public DestinyRarity itemRarity;

        public int exoticEarnCount;

        public int masterworkLevel;

        public string tooltipText;

        public string internalName;

        public Texture2D inventoryIconTexture;

        public override void SetDefaults()
        {
            Item.height = 20;
            Item.width = 20;

            base.SetDefaults();
        }

        public void MasterworkLevelUp() 
        {
            
        }

        internal void MasterworkMe()
        {


            OnMasterworked();
        }

        public virtual void OnMasterworked() { }

        public override void LoadData(TagCompound tag)
        {
            masterworkLevel = tag.GetInt(nameof(masterworkLevel));

            base.LoadData(tag);
        }

        public override void SaveData(TagCompound tag)
        {
            tag[nameof(masterworkLevel)] = masterworkLevel;

            base.SaveData(tag);
        }
    }
}
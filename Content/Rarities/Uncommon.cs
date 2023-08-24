namespace DestinyMod.Content.Rarities
{
    [Autoload(false)]
    internal class Uncommon : DestinyRarity
    {
        public override void SetDefaults()
        {
            itemFrameTexture = (Texture2D)ModContent.Request<Texture2D>($"{inventoryDir}/uncommon_frame");
            rarityColor = Color.ForestGreen;
            sortOrder = 3;

            base.SetDefaults();
        }
    }
}
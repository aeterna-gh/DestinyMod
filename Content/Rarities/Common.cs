namespace DestinyMod.Content.Rarities
{
    [Autoload(false)]
    internal class Common : DestinyRarity
    {
        public override void SetDefaults()
        {
            itemFrameTexture = (Texture2D)ModContent.Request<Texture2D>($"{inventoryDir}/common_frame");
            rarityColor = Color.White;
            sortOrder = 4;

            base.SetDefaults();
        }
    }
}
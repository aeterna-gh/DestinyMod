namespace DestinyMod.Content.Rarities
{
    [Autoload(false)]
    internal class Exotic : DestinyRarity
    {
        public override void SetDefaults()
        {
            itemFrameTexture = (Texture2D)ModContent.Request<Texture2D>($"{inventoryDir}/exotic_frame");
            rarityColor = Color.Goldenrod;
            sortOrder = 0;

            base.SetDefaults();
        }
    }
}
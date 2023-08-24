namespace DestinyMod.Content.Rarities
{
    [Autoload(false)]
    internal class Rare : DestinyRarity
    {
        public override void SetDefaults()
        {
            itemFrameTexture = (Texture2D)ModContent.Request<Texture2D>($"{inventoryDir}/rare_frame");
            rarityColor = Color.SkyBlue;
            sortOrder = 2;

            base.SetDefaults();
        }
    }
}
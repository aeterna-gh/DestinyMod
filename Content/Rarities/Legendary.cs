namespace DestinyMod.Content.Rarities
{
    [Autoload(false)]
    internal class Legendary : DestinyRarity
    {
        public override void SetDefaults()
        {
            itemFrameTexture = (Texture2D)ModContent.Request<Texture2D>($"{inventoryDir}/legendary_frame");
            rarityColor = Color.MediumPurple;
            sortOrder = 1;

            base.SetDefaults();
        }
    }
}
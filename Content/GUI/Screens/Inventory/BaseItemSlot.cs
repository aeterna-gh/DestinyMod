namespace DestinyMod.Content.GUI.Screens.Inventory
{
    public abstract class BaseItemSlot<T> : UIElement where T : DestinyItem
    {
        public T item;

        public float scale;

        public override void Draw(SpriteBatch spriteBatch)
        {
            Texture2D tex = item.inventoryIconTexture;
            Texture2D frameTex = item.rarity.itemFrameTexture;
            Vector2 pos = GetDimensions().Center();



            base.Draw(spriteBatch);
        }
    }

    public sealed class WeaponItemSlot : BaseItemSlot<Weapon>
    {
        public WeaponItemSlot(Weapon item, int index, float scale = 1)
        {
            this.item = item;

            Width.Set(50 * scale, 0);
            Height.Set(50 * scale, 0);

            this.scale = scale;
        }
    }
}
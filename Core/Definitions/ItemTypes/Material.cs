namespace DestinyMod.Core.Definitions.ItemTypes
{
    public abstract class Material : DestinyItem
    {


        public override void SetDefaults()
        {
            Item.material = true;

            Item.maxStack = 999;

            base.SetDefaults();
        }
    }
}
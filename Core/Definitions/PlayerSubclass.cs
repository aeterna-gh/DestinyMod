namespace DestinyMod.Core.Definitions
{
    public abstract class PlayerSubclass : ModType
    {
        public int ID { get; private set; }

        public Element element;

        public virtual void SetDefaults()
        {

        }

        protected sealed override void Register()
        {
            ModTypeLookup<PlayerSubclass>.Register(this);

            ID = PlayerSubclassLoader.Add(this);
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}
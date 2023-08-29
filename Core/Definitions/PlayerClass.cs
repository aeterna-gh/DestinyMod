namespace DestinyMod.Core.Definitions
{
    public abstract class PlayerClass : ModType
    {
        public int ID { get; private set; }

        public List<PlayerSubclass> classSubclasses;

        public virtual new void Load() { }

        public virtual void SetDefaults() { }

        public virtual new void Unload() { }

        protected sealed override void Register()
        {
            ModTypeLookup<PlayerClass>.Register(this);

            ID = PlayerClassLoader.Add(this);
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}
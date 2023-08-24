namespace DestinyMod.Core.Definitions
{
    public abstract class Element : ModType
    {
        public int ID { get; private set; }

        public Color elementColor;

        public Texture2D elementIconTexture;

        public virtual void SetDefaults() { }

        protected sealed override void Register()
        {
            ModTypeLookup<Element>.Register(this);

            ID = ElementLoader.Add(this);
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}
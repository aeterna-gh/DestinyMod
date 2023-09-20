namespace DestinyMod.Core.Definitions
{
    public abstract class Trait : ModType
    {
        public bool isIntrinsic = false;

        public int ID { get; private set; }

        public string traitName;

        public string traitDescription;

        public Texture2D traitIcon;

        public virtual void LoadTrait() { }

        public virtual void SetDefaults() { }

        /// <summary>
        /// How this trait affects the piece of armor it's on.
        /// </summary>
        /// <param name="armor"></param>
        public virtual void TraitEffect(Armor armor) { }

        /// <summary>
        /// How this trait affects the player.
        /// </summary>
        /// <param name="player"></param>
        public virtual void TraitEffect(DestinyPlayer player) { }

        /// <summary>
        /// How this trait affects the weapon it's on.
        /// </summary>
        /// <param name="weapon"></param>
        public virtual void TraitEffect(Weapon weapon) { }

        public virtual void UnloadTrait() { }

        protected sealed override void Register()
        {
            ModTypeLookup<Trait>.Register(this);

            ID = TraitLoader.Add(this);
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}
namespace DestinyMod.Core.Definitions
{
    public abstract class Trait : ModType, TagSerializable
    {
        public static readonly Func<TagCompound, Trait> DESERIALIZER = Load;

        public bool isIntrinsic = false;

        public int ID { get; private set; }

        public string traitName;

        public string traitDescription;

        public Texture2D traitIcon;

        public TagCompound SerializeData() => new() { [nameof(ID)] = ID };

        public static Trait Load(TagCompound tag) => TraitLoader.Get(tag.GetInt(nameof(ID)));

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
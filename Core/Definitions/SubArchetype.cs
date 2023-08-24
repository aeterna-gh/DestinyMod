namespace DestinyMod.Core.Definitions
{
    public abstract class SubArchetype : ModType
    {
        public int ID { get; private set; }

        public string subArchName;

        public string subArchDesc;

        /// <summary>
        /// Allows you to modify stats based on the Archetype using this SubArchetype.
        /// </summary>
        /// <param name="archetype"></param>
        public virtual void ModifyByArchetype(Archetype archetype) { }

        public virtual void SetDefaults() { }

        /// <summary>
        /// Allows you to make special "passive" effects to the weapon with this subarchetype.
        /// </summary>
        /// <param name="weapon"></param>
        public virtual void SubArchEffect(Weapon weapon) { }

        protected sealed override void Register()
        {
            ModTypeLookup<SubArchetype>.Register(this);

            //ID = 
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}
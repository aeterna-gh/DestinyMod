namespace DestinyMod.Core.Definitions
{
    public abstract class Archetype : ModType
    { 
        public int ID { get; private set; }

        public int statChargeTime;

        public int statDrawTime;

        public int statImpact;

        public int statRPM;

        public int shotDownTime;

        public int shotDuration;

        /// <summary>
        /// Determines whether you can use this weapon again. <para></para>
        /// Determined by <see cref="shotDownTime"/> and ammo count.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        public virtual bool CanUse(Weapon weapon) => false;

        public virtual new void Load() { }

        /// <summary>
        /// Determines how this archetype is used.
        /// </summary>
        /// <param name="weapon"></param>
        public virtual void OnUse(Weapon weapon) { }

        public virtual void SetDefaults() { }

        public virtual new void Unload() { }

        protected sealed override void Register()
        {
            ModTypeLookup<Archetype>.Register(this);

            ID = ArchetypeLoader.Add(this);
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}
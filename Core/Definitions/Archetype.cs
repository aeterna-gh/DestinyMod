namespace DestinyMod.Core.Definitions
{
    public abstract class Archetype : ModType
    {
        public int ID { get; private set; }

        public int statImpact;

        public int statRPM;

        public int shotDownTime;

        public int shotDuration;

        public int drawTime;

        public int chargeTime;

        /// <summary>
        /// Determines whether you can use this weapon again. <para></para>
        /// Determined by <see cref="shotDownTime"/> and ammo count.
        /// </summary>
        /// <param name="weapon"></param>
        /// <returns></returns>
        public virtual bool CanUse(Weapon weapon) => false;

        /// <summary>
        /// Determines how this archetype is used.
        /// </summary>
        /// <param name="weapon"></param>
        public virtual void OnUse(Weapon weapon) { }

        public virtual void SetDefaults() { }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }

        protected sealed override void Register()
        {
            ModTypeLookup<Archetype>.Register(this);

            //ID =
        }
    }
}
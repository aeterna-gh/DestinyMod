namespace DestinyMod.Core.Definitions
{
    public abstract class Ability : ModType
    {
        public Element abilityElement;

        public int cooldownTimeCurrent;

        public int cooldownTimeMaximum;

        public int ID { get; private set; }

        protected sealed override void Register()
        {
            ModTypeLookup<Ability>.Register(this);

            ID = AbilityLoader.Add(this, null);
        }

        public virtual void OnCast() { }
    }
}
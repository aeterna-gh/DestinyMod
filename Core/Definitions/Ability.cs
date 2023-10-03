namespace DestinyMod.Core.Definitions
{
    public abstract class Ability : ModType
    {
        public Element abilityElement;

        public int cooldownTimeCurrent;

        public int cooldownTimeMaximum;

        protected sealed override void Register()
        {
            ModTypeLookup<Ability>.Register(this);

            //ID = AbilityLoader.Add(this);
        }

        public virtual void OnCast() { }
    }
}
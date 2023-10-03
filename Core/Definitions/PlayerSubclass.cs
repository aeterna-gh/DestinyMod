using DestinyMod.Core.Definitions.AbilityTypes;

namespace DestinyMod.Core.Definitions
{
    public abstract class PlayerSubclass : ModType
    {
        public int ID { get; private set; }

        public Element element;

        public List<GrenadeAbility> grenadeAbilities;

        public List<MeleeAbility> meleeAbilities;

        public List<SuperAbility> superAbilities;

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
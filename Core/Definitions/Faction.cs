namespace DestinyMod.Core.Definitions
{
    public abstract class Faction : ModType
    {
        public int ID { get; private set; }

        public Dictionary<Faction, int> aggressionDict;

        public Dictionary<Element, int> elementResistances;

        public Faction isSubFactionOf;

        public List<DestinyNPC> factionInclusives;

        public virtual void SetDefaults() { }

        protected sealed override void Register()
        {
            ModTypeLookup<Faction>.Register(this);

            //ID = ...
        }

        public sealed override void SetupContent()
        {
            SetDefaults();

            base.SetupContent();
        }
    }
}
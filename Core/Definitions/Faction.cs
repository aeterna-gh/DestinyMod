namespace DestinyMod.Core.Definitions
{
    public abstract class Faction : ModType
    {
        public int ID { get; private set; }

        public Dictionary<Faction, int> aggressionDict;

        public Dictionary<Element, int> elementResistances;


    }
}
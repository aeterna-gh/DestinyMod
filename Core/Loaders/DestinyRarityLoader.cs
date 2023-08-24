namespace DestinyMod.Core.Loaders
{
    internal static class DestinyRarityLoader
    {
        internal static class DRareDefs
        {
            public static DestinyRarity Common { get; internal set; }

            public static DestinyRarity Uncommon { get; internal set; }

            public static DestinyRarity Rare { get; internal set; }

            public static DestinyRarity Legendary { get; internal set; }

            public static DestinyRarity Exotic { get; internal set; }
        }

        private static readonly List<DestinyRarity> _rarities = new();

        public static int Count => _rarities.Count;

        internal static int Add(DestinyRarity rarity)
        {
            int count = Count;
            _rarities.Add(rarity);
            return count;
        }

        public static DestinyRarity Get(int index) => index < 0 || index >= _rarities.Count ? null : _rarities[index];
        public static DestinyRarity Get(RarityID ID) => (int)ID < 0 || (int)ID >= _rarities.Count ? null : _rarities[(int)ID];

        public static void Load() 
        {
            DestinyMod mod = DestinyMod.Instance;

            mod.AddContent(DRareDefs.Common = new Common());
            mod.AddContent(DRareDefs.Uncommon = new Uncommon());
            mod.AddContent(DRareDefs.Rare = new Rare());
            mod.AddContent(DRareDefs.Legendary = new Legendary());
            mod.AddContent(DRareDefs.Exotic = new Exotic());
        }

        public static void Unload() 
        { 
            _rarities.Clear();
        }
    }
}
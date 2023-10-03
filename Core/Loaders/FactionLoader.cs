namespace DestinyMod.Core.Loaders
{
    internal class FactionLoader
    {
        public static class FactionDefs
        {
            public static Faction Cabal { get; internal set; }
            public static Faction Cabal_RedLegion { get; internal set; }
            public static Faction Cabal_ShadowLegion { get; internal set; }
            public static Faction Cabal_Skyburners { get; internal set; }

            public static Faction Fallen { get; internal set; }
            public static Faction Fallen_Dusk { get; internal set; }
            public static Faction Fallen_SIVA { get; internal set; }

            public static Faction Hive { get; internal set; }
            public static Faction Hive_LucentBrood { get; internal set; }

            public static Faction Scorn { get; internal set; }

            public static Faction Taken { get; internal set; }

            public static Faction Vex { get; internal set; }
            public static Faction Vex_Virgo { get; internal set; }
        }

        private static readonly List<Faction> _factions = new();

        public static int Count => _factions.Count;

        internal static int Add(Faction faction)
        {
            int count = Count;

            _factions.Add(faction);

            return count;
        }

        public static Faction Get(int index) => index < 0 || index >= _factions.Count ? null : _factions[index];
        public static Faction Get(ElementID index) => (int)index < 0 || (int)index >= _factions.Count ? null : _factions[(int)index];


    }
}
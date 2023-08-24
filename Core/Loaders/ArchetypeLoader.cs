namespace DestinyMod.Core.Loaders
{
    public static class ArchetypeLoader
    {
        internal static class ArchetypeDefs
        {
            public static Archetype AutoRifle { get; internal set; }
            public static Archetype Bow { get; internal set; }
            public static Archetype BreechGrenadeLauncher { get; internal set; }
            public static Archetype FusionRifle { get; internal set; }
            public static Archetype Glaive { get; internal set; }
            public static Archetype GrenadeLauncher { get; internal set; }
            public static Archetype HandCannon { get; internal set; }
            public static Archetype LinearFusionRifle { get; internal set; }
            public static Archetype MachineGun { get; internal set; }
            public static Archetype PulseRifle { get; internal set; }
            public static Archetype ScoutRifle { get; internal set; }
            public static Archetype Shotgun { get; internal set; }
            public static Archetype Sidearm { get; internal set; }
            public static Archetype SniperRifle { get; internal set; }
            public static Archetype SubmachineGun { get; internal set; }
            public static Archetype Sword { get; internal set; }
            public static Archetype TraceRifle { get; internal set; }
        }

        private static readonly List<Archetype> _archetypes = new();
        public static int Count => _archetypes.Count;

        internal static int Add(Archetype archetype)
        {
            int count = Count;
            _archetypes.Add(archetype);
            return count;
        }

        public static Archetype Get(int index) => index < 0 || index >= _archetypes.Count ? null : _archetypes[index];
        public static Archetype Get(ArchetypeID ID) => (int)ID < 0 || (int)ID >= _archetypes.Count ? null : _archetypes[(int)ID];

        public static void Load() 
        {
            DestinyMod mod = DestinyMod.Instance;

            mod.AddContent(ArchetypeDefs.AutoRifle = null);

        }

        public static void Unload() 
        {
            foreach (var field in typeof(ArchetypeDefs).GetFields().Where(f => f.FieldType == typeof(Archetype)))
                field.SetValue(null, null);

            _archetypes.Clear();
        }
    }
}
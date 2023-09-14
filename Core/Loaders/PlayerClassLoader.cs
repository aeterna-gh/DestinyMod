using DestinyMod.Content.Classes;

namespace DestinyMod.Core.Loaders
{
    public static class PlayerClassLoader
    {
        public static class ClassDefs
        {
            public static PlayerClass Hunter { get; internal set; }

            public static PlayerClass Titan { get; internal set; }

            public static PlayerClass Warlock { get; internal set; }
        }

        private static readonly List<PlayerClass> _classes = new();

        public static int Count => _classes.Count;

        internal static int Add(PlayerClass playerClass)
        {
            int count = Count;

            _classes.Add(playerClass);

            return count;
        }

        public static PlayerClass Get(int index) => index < 0 || index >= _classes.Count ? null : _classes[index];
        public static PlayerClass Get(ClassID index) => (int)index < 0 || (int)index >= _classes.Count ? null : _classes[(int)index];


        internal static void Load()
        {
            DestinyMod mod = DestinyMod.Instance;

            mod.AddContent(ClassDefs.Hunter = new Hunter());
            mod.AddContent(ClassDefs.Titan = new Titan());
            mod.AddContent(ClassDefs.Warlock = new Warlock());
        }

        internal static void Unload()
        {
            foreach (var field in typeof(ClassDefs).GetFields().Where(f => f.FieldType == typeof(PlayerClass)))
                field.SetValue(null, null);

            _classes.Clear();
        }
    }

    public static class PlayerSubclassLoader
    {
        public static class SubclassDefs
        {
            public static PlayerSubclass Gunslinger { get; internal set; }

            public static PlayerSubclass Arcstrider { get; internal set; }

            public static PlayerSubclass Nightstalker { get; internal set; }

            public static PlayerSubclass Revenant { get; internal set; }

            public static PlayerSubclass Threadrunner { get; internal set; }

            public static PlayerSubclass Sunbreaker { get; internal set; }

            public static PlayerSubclass Striker { get; internal set; }

            public static PlayerSubclass Sentinel { get; internal set; }

            public static PlayerSubclass Behemoth { get; internal set; }

            public static PlayerSubclass Berserker { get; internal set; }

            public static PlayerSubclass Dawnblade { get; internal set; }

            public static PlayerSubclass Stormcaller { get; internal set; }

            public static PlayerSubclass Voidwalker { get; internal set; }

            public static PlayerSubclass Shadebinder { get; internal set; }

            public static PlayerSubclass Broodweaver { get; internal set; }
        }

        private static readonly List<PlayerSubclass> _subclasses = new();

        public static int Count => _subclasses.Count;

        internal static int Add(PlayerSubclass subclass)
        {
            int count = Count;

            _subclasses.Add(subclass);

            return count;
        }

        public static PlayerSubclass Get(int index) => index < 0 || index >= _subclasses.Count ? null : _subclasses[index];
        public static PlayerSubclass Get(SubclassID index) => (int)index < 0 || (int)index >= _subclasses.Count ? null : _subclasses[(int)index];

        internal static void Load()
        {
            DestinyMod mod = DestinyMod.Instance;

            mod.AddContent(SubclassDefs.Gunslinger = new Gunslinger());
            mod.AddContent(SubclassDefs.Arcstrider = new Arcstrider());
            mod.AddContent(SubclassDefs.Nightstalker = new Nightstalker());
            mod.AddContent(SubclassDefs.Revenant = new Revenant());
            mod.AddContent(SubclassDefs.Threadrunner = new Threadrunner());
            mod.AddContent(SubclassDefs.Sunbreaker = new Sunbreaker());
            mod.AddContent(SubclassDefs.Striker = new Striker());
            mod.AddContent(SubclassDefs.Sentinel = new Sentinel());
            mod.AddContent(SubclassDefs.Behemoth = new Behemoth());
            mod.AddContent(SubclassDefs.Berserker = new Berserker());
            mod.AddContent(SubclassDefs.Dawnblade = new Dawnblade());
            mod.AddContent(SubclassDefs.Stormcaller = new Stormcaller());
            mod.AddContent(SubclassDefs.Voidwalker = new Voidwalker());
            mod.AddContent(SubclassDefs.Shadebinder = new Shadebinder());
            mod.AddContent(SubclassDefs.Broodweaver = new Broodweaver());
        }

        internal static void Unload()
        {
            foreach (var field in typeof(SubclassDefs).GetFields().Where(f => f.FieldType == typeof(PlayerSubclass)))
                field.SetValue(null, null);

            _subclasses.Clear();
        }
    }
}
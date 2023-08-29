namespace DestinyMod.Core.Loaders
{
    internal static class SubArchetypeLoader
    {
        internal static class SubArchDefs
        {

        }

        private static readonly List<SubArchetype> _subArchetypes = new();

        public static int Count => _subArchetypes.Count;

        internal static int Add(SubArchetype subArchetype)
        {
            int count = Count;

            _subArchetypes.Add(subArchetype);

            return count;
        }

        public static SubArchetype Get(int index) => index < 0 || index >= _subArchetypes.Count ? null : _subArchetypes[index];

        public static void Load()
        {
            DestinyMod mod = DestinyMod.Instance;

            foreach (SubArchetype subArch in _subArchetypes)
                subArch.Load();
        }

        public static void Unload()
        {
            foreach (SubArchetype subArch in _subArchetypes)
                subArch.Unload();

            foreach (var field in typeof(SubArchDefs).GetFields().Where(f => f.FieldType == typeof(SubArchetype)))
                field.SetValue(null, null);

            _subArchetypes.Clear();
        }
    }
}
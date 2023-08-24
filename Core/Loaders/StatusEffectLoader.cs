namespace DestinyMod.Core.Loaders
{
    internal static class StatusEffectLoader
    {
        internal static class SEDefs
        {

        }

        private static readonly List<StatusEffect> _effects = new();

        public static int Count => _effects.Count;

        internal static int Add(StatusEffect effect)
        {
            int count = Count;
            _effects.Add(effect);
            return count;
        }

        public static StatusEffect Get(int index) => index < 0 || index >= _effects.Count ? null : _effects[index];

        public static void Load() 
        {
            DestinyMod mod = DestinyMod.Instance;


        }

        public static void Unload() 
        { 
            _effects.Clear();
        }
    }
}